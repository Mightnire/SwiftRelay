using System.Text.Json.Serialization;
using Netch.Utils;

namespace Netch.Models.Modes.ProcessMode;

public class CompositeMode : Redirector
{
    public List<string> SubModes { get; set; } = new();

    [JsonIgnore]
    public bool IsTemporary { get; set; }

    [JsonIgnore]
    public override string TypeText => i18N.Translate("Group");

    public override string ToString() => $"[1·{TypeText}] {i18NRemark}";

    public static CompositeMode FromModes(IEnumerable<Redirector> modes, string remark, bool isTemp = false)
    {
        var composite = new CompositeMode
        {
            IsTemporary = isTemp,
            i18NRemark = remark
        };

        var modeList = modes.ToList();
        foreach (var m in modeList)
        {
            if (!string.IsNullOrEmpty(m.FullName))
            {
                var relPath = Services.ModeService.Instance.GetRelativePath(m.FullName);
                if (!composite.SubModes.Contains(relPath))
                    composite.SubModes.Add(relPath);
            }
        }

        composite.MergeFrom(modeList);
        return composite;
    }

    public void MergeFrom(IEnumerable<Redirector> modes)
    {
        var modeList = modes.ToList();

        // Merge Handle rules
        Handle.Clear();
        foreach (var m in modeList)
        {
            foreach (var h in m.Handle)
            {
                if (!Handle.Contains(h))
                    Handle.Add(h);
            }
        }

        // Merge Bypass rules
        Bypass.Clear();
        foreach (var m in modeList)
        {
            foreach (var b in m.Bypass)
            {
                if (!Bypass.Contains(b))
                    Bypass.Add(b);
            }
        }

        // Merge options
        FilterTCP = modeList.Any(m => m.FilterTCP == true) ? true : (modeList.All(m => m.FilterTCP == false) ? false : null);
        FilterUDP = modeList.Any(m => m.FilterUDP == true) ? true : (modeList.All(m => m.FilterUDP == false) ? false : null);
        FilterICMP = modeList.Any(m => m.FilterICMP == true) ? true : (modeList.All(m => m.FilterICMP == false) ? false : null);
        FilterDNS = modeList.Any(m => m.FilterDNS == true) ? true : (modeList.All(m => m.FilterDNS == false) ? false : null);
        FilterParent = modeList.Any(m => m.FilterParent == true) ? true : (modeList.All(m => m.FilterParent == false) ? false : null);
        DNSProxy = modeList.Any(m => m.DNSProxy == true) ? true : (modeList.All(m => m.DNSProxy == false) ? false : null);
        HandleOnlyDNS = modeList.Any(m => m.HandleOnlyDNS == true) ? true : (modeList.All(m => m.HandleOnlyDNS == false) ? false : null);
        FilterLoopback = modeList.Any(m => m.FilterLoopback);
        FilterIntranet = modeList.All(m => m.FilterIntranet);

        ICMPDelay = modeList.FirstOrDefault(m => m.ICMPDelay.HasValue)?.ICMPDelay;
        DNSHost = modeList.FirstOrDefault(m => !string.IsNullOrEmpty(m.DNSHost))?.DNSHost;
    }

    public void ResolveAndMerge()
    {
        var resolvedModes = new List<Redirector>();
        foreach (var sub in SubModes)
        {
            try
            {
                var fullPath = Path.IsPathRooted(sub) ? sub : Services.ModeService.Instance.GetFullPath(sub);
                if (File.Exists(fullPath))
                {
                    var loaded = ModeHelper.LoadMode(fullPath);
                    if (loaded is Redirector red)
                        resolvedModes.Add(red);
                }
                else
                {
                    // Fallback search by filename in loaded modes
                    var fileName = Path.GetFileName(sub);
                    var match = Global.Modes.OfType<Redirector>().FirstOrDefault(m => Path.GetFileName(m.FullName).Equals(fileName, StringComparison.OrdinalIgnoreCase));
                    if (match != null)
                        resolvedModes.Add(match);
                }
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to resolve submode: {Path}", sub);
            }
        }

        if (resolvedModes.Count > 0)
        {
            MergeFrom(resolvedModes);
        }
    }
}
