namespace Netch.Forms;

public class SyncGlobalCheckBox : CheckBox
{
    public SyncGlobalCheckBox()
    {
        AutoCheck = false;
        UseVisualStyleBackColor = true;
        OnSyncGlobalChanged();
    }

    private bool _syncGlobal;

    private bool _globalValue;

    public bool SyncGlobal
    {
        get => _syncGlobal;
        set
        {
            if (value == _syncGlobal)
                return;

            _syncGlobal = value;

            OnSyncGlobalChanged();
        }
    }

    public bool GlobalValue
    {
        get => _globalValue;
        set
        {
            if (value == _globalValue)
                return;

            _globalValue = value;

            if (SyncGlobal)
                Checked = value;
        }
    }

    protected override void OnClick(EventArgs e)
    {
        if (Checked == GlobalValue)
        {
            SyncGlobal = !SyncGlobal;
            if (SyncGlobal)
                return;
        }

        Checked = !Checked;
        base.OnClick(e);
    }

    public bool? Value
    {
        get => _syncGlobal ? null : Checked;
        set
        {
            if (value == null)
            {
                SyncGlobal = true;
            }
            else
            {
                SyncGlobal = false;
                Checked = (bool)value;
            }
        }
    }

    private void OnSyncGlobalChanged()
    {
        Font = new Font(Font, FontStyle.Regular);
        BackColor = Color.Transparent;
        UseVisualStyleBackColor = true;
    }
}
