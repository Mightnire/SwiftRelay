using Netch.Models.Modes;
using Netch.Models.Modes.TunMode;
using Netch.Properties;
using Netch.Services;
using Netch.Utils;

namespace Netch.Forms.ModeForms;

[Fody.ConfigureAwait(true)]
public partial class RouteForm : BindingForm
{
    private readonly bool IsCreateMode;

    private readonly TunMode _mode;

    public Mode? SavedMode { get; private set; }

    public RouteForm(Mode? mode = null)
    {
        switch (mode)
        {
            case null:
                IsCreateMode = true;
                _mode = new TunMode();
                break;
            case TunMode tunMode:
                IsCreateMode = false;
                _mode = tunMode;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        InitializeComponent();
        Icon = Resources.icon;


        BindTextBox(RemarkTextBox, _ => true, s => _mode.i18NRemark = s, _mode.i18NRemark);
        // TODO Options Not implemented

        BindTextBox(BypassRuleRichTextBox, s => true, s => _mode.Bypass = s.GetLines().ToList(), string.Join(Constants.EOF, _mode.Bypass));
        BindTextBox(HandleRuleRichTextBox, s => true, s => _mode.Handle = s.GetLines().ToList(), string.Join(Constants.EOF, _mode.Handle));
    }

    private void Route_Load(object sender, EventArgs e)
    {
        if (!IsCreateMode)
        {
            Text = "Edit Route Table Rule";

            RemarkTextBox.TextChanged -= RemarkTextBox_TextChanged;
            RemarkTextBox.Text = _mode.i18NRemark;
            FilenameTextBox.Text = ModeService.Instance.GetRelativePath(_mode.FullName);
            SaveAsButton.Visible = true;

            if (!_mode.FullName.EndsWith(".json"))
            {
                ControlButton.Enabled = false;
                ReadOnlyHintLabel.Text = ModeEditorUtils.ReadOnlyModeHintKey;
                ReadOnlyHintLabel.Visible = true;
            }
        }

        i18N.TranslateForm(this);
    }

    private void ControlButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(RemarkTextBox.Text))
        {
            MessageBoxX.Show(i18N.Translate("Please enter a mode remark"));
            return;
        }

        SaveBinds();

        if (!ModeEditorUtils.SaveFormMode(this, _mode, IsCreateMode, FilenameTextBox.Text))
            return;

        SavedMode = _mode;
        DialogResult = DialogResult.OK;
        Close();
    }

    public void SaveAsButton_Click(object? sender, EventArgs e)
    {
        if (!ModeEditorUtils.TryPromptSaveAsPath(this, RemarkTextBox.Text, out var newRemark, out var fullPath))
            return;

        var clonedMode = CreateModeFromControls(newRemark, fullPath);
        ModeEditorUtils.SaveNewMode(clonedMode, this);
        SavedMode = clonedMode;
        DialogResult = DialogResult.OK;
        Close();
    }

    public TunMode CreateModeFromControls(string remark, string fullName)
    {
        var cloned = new TunMode
        {
            FullName = fullName,
            Bypass = BypassRuleRichTextBox.Text.GetLines().ToList(),
            Handle = HandleRuleRichTextBox.Text.GetLines().ToList()
        };
        cloned.i18NRemark = remark;
        return cloned;
    }

    private void RemarkTextBox_TextChanged(object? sender, EventArgs? e)
    {
        if (!IsHandleCreated)
            return;

        BeginInvoke(() =>
        {
            FilenameTextBox.Text = ModeEditorUtils.GetCustomModeRelativePath(RemarkTextBox.Text);
        });
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}