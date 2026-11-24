#nullable disable
using System.ComponentModel;
using Netch.Models;
using Netch.Properties;
using Netch.Utils;

namespace Netch.Forms;

[DesignerCategory(@"Code")]
[Fody.ConfigureAwait(true)]
public abstract class ServerForm : Form
{
    private const int MarginX = 14;
    private const int MarginY = 12;
    private const int GroupBoxWidth = 442;
    private const int LabelStartX = 18;
    private const int InputStartX = 105;
    private const int StandardInputWidth = 320;
    private const int AddressWidth = 235;
    private const int ColonGap = 4;
    private const int ColonWidth = 12;
    private const int PortWidth = 65;
    private const int StartY = 28;
    private const int RowSpacing = 36;
    private const int InputHeight = 23;
    private const int GroupBoxBottomPadding = 18;
    private const int ButtonWidth = 84;
    private const int ButtonHeight = 28;
    private const int ButtonSpacingY = 12;
    private const int ButtonGap = 8;

    private readonly Dictionary<Control, Func<string, bool>> _checkActions = new();
    private readonly Dictionary<Control, Action<object>> _saveActions = new();
    private readonly List<(Label Label, Control Input, Func<bool> IsVisible)> _dynamicRows = new();

    private readonly IContainer components = null;

    private GroupBox ConfigurationGroupBox;
    private Label RemarkLabel;
    protected TextBox RemarkTextBox;
    private Label AddressLabel;
    protected TextBox AddressTextBox;
    private Label PortLabel;
    private TextBox PortTextBox;
    private Button ControlButton;
    private Button CancelButtonControl;

    protected ServerForm()
    {
        InitializeComponent();

        _checkActions.Add(RemarkTextBox, s => true);
        _saveActions.Add(RemarkTextBox, s => Server.Remark = (string)s);

        _checkActions.Add(AddressTextBox, s => !string.IsNullOrWhiteSpace(s));
        _saveActions.Add(AddressTextBox, s => Server.Hostname = (string)s);

        _checkActions.Add(PortTextBox, s => ushort.TryParse(s, out var port) && port != 0);
        _saveActions.Add(PortTextBox, s => Server.Port = ushort.Parse((string)s));
    }

    protected abstract string TypeName { get; }

    protected Server Server { get; set; }

    public new void ShowDialog()
    {
        AfterFactor();
        base.ShowDialog();
    }

    public new void Show()
    {
        AfterFactor();
        base.Show();
    }

    private void AfterFactor()
    {
        Text = TypeName ?? string.Empty;

        RemarkTextBox.Text = Server.Remark;
        AddressTextBox.Text = Server.Hostname;
        PortTextBox.Text = Server.Port == 0 ? string.Empty : Server.Port.ToString();

        RelayoutForm();
        i18N.TranslateForm(this);

        ConfigurationGroupBox.Enabled = !Server.IsInGroup();
        ControlButton.Enabled = !Server.IsInGroup();
    }

    public void RelayoutForm()
    {
        SuspendLayout();
        ConfigurationGroupBox.SuspendLayout();

        int currentY = StartY;

        // Row 0: Remark
        RemarkLabel.Location = new Point(LabelStartX, currentY + 4);
        RemarkTextBox.Location = new Point(InputStartX, currentY);
        RemarkTextBox.Size = new Size(StandardInputWidth, InputHeight);
        currentY += RowSpacing;

        // Row 1: Address & Port
        AddressLabel.Location = new Point(LabelStartX, currentY + 4);
        AddressTextBox.Location = new Point(InputStartX, currentY);
        AddressTextBox.Size = new Size(AddressWidth, InputHeight);

        PortLabel.Location = new Point(InputStartX + AddressWidth + ColonGap, currentY + 2);
        PortLabel.Size = new Size(ColonWidth, 20);

        PortTextBox.Location = new Point(InputStartX + AddressWidth + ColonGap + ColonWidth + ColonGap, currentY);
        PortTextBox.Size = new Size(PortWidth, InputHeight);
        currentY += RowSpacing;

        // Dynamic rows (Username, Password, Version, RemoteHostname, etc.)
        foreach (var (label, input, isVisible) in _dynamicRows)
        {
            if (isVisible != null && !isVisible())
            {
                label.Visible = false;
                input.Visible = false;
                continue;
            }

            label.Visible = true;
            input.Visible = true;
            label.Location = new Point(LabelStartX, currentY + 4);
            input.Location = new Point(InputStartX, currentY);
            input.Size = new Size(StandardInputWidth, InputHeight);
            currentY += RowSpacing;
        }

        int groupBoxHeight = currentY - RowSpacing + InputHeight + GroupBoxBottomPadding;
        ConfigurationGroupBox.Location = new Point(MarginX, MarginY);
        ConfigurationGroupBox.Size = new Size(GroupBoxWidth, groupBoxHeight);

        int buttonY = ConfigurationGroupBox.Bottom + ButtonSpacingY;
        CancelButtonControl.Location = new Point(ConfigurationGroupBox.Right - ButtonWidth, buttonY);
        ControlButton.Location = new Point(CancelButtonControl.Left - ButtonGap - ButtonWidth, buttonY);

        ClientSize = new Size(ConfigurationGroupBox.Right + MarginX, CancelButtonControl.Bottom + MarginY);

        ConfigurationGroupBox.ResumeLayout(true);
        ResumeLayout(true);
    }

