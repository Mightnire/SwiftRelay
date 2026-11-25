using System.Text.Json.Serialization;
using Netch.Utils;

namespace Netch.Models.Modes;

public abstract class Mode
{
    [JsonPropertyOrder(int.MinValue)]
    public abstract ModeType Type { get; }

    public Dictionary<string, string> Remark { get; set; } = new();

    [JsonIgnore]
    // File FullName
    // TODO maybe make it becomes mode dictionary key
    public string FullName { get; set; } = string.Empty;

    [JsonIgnore]
    public virtual string TypeText => Type switch
    {
        ModeType.ProcessMode => i18N.Translate("Process"),
        ModeType.ShareMode => i18N.Translate("Share"),
        ModeType.TunMode => "TUN",
        _ => Type.ToString()
    };

    public override string ToString() => $"[{(int)Type + 1}·{TypeText}] {i18NRemark}";

    [JsonIgnore]
    public string i18NRemark
    {
        get
        {
            if (Remark.TryGetValue(i18N.LangCode, out var val) && !string.IsNullOrWhiteSpace(val))
                return val;
            if (Remark.TryGetValue("en-US", out val) && !string.IsNullOrWhiteSpace(val))
                return val;
            if (Remark.TryGetValue("en", out val) && !string.IsNullOrWhiteSpace(val))
                return val;

            var fallback = Remark.Values.FirstOrDefault(v => !string.IsNullOrWhiteSpace(v));
            return !string.IsNullOrWhiteSpace(fallback) ? fallback : Path.GetFileNameWithoutExtension(FullName);
        }
        set => Remark[i18N.LangCode] = value;
    }
}