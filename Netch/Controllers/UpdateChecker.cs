using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Netch.Models.GitHubRelease;
using Netch.Utils;

namespace Netch.Controllers;

public static class UpdateChecker
{
    public const string Owner = @"Mightnire";
    public const string Repo = @"SwiftRelay";

    public const string Name = @"SwiftRelay";
    public const string Copyright = @"Copyright © 2024 - 2026 SwiftRelay Contributors";

    public const string AssemblyVersion = @"1.0.3";
    private const string Suffix = @"";

    public static readonly string Version = $"{AssemblyVersion}{(string.IsNullOrEmpty(Suffix) ? "" : $"-{Suffix}")}";

    public static Release LatestRelease = null!;

    public static string LatestVersionNumber => LatestRelease.tag_name;

    public static string LatestVersionUrl => LatestRelease.html_url;

    public static event EventHandler? NewVersionFound;

    public static event EventHandler? NewVersionFoundFailed;

    public static event EventHandler? NewVersionNotFound;

    public static async Task CheckAsync(bool isPreRelease)
    {
        try
        {
            List<Release>? releases = null;

            // 1. Try GitHub REST API
            try
            {
                var updater = new GitHubRelease(Owner, Repo);
                var url = updater.AllReleaseUrl;
                var req = WebUtil.CreateRequest(url);
                var (statusCode, json) = await WebUtil.DownloadStringAsync(req);
                if (statusCode == HttpStatusCode.OK && !string.IsNullOrWhiteSpace(json))
                {
                    releases = JsonSerializer.Deserialize<List<Release>>(json);
                }
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Get releases from GitHub API failed, attempting web fallback");
            }

            if (releases != null && releases.Count > 0)
            {
                var targetRelease = GetLatestRelease(releases, isPreRelease);
                if (targetRelease != null)
                {
                    LatestRelease = targetRelease;
                    Log.Information("Github latest release: {Version}", LatestRelease.tag_name);
                    if (VersionUtil.CompareVersion(LatestRelease.tag_name, Version) > 0)
                    {
                        Log.Information("Found newer version");
                        NewVersionFound?.Invoke(null, EventArgs.Empty);
                    }
                    else
                    {
                        Log.Information("Already the latest version");
                        NewVersionNotFound?.Invoke(null, EventArgs.Empty);
                    }
                    return;
                }
            }

            // 2. Fallback: Query web releases/latest (302 redirect reveals the latest tag)
            var webUrl = $"https://github.com/{Owner}/{Repo}/releases/latest";
            var webReq = WebUtil.CreateRequest(webUrl);
            webReq.AllowAutoRedirect = false;

            string? redirectLocation = null;
            try
            {
                using var response = (HttpWebResponse)await webReq.GetResponseAsync();
                if ((int)response.StatusCode >= 300 && (int)response.StatusCode < 400)
                {
                    redirectLocation = response.Headers["Location"];
                }
            }
            catch (WebException we) when (we.Response is HttpWebResponse wr && (int)wr.StatusCode >= 300 && (int)wr.StatusCode < 400)
            {
                redirectLocation = wr.Headers["Location"];
            }

            if (!string.IsNullOrWhiteSpace(redirectLocation) && redirectLocation.Contains("/releases/tag/"))
            {
                var tag = redirectLocation.Substring(redirectLocation.LastIndexOf('/') + 1).Trim();
                LatestRelease = new Release
                {
                    tag_name = tag,
                    html_url = redirectLocation,
                    body = "",
                    prerelease = false,
                    assets = Array.Empty<Asset>()
                };

                Log.Information("Fallback detected latest release: {Version}", tag);
                if (VersionUtil.CompareVersion(tag, Version) > 0)
                {
                    Log.Information("Found newer version");
                    NewVersionFound?.Invoke(null, EventArgs.Empty);
                }
                else
                {
                    Log.Information("Already the latest version");
                    NewVersionNotFound?.Invoke(null, EventArgs.Empty);
                }
                return;
            }

            // 3. If there are no releases at all on GitHub
            if (releases != null && releases.Count == 0)
            {
                Log.Information("No releases found on repository, current is latest");
                NewVersionNotFound?.Invoke(null, EventArgs.Empty);
                return;
            }

            // Failed both API and fallback
            NewVersionFoundFailed?.Invoke(null, EventArgs.Empty);
        }
        catch (Exception e)
        {
            if (e is WebException)
                Log.Warning(e, "Get releases failed");
            else
                Log.Error(e, "Get releases error");

            NewVersionFoundFailed?.Invoke(null, EventArgs.Empty);
        }
    }