    protected (Label, TextBox) CreateTextBox(string name,
        string remark,
        Func<string, bool> check,
        Action<string> save,
        string value,
        int width = StandardInputWidth,
        Func<bool> isVisible = null)
    {
        var textBox = new TextBox
        {
            Name = $"{name}TextBox",
            Size = new Size(width, InputHeight),
            TextAlign = HorizontalAlignment.Left,
            Text = value
        };

        _checkActions.Add(textBox, check);
        _saveActions.Add(textBox, o => save.Invoke((string)o));

        var label = new Label
        {
            AutoSize = true,
            Name = $"{name}Label",
            Text = remark
        };

        ConfigurationGroupBox.Controls.Add(label);
        ConfigurationGroupBox.Controls.Add(textBox);

        _dynamicRows.Add((label, textBox, isVisible));
        return (label, textBox);
    }

    protected void CreateComboBox(string name, string remark, List<string> values, Action<string> save, string value, int width = StandardInputWidth, Func<bool> isVisible = null)
    {
        var comboBox = new ComboBox
        {
            Name = $"{name}ComboBox",
            Size = new Size(width, InputHeight),
            DropDownStyle = ComboBoxStyle.DropDownList,
            FlatStyle = FlatStyle.System,
            FormattingEnabled = true
        };

        comboBox.Items.AddRange(values.ToArray());
        comboBox.SelectedIndex = values.IndexOf(value);
        _saveActions.Add(comboBox, o => save.Invoke((string)o));

        var label = new Label
        {
            AutoSize = true,
            Name = $"{name}Label",
            Text = remark
        };

        ConfigurationGroupBox.Controls.Add(label);
        ConfigurationGroupBox.Controls.Add(comboBox);

        _dynamicRows.Add((label, comboBox, isVisible));
    }

    protected void CreateCheckBox(string name, string remark, Action<bool> save, bool value, Func<bool> isVisible = null)
    {
        var checkBox = new CheckBox
        {
            AutoSize = true,
            Name = $"{name}CheckBox",
            Checked = value,
            Text = remark
        };

        _saveActions.Add(checkBox, o => save.Invoke((bool)o));
        ConfigurationGroupBox.Controls.Add(checkBox);
        _dynamicRows.Add((new Label { Visible = false }, checkBox, isVisible));
    }

