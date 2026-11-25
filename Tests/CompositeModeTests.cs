using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Netch.Models.Modes;
using Netch.Models.Modes.ProcessMode;
using Netch.Services;
using Netch.Utils;

namespace Tests;

[TestClass]
public class CompositeModeTests
{
    public TestContext TestContext { get; set; } = null!;
    [TestMethod]
    public void FromModes_MergesDistinctRulesAndProtocolFlags()
    {
        var modeA = new Redirector
        {
            Remark = new() { { "en", "Game A" }, { "zh-CN", "游戏 A" } },
            FilterTCP = true,
            FilterUDP = false,
            Handle = new() { "^steam\\.exe$", "^game_a\\.exe$" },
            Bypass = new() { "^common_updater\\.exe$" }
        };

        var modeB = new Redirector
        {
            Remark = new() { { "en", "Game B" }, { "zh-CN", "游戏 B" } },
            FilterTCP = false,
            FilterUDP = true,
            Handle = new() { "^game_b\\.exe$", "^steam\\.exe$" },
            Bypass = new() { "^common_updater\\.exe$", "^b_crashpad\\.exe$" }
        };

        var composite = CompositeMode.FromModes(new[] { modeA, modeB }, "Test Group", isTemp: true);

        // Deduplication and aggregation
        Assert.AreEqual(3, composite.Handle.Count);
        CollectionAssert.Contains(composite.Handle, "^steam\\.exe$");
        CollectionAssert.Contains(composite.Handle, "^game_a\\.exe$");
        CollectionAssert.Contains(composite.Handle, "^game_b\\.exe$");

        Assert.AreEqual(2, composite.Bypass.Count);
        CollectionAssert.Contains(composite.Bypass, "^common_updater\\.exe$");
        CollectionAssert.Contains(composite.Bypass, "^b_crashpad\\.exe$");

        // Protocol flag union
        Assert.IsTrue(composite.FilterTCP);
        Assert.IsTrue(composite.FilterUDP);
        Assert.IsTrue(composite.IsTemporary);
    }

    [TestMethod]
    public void CompositeMode_FileRoundTrip_PreservesProperties()
    {
        var tempFile = Path.Combine(Path.GetTempPath(), $"swiftrelay_test_{Guid.NewGuid():N}.json");
        try
        {
            var composite = new CompositeMode
            {
                FullName = tempFile,
                Remark = new() { { "en", "Custom Group" }, { "zh-CN", "自定义模式组" } },
                SubModes = new() { @"Basic\Bypass LAN.json", @"Game\Apex.json" },
                Handle = new() { "^r5apex\\.exe$" },
                Bypass = new() { "^easyanticheat\\.exe$" }
            };

            composite.WriteFile();

            var jsonContent = File.ReadAllText(tempFile);
            Assert.IsTrue(jsonContent.Contains("subModes"), "JSON should contain subModes array property");

            var deserialized = ModeHelper.LoadMode(tempFile);
            Assert.IsNotNull(deserialized);
            Assert.IsInstanceOfType(deserialized, typeof(CompositeMode));

            var comp = (CompositeMode)deserialized;
            Assert.AreEqual(2, comp.SubModes.Count);
            Assert.AreEqual(@"Basic\Bypass LAN.json", comp.SubModes[0]);
            Assert.AreEqual(@"Game\Apex.json", comp.SubModes[1]);
            CollectionAssert.Contains(comp.Handle, "^r5apex\\.exe$");
            CollectionAssert.Contains(comp.Bypass, "^easyanticheat\\.exe$");
        }
        finally
        {
            if (File.Exists(tempFile))
                File.Delete(tempFile);
        }
    }

    [TestMethod]
    public void CompositeMode_ToString_IncludesProcessAndGroupBadgeAndTempSuffix()
    {
        var comp = new CompositeMode
        {
            IsTemporary = true,
            Remark = new() { { "en", "Test Group" }, { "zh-CN", "测试组" } }
        };

        var str = comp.ToString();
        Assert.IsTrue(str.Contains("[1·") || str.Contains("[1]"));
        Assert.IsTrue(str.Contains("组") || str.Contains("Group"));
        Assert.IsTrue(str.Contains("临") || str.Contains("Temp"));

        comp.IsTemporary = false;
        var permStr = comp.ToString();
        Assert.IsFalse(permStr.Contains("临") || permStr.Contains("Temp"));
    }

