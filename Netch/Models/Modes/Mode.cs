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
        // TODO i18N.Culture to support fallback
        get => Remark.GetValueOrDefault(i18N.LangCode) ?? Remark.GetValueOrDefault("en") ?? "";
        set => Remark[i18N.LangCode] = value;
    }
}