    public static bool IsFrameworkDependentRuntime(string? runtimeDirectory = null)
    {
        var dir = runtimeDirectory ?? RuntimeEnvironment.GetRuntimeDirectory();
        var sharedSegment = $"{Path.DirectorySeparatorChar}shared{Path.DirectorySeparatorChar}Microsoft.NETCore.App";
        return dir.Contains(sharedSegment, StringComparison.OrdinalIgnoreCase);
    }

    public static (string fileName, string sha256) GetLatestUpdateFileNameAndHashForCurrentEdition(bool? isFrameworkDependent = null)
    {
        var fdd = isFrameworkDependent ?? IsFrameworkDependentRuntime();
        return GetLatestUpdateFileNameAndHash(fn =>
            fdd
                ? fn.Contains("Framework-Dependent", StringComparison.OrdinalIgnoreCase)
                : !fn.Contains("Framework-Dependent", StringComparison.OrdinalIgnoreCase));
    }

    public static (string fileName, string sha256) GetLatestUpdateFileNameAndHash(string? keyword = null)
    {
        return GetLatestUpdateFileNameAndHash(
            keyword == null ? null : fn => fn.Contains(keyword, StringComparison.OrdinalIgnoreCase));
    }

    private static (string fileName, string sha256) GetLatestUpdateFileNameAndHash(Func<string, bool>? predicate)
    {
        if (!string.IsNullOrEmpty(LatestRelease?.body))
        {
            var tableMatches = Regex.Matches(LatestRelease.body, @"^\|\s*`?(?<filename>[^`|\r\n]+?)`?\s*\|\s*`?(?<sha256>[a-fA-F0-9]{64})`?\s*\|", RegexOptions.Multiline);
            foreach (Match m in tableMatches)
            {
                var fn = m.Groups["filename"].Value.Trim();
                var hash = m.Groups["sha256"].Value.Trim().ToLowerInvariant();
                if (predicate == null || predicate(fn))
                    return (fn, hash);
            }

            var bulletMatches = Regex.Matches(LatestRelease.body, @"^[-*]\s*`?(?<filename>[^`:\r\n：]+?)`?\s*[:：]\s*`?(?<sha256>[a-fA-F0-9]{64})`?", RegexOptions.Multiline);
            foreach (Match m in bulletMatches)
            {
                var fn = m.Groups["filename"].Value.Trim();
                var hash = m.Groups["sha256"].Value.Trim().ToLowerInvariant();
                if (predicate == null || predicate(fn))
                    return (fn, hash);
            }
        }

        if (LatestRelease?.assets != null && LatestRelease.assets.Length > 0)
        {
            var asset = predicate == null
                ? LatestRelease.assets[0]
                : LatestRelease.assets.FirstOrDefault(a => predicate(a.name)) ?? LatestRelease.assets[0];

            return (asset.name, "");
        }

        return ("SwiftRelay.7z", "");
    }

    public static string? GetAssetDownloadUrl(string fileName)
    {
        var assets = LatestRelease?.assets;
        if (assets == null || assets.Length == 0)
            return null;

        var matched = assets.FirstOrDefault(a => a.name.Equals(fileName, StringComparison.OrdinalIgnoreCase)) ?? assets[0];
        return matched.browser_download_url;
    }

    public static string GetLatestReleaseContent()
    {
        if (string.IsNullOrWhiteSpace(LatestRelease?.body))
            return i18N.Translate("No release notes available.");

        var sb = new StringBuilder();
        foreach (var l in LatestRelease.body.GetLines(false))
        {
            if (l.Contains("校验和") || l.Contains("Checksums", StringComparison.OrdinalIgnoreCase) || l.Contains("SHA256", StringComparison.OrdinalIgnoreCase))
                break;

            sb.AppendLine(l);
        }

        var content = sb.ToString().Trim();
        return string.IsNullOrEmpty(content) ? LatestRelease.body : content;
    }

    private static Release? GetLatestRelease(IEnumerable<Release> releases, bool isPreRelease)
    {
        if (!isPreRelease)
            releases = releases.Where(release => !release.prerelease);

        var ordered = releases.OrderByDescending(release => release.tag_name, new VersionUtil.VersionComparer());
        return ordered.FirstOrDefault();
    }
}