    [TestMethod]
    public void MultiModeForm_Layout_VerifyRender()
    {
        var tcs = new TaskCompletionSource();
        var thread = new Thread(() =>
        {
            Application.ThreadException += (_, args) => tcs.TrySetException(args.Exception);
            try
            {
                using var form = new Netch.Forms.ModeForms.MultiModeForm();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new System.Drawing.Point(-2000, -2000);
                form.Show();
                form.Size = new System.Drawing.Size(820, 560);
                Application.DoEvents();

                void Dump(Control c, string indent)
                {
                    Console.WriteLine($"{indent}{c.GetType().Name} [{c.Name}] Text='{c.Text}' Bounds={c.Bounds}");
                    foreach (Control child in c.Controls)
                        Dump(child, indent + "  ");
                }
                Dump(form, "");

                using var bmp = new System.Drawing.Bitmap(form.Width, form.Height);
                form.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, form.Width, form.Height));
                bmp.Save(@"C:\Users\mightnire\.gemini\antigravity\brain\e2001d2d-4e92-4c6b-843b-1ee7e90a765d\multi_mode_preview_fixed.png");

                form.Close();
                tcs.SetResult();
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        tcs.Task.Wait(5000);
    }

    [TestMethod]
    public void SettingForm_Layout_VerifyRender()
    {
        var tcs = new TaskCompletionSource();
        var thread = new Thread(() =>
        {
            Application.ThreadException += (_, args) => tcs.TrySetException(args.Exception);
            try
            {
                Netch.Utils.i18N.Load("zh-CN");
                using var form = new Netch.Forms.SettingForm();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new System.Drawing.Point(-2000, -2000);
                form.Show();
                Application.DoEvents();

                var tabControl = form.Controls.OfType<TabControl>().FirstOrDefault();
                if (tabControl != null)
                {
                    for (int i = 0; i < tabControl.TabPages.Count; i++)
                    {
                        tabControl.SelectedIndex = i;
                        Application.DoEvents();
                        using var bmp = new System.Drawing.Bitmap(form.Width, form.Height);
                        form.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, form.Width, form.Height));
                        bmp.Save($@"C:\Users\mightnire\.gemini\antigravity\brain\e2001d2d-4e92-4c6b-843b-1ee7e90a765d\setting_form_tab{i}.png");
                    }
                }

                form.Close();
                tcs.SetResult();
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        if (!tcs.Task.Wait(8000))
        {
            Assert.Fail("Timed out waiting for MainForm render");
        }
        if (tcs.Task.IsFaulted)
        {
            throw tcs.Task.Exception?.InnerException ?? tcs.Task.Exception!;
        }
    }

    [TestMethod]
    public void MainForm_Layout_VerifyRender()
    {
        var log = new List<string>();
        var tcs = new TaskCompletionSource();
        var thread = new Thread(() =>
        {
            Application.ThreadException += (_, args) => tcs.TrySetException(args.Exception);
            try
            {
                log.Add("1 Init settings");
                Netch.Utils.i18N.Load("zh-CN");
                Netch.Global.Settings.CheckUpdateWhenOpened = false;
                Netch.Global.Settings.StartWhenOpened = false;

                log.Add("2 new MainForm");
                using var form = new Netch.Forms.MainForm();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new System.Drawing.Point(-2000, -2000);

                log.Add("3 Show");
                form.Show();
                Application.DoEvents();

                log.Add("4 LoadProfiles 0");
                Netch.Global.Settings.ProfileCount = 0;
                form.LoadProfiles();
                Application.DoEvents();

                log.Add("5 bmp1");
                using (var bmp1 = new System.Drawing.Bitmap(form.Width, form.Height))
                {
                    form.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, form.Width, form.Height));
                    bmp1.Save(@"C:\Users\mightnire\.gemini\antigravity\brain\e2001d2d-4e92-4c6b-843b-1ee7e90a765d\main_form_no_profile.png");
                }

                log.Add("6 LoadProfiles 4");
                Netch.Global.Settings.ProfileCount = 4;
                Netch.Global.Settings.Profiles.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Netch.Global.Settings.Profiles.Add(new Netch.Models.Profile { Index = i, ProfileName = $"配置 {i + 1}" });
                }
                form.LoadProfiles();
                Application.DoEvents();

                log.Add("7 bmp2");
                using (var bmp2 = new System.Drawing.Bitmap(form.Width, form.Height))
                {
                    form.DrawToBitmap(bmp2, new System.Drawing.Rectangle(0, 0, form.Width, form.Height));
                    bmp2.Save(@"C:\Users\mightnire\.gemini\antigravity\brain\e2001d2d-4e92-4c6b-843b-1ee7e90a765d\main_form_with_profiles.png");
                }

                log.Add("8 Done");
                tcs.SetResult();
            }
            catch (Exception ex)
            {
                log.Add("EX: " + ex.ToString());
                tcs.SetException(ex);
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        if (!tcs.Task.Wait(8000))
        {
            Assert.Fail("Timed out. Progress: " + string.Join(" -> ", log));
        }
        if (tcs.Task.IsFaulted)
        {
            throw tcs.Task.Exception?.InnerException ?? tcs.Task.Exception!;
        }
    }

    [TestMethod]
    public void RemainingForms_Layout_VerifyRender()
    {
        var outDir = @"C:\Users\mightnire\.gemini\antigravity\brain\e2001d2d-4e92-4c6b-843b-1ee7e90a765d";
        var tcs = new TaskCompletionSource();
        var thread = new Thread(() =>
        {
            Application.ThreadException += (_, args) => tcs.TrySetException(args.Exception);
            try
            {
                Netch.Utils.i18N.Load("zh-CN");

                static void RenderForm(Form form, string filePath, Action? afterShow = null)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new System.Drawing.Point(-2000, -2000);
                    form.Show();
                    afterShow?.Invoke();
                    Application.DoEvents();
                    using var bmp = new System.Drawing.Bitmap(form.Width, form.Height);
                    form.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, form.Width, form.Height));
                    bmp.Save(filePath);
                    form.Close();
                }

                using (var f = new Netch.Forms.AboutForm())
                    RenderForm(f, Path.Combine(outDir, "about_form.png"));

                using (var f = new Netch.Forms.GlobalBypassIPForm())
                    RenderForm(f, Path.Combine(outDir, "bypass_ip_form.png"));

                using (var dummyParent = new Form { Location = new System.Drawing.Point(-2000, -2000), Size = new System.Drawing.Size(200, 200) })
                using (var f = new Netch.Forms.LogForm(dummyParent))
                {
                    f.richTextBox1.Text = "[INFO] SwiftRelay Pcap2Socks started...";
                    RenderForm(f, Path.Combine(outDir, "log_form.png"));
                }

                using (var f = new Netch.Servers.Socks5Form(new Netch.Servers.Socks5Server { Hostname = "1.2.3.4", Port = 1080 }))
                    RenderForm(f, Path.Combine(outDir, "socks5_form_public.png"));

                using (var f = new Netch.Servers.Socks5Form(new Netch.Servers.Socks5Server { Hostname = "192.168.1.1", Port = 1080 }))
                    RenderForm(f, Path.Combine(outDir, "socks5_form_private.png"));

                var readOnlyMode = new Netch.Models.Modes.ProcessMode.Redirector
                {
                    FullName = Path.Combine(Netch.Services.ModeService.Instance.ModeDirectoryFullName, "Other", "TestBuiltIn.txt"),
                    Remark = new() { { "zh-CN", "测试内置模式" }, { "en", "Test Built-in Mode" } },
                    Handle = new() { "^example\\.exe$" }
                };
                using (var f = new Netch.Forms.ModeForms.ProcessForm(readOnlyMode))
                    RenderForm(f, Path.Combine(outDir, "process_form.png"));

                using (var f = new Netch.Forms.ModeForms.RouteForm())
                    RenderForm(f, Path.Combine(outDir, "route_form.png"));

                var extraModes = new List<Netch.Models.Modes.ProcessMode.Redirector> { readOnlyMode };
                for (var i = 1; i <= 35; i++)
                {
                    extraModes.Add(new Netch.Models.Modes.ProcessMode.Redirector
                    {
                        FullName = Path.Combine(Netch.Services.ModeService.Instance.ModeDirectoryFullName, "Game", $"SampleGame{i:00}.txt"),
                        Remark = new() { { "zh-CN", $"Sample Game {i:00}" }, { "en", $"Sample Game {i:00}" } },
                        Handle = new() { $"game{i:00}\\.exe$" }
                    });
                }

                Netch.Global.Modes.AddRange(extraModes);
                try
                {
                    using var f = new Netch.Forms.ModeForms.MultiModeForm(new[] { readOnlyMode });
                    RenderForm(f, Path.Combine(outDir, "multi_mode_form_fixed.png"));
                }
                finally
                {
                    foreach (var m in extraModes)
                        Netch.Global.Modes.Remove(m);
                }

                using (var f = new Netch.Forms.ModeForms.InputDialog("保存为模式组", "请输入此模式组的名称：", "Steam + Discord"))
                    RenderForm(f, Path.Combine(outDir, "input_dialog.png"));

                tcs.SetResult();
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        if (!tcs.Task.Wait(30000))
        {
            Assert.Fail("Timed out waiting for remaining forms render");
        }
        if (tcs.Task.IsFaulted)
        {
            throw tcs.Task.Exception?.InnerException ?? tcs.Task.Exception!;
        }
    }

    [TestMethod]
    public void TestScanDirectory_Deduplication()
    {
        var tempDir = Path.Combine(Path.GetTempPath(), "NetchScanTest_" + Guid.NewGuid().ToString("N"));
        try
        {
            Directory.CreateDirectory(tempDir);
            var sub1 = Path.Combine(tempDir, "sub1");
            var sub2 = Path.Combine(tempDir, "sub2", "sub3");
            Directory.CreateDirectory(sub1);
            Directory.CreateDirectory(sub2);

            File.WriteAllText(Path.Combine(tempDir, "game.exe"), "dummy");
            File.WriteAllText(Path.Combine(tempDir, "launcher.exe"), "dummy");
            File.WriteAllText(Path.Combine(sub1, "game.exe"), "dummy"); // duplicate
            File.WriteAllText(Path.Combine(sub1, "helper.exe"), "dummy");
            File.WriteAllText(Path.Combine(sub2, "LAUNCHER.EXE"), "dummy"); // duplicate case-insensitive
            File.WriteAllText(Path.Combine(sub2, "other.exe"), "dummy");
            File.WriteAllText(Path.Combine(tempDir, "notes.txt"), "dummy"); // not an exe

            var results = Netch.Forms.ModeForms.ProcessForm.ScanDirectory(tempDir, 50);

            // 6 exe files total on disk, but only 4 unique executable names
            Assert.AreEqual(4, results.Count, $"Expected 4 unique executables, got {results.Count}");
            Assert.IsTrue(results.Any(r => r.Equals(@"game\.exe", StringComparison.OrdinalIgnoreCase)));
            Assert.IsTrue(results.Any(r => r.Equals(@"launcher\.exe", StringComparison.OrdinalIgnoreCase)));
            Assert.IsTrue(results.Any(r => r.Equals(@"helper\.exe", StringComparison.OrdinalIgnoreCase)));
            Assert.IsTrue(results.Any(r => r.Equals(@"other\.exe", StringComparison.OrdinalIgnoreCase)));

            // Test maxCount exceeded
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                Netch.Forms.ModeForms.ProcessForm.ScanDirectory(tempDir, 3);
            });
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true);
            }
        }
    }

    [TestMethod]
    public void Mode_i18NRemark_FallsBackWhenCurrentLanguageMissing()
    {
        var originalLang = Netch.Utils.i18N.LangCode;
        try
        {
            Netch.Utils.i18N.Load("en-US");
            var mode = new Netch.Models.Modes.ProcessMode.Redirector
            {
                FullName = @"C:\Modes\Other\NVIDIA Corporation.json",
                Remark = new Dictionary<string, string>
                {
                    ["zh-CN"] = "NVIDIA Corporation"
                }
            };
            Assert.AreEqual("NVIDIA Corporation", mode.i18NRemark);

            var emptyRemarkMode = new Netch.Models.Modes.ProcessMode.Redirector
            {
                FullName = @"C:\Modes\Other\FallbackName.json",
                Remark = new Dictionary<string, string>()
            };
            Assert.AreEqual("FallbackName", emptyRemarkMode.i18NRemark);
        }
        finally
        {
            Netch.Utils.i18N.Load(originalLang);
        }
    }

    [TestMethod]
    public void ProcessForm_SaveAsSnapshot_DoesNotMutateOriginalReadOnlyMode()
    {
        var originalMode = new Netch.Models.Modes.ProcessMode.Redirector
        {
            FullName = @"C:\Modes\Game\ForzaHorizon 4.txt",
            Remark = new Dictionary<string, string> { ["zh-CN"] = "ForzaHorizon 4", ["en-US"] = "ForzaHorizon 4" },
            Handle = new List<string> { "ForzaHorizon4.exe", "XboxApp.exe" },
            Bypass = new List<string>()
        };

        using var form = new Netch.Forms.ModeForms.ProcessForm(originalMode);
        var cloned = form.CreateModeFromControls("ForzaHorizon 4 (Custom)", @"C:\Modes\Custom\ForzaHorizon 4 (Custom).json");

        Assert.AreNotSame(originalMode, cloned);
        Assert.AreEqual("ForzaHorizon 4", originalMode.i18NRemark);
        Assert.AreEqual(@"C:\Modes\Game\ForzaHorizon 4.txt", originalMode.FullName);
        Assert.AreEqual("ForzaHorizon 4 (Custom)", cloned.i18NRemark);
        Assert.AreEqual(@"C:\Modes\Custom\ForzaHorizon 4 (Custom).json", cloned.FullName);
        CollectionAssert.AreEqual(originalMode.Handle, cloned.Handle);
    }

    [TestMethod]
    public void UpdateChecker_ParsesChecksums_AndMatchesAssetByFilename()
    {
        var previous = Netch.Controllers.UpdateChecker.LatestRelease;
        try
        {
            var expectedHash = new string('a', 64);
            var fddHash = new string('b', 64);
            Netch.Controllers.UpdateChecker.LatestRelease = new Netch.Models.GitHubRelease.Release
            {
                tag_name = "1.0.1",
                html_url = "https://example.com/1.0.1",
                body = $"Summary line\n\n### 校验和\n| 文件名 | SHA256 |\n| :- | :- |\n| SwiftRelay.7z | {expectedHash} |\n| SwiftRelay_Framework-Dependent.7z | {fddHash} |",
                assets = new[]
                {
                    new Netch.Models.GitHubRelease.Asset { name = "SwiftRelay_Framework-Dependent.7z", browser_download_url = "https://example.com/fdd.7z" },
                    new Netch.Models.GitHubRelease.Asset { name = "SwiftRelay.7z", browser_download_url = "https://example.com/full.7z" }
                }
            };

            var (fileName, hash) = Netch.Controllers.UpdateChecker.GetLatestUpdateFileNameAndHash();
            Assert.AreEqual("SwiftRelay.7z", fileName);
            Assert.AreEqual(expectedHash, hash);
            Assert.AreEqual("https://example.com/full.7z", Netch.Controllers.UpdateChecker.GetAssetDownloadUrl(fileName));
            Assert.AreEqual("Summary line", Netch.Controllers.UpdateChecker.GetLatestReleaseContent());

            var (fullFile, fullHash) = Netch.Controllers.UpdateChecker.GetLatestUpdateFileNameAndHashForCurrentEdition(isFrameworkDependent: false);
            Assert.AreEqual("SwiftRelay.7z", fullFile);
            Assert.AreEqual(expectedHash, fullHash);
            Assert.AreEqual("https://example.com/full.7z", Netch.Controllers.UpdateChecker.GetAssetDownloadUrl(fullFile));

            var (fddFile, fddParsedHash) = Netch.Controllers.UpdateChecker.GetLatestUpdateFileNameAndHashForCurrentEdition(isFrameworkDependent: true);
            Assert.AreEqual("SwiftRelay_Framework-Dependent.7z", fddFile);
            Assert.AreEqual(fddHash, fddParsedHash);
            Assert.AreEqual("https://example.com/fdd.7z", Netch.Controllers.UpdateChecker.GetAssetDownloadUrl(fddFile));

            Assert.IsTrue(Netch.Controllers.UpdateChecker.IsFrameworkDependentRuntime(@"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.36\"));
            Assert.IsFalse(Netch.Controllers.UpdateChecker.IsFrameworkDependentRuntime(@"C:\Users\demo\AppData\Local\Temp\.net\SwiftRelay\xyz\"));
        }
        finally
        {
            Netch.Controllers.UpdateChecker.LatestRelease = previous!;
        }
    }
}
