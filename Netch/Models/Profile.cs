using Netch.Models.Modes;
using Netch.Models.Modes.ProcessMode;

namespace Netch.Models;

public class Profile
{
    public int Index { get; set; }

    public string ModeRemark { get; set; }

    public string ProfileName { get; set; }

    public string ServerRemark { get; set; }

    public TemporaryModeData? TemporaryMode { get; set; }

    public Profile(Server server, Mode mode, string name, int index)
    {
        ServerRemark = server.Remark;
        ModeRemark = mode.i18NRemark;
        ProfileName = name;
        Index = index;

        if (mode is CompositeMode { IsTemporary: true } comp)
        {
            TemporaryMode = new TemporaryModeData
            {
                Remark = comp.i18NRemark,
                SubModes = comp.SubModes.ToList()
            };
        }
    }

    public Profile()
    {
        ServerRemark = string.Empty;
        ModeRemark = string.Empty;
        ProfileName = string.Empty;
        Index = 0;
    }
}