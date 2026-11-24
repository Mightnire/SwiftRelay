using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netch.Models.Modes;
using Netch.Models.Modes.ProcessMode;
using Netch.Services;
using Netch.Utils;

namespace Tests;

[TestClass]
public class CompositeModeTests
{
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
    public void CompositeMode_TypeText_ReturnsGroupBadge()
    {
        var comp = new CompositeMode();
        Assert.IsTrue(comp.TypeText.Contains("组") || comp.TypeText.Contains("Group"));
    }
}