    private void ControlButton_Click(object sender, EventArgs e)
    {
        Utils.Utils.ComponentIterator(this, component => Utils.Utils.ChangeControlForeColor(component, Color.Black));

        var flag = true;
        foreach (var pair in _checkActions.Where(pair => !pair.Value.Invoke(pair.Key.Text)))
        {
            Utils.Utils.ChangeControlForeColor(pair.Key, Color.Red);
            flag = false;
        }

        if (!flag)
            return;

        foreach (var pair in _saveActions)
            switch (pair.Key)
            {
                case CheckBox c:
                    pair.Value.Invoke(c.Checked);
                    break;
                default:
                    pair.Value.Invoke(pair.Key.Text);
                    break;
            }

        if (Global.Settings.Server.IndexOf(Server) == -1)
            Global.Settings.Server.Add(Server);

        MessageBoxX.Show(i18N.Translate("Saved"));

        Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ConfigurationGroupBox = new GroupBox();
        AddressLabel = new Label();
        PortTextBox = new TextBox();
        AddressTextBox = new TextBox();
        RemarkTextBox = new TextBox();
        RemarkLabel = new Label();
        PortLabel = new Label();
        ControlButton = new Button();
        CancelButtonControl = new Button();

        ConfigurationGroupBox.SuspendLayout();
        SuspendLayout();

        // 
        // ConfigurationGroupBox
        // 
        ConfigurationGroupBox.Controls.Add(AddressLabel);
        ConfigurationGroupBox.Controls.Add(PortTextBox);
        ConfigurationGroupBox.Controls.Add(AddressTextBox);
        ConfigurationGroupBox.Controls.Add(RemarkTextBox);
        ConfigurationGroupBox.Controls.Add(RemarkLabel);
        ConfigurationGroupBox.Controls.Add(PortLabel);
        ConfigurationGroupBox.Location = new Point(MarginX, MarginY);
        ConfigurationGroupBox.Name = "ConfigurationGroupBox";
        ConfigurationGroupBox.Size = new Size(GroupBoxWidth, 213);
        ConfigurationGroupBox.TabIndex = 0;
        ConfigurationGroupBox.TabStop = false;
        ConfigurationGroupBox.Text = "Configuration";

        // 
        // RemarkLabel
        // 
        RemarkLabel.AutoSize = true;
        RemarkLabel.Location = new Point(LabelStartX, StartY + 4);
        RemarkLabel.Name = "RemarkLabel";
        RemarkLabel.Size = new Size(53, 17);
        RemarkLabel.TabIndex = 0;
        RemarkLabel.Text = "Remark";

        // 
        // RemarkTextBox
        // 
        RemarkTextBox.Location = new Point(InputStartX, StartY);
        RemarkTextBox.Name = "RemarkTextBox";
        RemarkTextBox.Size = new Size(StandardInputWidth, InputHeight);
        RemarkTextBox.TabIndex = 1;
        RemarkTextBox.TextAlign = HorizontalAlignment.Left;

        // 
        // AddressLabel
        // 
        AddressLabel.AutoSize = true;
        AddressLabel.Location = new Point(LabelStartX, StartY + RowSpacing + 4);
        AddressLabel.Name = "AddressLabel";
        AddressLabel.Size = new Size(56, 17);
        AddressLabel.TabIndex = 2;
        AddressLabel.Text = "Address";

        // 
        // AddressTextBox
        // 
        AddressTextBox.Location = new Point(InputStartX, StartY + RowSpacing);
        AddressTextBox.Name = "AddressTextBox";
        AddressTextBox.Size = new Size(AddressWidth, InputHeight);
        AddressTextBox.TabIndex = 3;
        AddressTextBox.TextAlign = HorizontalAlignment.Left;

        // 
        // PortLabel
        // 
        PortLabel.AutoSize = false;
        PortLabel.Location = new Point(InputStartX + AddressWidth + ColonGap, StartY + RowSpacing + 2);
        PortLabel.Name = "PortLabel";
        PortLabel.Size = new Size(ColonWidth, 20);
        PortLabel.TabIndex = 4;
        PortLabel.Text = ":";
        PortLabel.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // PortTextBox
        // 
        PortTextBox.Location = new Point(InputStartX + AddressWidth + ColonGap + ColonWidth + ColonGap, StartY + RowSpacing);
        PortTextBox.Name = "PortTextBox";
        PortTextBox.Size = new Size(PortWidth, InputHeight);
        PortTextBox.TabIndex = 5;
        PortTextBox.TextAlign = HorizontalAlignment.Center;

        // 
        // ControlButton (Save)
        // 
        ControlButton.Name = "ControlButton";
        ControlButton.Size = new Size(ButtonWidth, ButtonHeight);
        ControlButton.TabIndex = 1;
        ControlButton.Text = "Save";
        ControlButton.UseVisualStyleBackColor = true;
        ControlButton.Click += ControlButton_Click;

        // 
        // CancelButtonControl (Cancel)
        // 
        CancelButtonControl.Name = "CancelButtonControl";
        CancelButtonControl.Size = new Size(ButtonWidth, ButtonHeight);
        CancelButtonControl.TabIndex = 2;
        CancelButtonControl.Text = "Cancel";
        CancelButtonControl.UseVisualStyleBackColor = true;
        CancelButtonControl.Click += (s, e) => Close();

        // 
        // ServerForm
        // 
        AcceptButton = ControlButton;
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        CancelButton = CancelButtonControl;
        ClientSize = new Size(470, 279);
        Controls.Add(ConfigurationGroupBox);
        Controls.Add(ControlButton);
        Controls.Add(CancelButtonControl);
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = Icon.FromHandle(Resources.SwiftRelay.GetHicon());
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        Name = "ServerForm";
        StartPosition = FormStartPosition.CenterParent;

        ConfigurationGroupBox.ResumeLayout(false);
        ConfigurationGroupBox.PerformLayout();
        ResumeLayout(false);
    }
}
