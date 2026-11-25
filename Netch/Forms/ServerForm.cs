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
    private const int StandardInputWidth = 320;
    private const int PortWidth = 68;
    private const int ButtonWidth = 84;
    private const int ButtonHeight = 28;

    private readonly Dictionary<Control, Func<string, bool>> _checkActions = new();
    private readonly Dictionary<Control, Action<object>> _saveActions = new();
    private readonly List<(Control Label, Control Input, Func<bool> IsVisible)> _dynamicRows = new();

    private readonly IContainer components = null;
    private bool _factored;

    private TableLayoutPanel _rootLayout;
    private TableLayoutPanel _fieldsLayout;
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

    protected override void OnLoad(EventArgs e)
    {
        AfterFactor();
        base.OnLoad(e);
    }

    private void AfterFactor()
    {
        if (_factored)
            return;
        _factored = true;

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
        _fieldsLayout.SuspendLayout();

        foreach (var (label, input, isVisible) in _dynamicRows)
        {
            var visible = isVisible == null || isVisible();
            if (label != null)
                label.Visible = visible;
            input.Visible = visible;
        }

        _fieldsLayout.ResumeLayout(true);
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
            Anchor = width == StandardInputWidth ? (AnchorStyles.Left | AnchorStyles.Right) : AnchorStyles.Left,
            Margin = new Padding(0, 4, 4, 4),
            TextAlign = HorizontalAlignment.Left,
            Text = value
        };
        if (width != StandardInputWidth)
            textBox.Width = width;

        _checkActions.Add(textBox, check);
        _saveActions.Add(textBox, o => save.Invoke((string)o));

        var label = new Label
        {
            AutoSize = true,
            Anchor = AnchorStyles.Left,
            Margin = new Padding(4, 6, 12, 6),
            Name = $"{name}Label",
            Text = remark
        };

        var row = _fieldsLayout.RowCount++;
        _fieldsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _fieldsLayout.Controls.Add(label, 0, row);
        _fieldsLayout.Controls.Add(textBox, 1, row);

        _dynamicRows.Add((label, textBox, isVisible));
        return (label, textBox);
    }

    protected void CreateComboBox(string name, string remark, List<string> values, Action<string> save, string value, int width = StandardInputWidth, Func<bool> isVisible = null)
    {
        var comboBox = new ComboBox
        {
            Name = $"{name}ComboBox",
            Anchor = width == StandardInputWidth ? (AnchorStyles.Left | AnchorStyles.Right) : AnchorStyles.Left,
            Margin = new Padding(0, 4, 4, 4),
            DropDownStyle = ComboBoxStyle.DropDownList,
            FlatStyle = FlatStyle.System,
            FormattingEnabled = true
        };
        if (width != StandardInputWidth)
            comboBox.Width = width;

        comboBox.Items.AddRange(values.ToArray());
        comboBox.SelectedIndex = values.IndexOf(value);
        _saveActions.Add(comboBox, o => save.Invoke((string)o));

        var label = new Label
        {
            AutoSize = true,
            Anchor = AnchorStyles.Left,
            Margin = new Padding(4, 6, 12, 6),
            Name = $"{name}Label",
            Text = remark
        };

        var row = _fieldsLayout.RowCount++;
        _fieldsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _fieldsLayout.Controls.Add(label, 0, row);
        _fieldsLayout.Controls.Add(comboBox, 1, row);

        _dynamicRows.Add((label, comboBox, isVisible));
    }

    protected void CreateCheckBox(string name, string remark, Action<bool> save, bool value, Func<bool> isVisible = null)
    {
        var checkBox = new CheckBox
        {
            AutoSize = true,
            Anchor = AnchorStyles.Left,
            Margin = new Padding(4, 6, 4, 6),
            Name = $"{name}CheckBox",
            Checked = value,
            Text = remark
        };

        _saveActions.Add(checkBox, o => save.Invoke((bool)o));

        var row = _fieldsLayout.RowCount++;
        _fieldsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _fieldsLayout.Controls.Add(checkBox, 0, row);
        _fieldsLayout.SetColumnSpan(checkBox, 2);

        _dynamicRows.Add((null, checkBox, isVisible));
    }

    private void ControlButton_Click(object sender, EventArgs e)
    {
        // Auto-split host:port if user pasted something like 1.2.3.4:1080 into Address
        var addrText = AddressTextBox.Text.Trim();
        if (!addrText.StartsWith("[") && addrText.Contains(':') && addrText.IndexOf(':') == addrText.LastIndexOf(':'))
        {
            var parts = addrText.Split(':');
            if (ushort.TryParse(parts[1], out var parsedPort) && parsedPort > 0)
            {
                AddressTextBox.Text = parts[0].Trim();
                PortTextBox.Text = parts[1].Trim();
            }
        }

        if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
        {
            MessageBoxX.Show(i18N.Translate("Please enter a server address"));
            AddressTextBox.Focus();
            return;
        }

        if (!ushort.TryParse(PortTextBox.Text, out var port) || port == 0)
        {
            MessageBoxX.Show(i18N.Translate("Please enter a valid port (1-65535)"));
            PortTextBox.Focus();
            return;
        }

        Utils.Utils.ComponentIterator(this, component => Utils.Utils.ChangeControlForeColor(component, Color.Black));

        var flag = true;
        foreach (var pair in _checkActions.Where(pair => !pair.Value.Invoke(pair.Key.Text)))
        {
            Utils.Utils.ChangeControlForeColor(pair.Key, Color.Red);
            pair.Key.Focus();
            flag = false;
            break;
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
        _rootLayout = new TableLayoutPanel();
        _fieldsLayout = new TableLayoutPanel();
        var addressPortLayout = new TableLayoutPanel();
        var buttonLayout = new TableLayoutPanel();

        ConfigurationGroupBox = new GroupBox();
        AddressLabel = new Label();
        PortTextBox = new TextBox();
        AddressTextBox = new TextBox();
        RemarkTextBox = new TextBox();
        RemarkLabel = new Label();
        PortLabel = new Label();
        ControlButton = new Button();
        CancelButtonControl = new Button();

        _rootLayout.SuspendLayout();
        _fieldsLayout.SuspendLayout();
        addressPortLayout.SuspendLayout();
        buttonLayout.SuspendLayout();
        ConfigurationGroupBox.SuspendLayout();
        SuspendLayout();

        // 
        // _rootLayout
        // 
        _rootLayout.AutoSize = true;
        _rootLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _rootLayout.ColumnCount = 1;
        _rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _rootLayout.Controls.Add(ConfigurationGroupBox, 0, 0);
        _rootLayout.Controls.Add(buttonLayout, 0, 1);
        _rootLayout.Dock = DockStyle.Fill;
        _rootLayout.Name = "_rootLayout";
        _rootLayout.Padding = new Padding(12);
        _rootLayout.RowCount = 2;
        _rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        // 
        // ConfigurationGroupBox
        // 
        ConfigurationGroupBox.AutoSize = true;
        ConfigurationGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ConfigurationGroupBox.Controls.Add(_fieldsLayout);
        ConfigurationGroupBox.Dock = DockStyle.Fill;
        ConfigurationGroupBox.Margin = Padding.Empty;
        ConfigurationGroupBox.MinimumSize = new Size(442, 0);
        ConfigurationGroupBox.Name = "ConfigurationGroupBox";
        ConfigurationGroupBox.Padding = new Padding(10, 8, 10, 10);
        ConfigurationGroupBox.TabIndex = 0;
        ConfigurationGroupBox.TabStop = false;
        ConfigurationGroupBox.Text = "Configuration";

        // 
        // _fieldsLayout
        // 
        _fieldsLayout.AutoSize = true;
        _fieldsLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _fieldsLayout.ColumnCount = 2;
        _fieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _fieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _fieldsLayout.Controls.Add(RemarkLabel, 0, 0);
        _fieldsLayout.Controls.Add(RemarkTextBox, 1, 0);
        _fieldsLayout.Controls.Add(AddressLabel, 0, 1);
        _fieldsLayout.Controls.Add(addressPortLayout, 1, 1);
        _fieldsLayout.Dock = DockStyle.Fill;
        _fieldsLayout.Margin = Padding.Empty;
        _fieldsLayout.Name = "_fieldsLayout";
        _fieldsLayout.RowCount = 2;
        _fieldsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _fieldsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        // 
        // RemarkLabel
        // 
        RemarkLabel.Anchor = AnchorStyles.Left;
        RemarkLabel.AutoSize = true;
        RemarkLabel.Margin = new Padding(4, 6, 12, 6);
        RemarkLabel.Name = "RemarkLabel";
        RemarkLabel.TabIndex = 0;
        RemarkLabel.Text = "Remark";

        // 
        // RemarkTextBox
        // 
        RemarkTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        RemarkTextBox.Margin = new Padding(0, 4, 4, 4);
        RemarkTextBox.Name = "RemarkTextBox";
        RemarkTextBox.TabIndex = 1;
        RemarkTextBox.TextAlign = HorizontalAlignment.Left;

        // 
        // AddressLabel
        // 
        AddressLabel.Anchor = AnchorStyles.Left;
        AddressLabel.AutoSize = true;
        AddressLabel.Margin = new Padding(4, 6, 12, 6);
        AddressLabel.Name = "AddressLabel";
        AddressLabel.TabIndex = 2;
        AddressLabel.Text = "Address";

        // 
        // addressPortLayout
        // 
        addressPortLayout.AutoSize = true;
        addressPortLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        addressPortLayout.ColumnCount = 3;
        addressPortLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        addressPortLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        addressPortLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        addressPortLayout.Controls.Add(AddressTextBox, 0, 0);
        addressPortLayout.Controls.Add(PortLabel, 1, 0);
        addressPortLayout.Controls.Add(PortTextBox, 2, 0);
        addressPortLayout.Dock = DockStyle.Fill;
        addressPortLayout.Margin = new Padding(0, 4, 4, 4);
        addressPortLayout.Name = "addressPortLayout";
        addressPortLayout.RowCount = 1;
        addressPortLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        // 
        // AddressTextBox
        // 
        AddressTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        AddressTextBox.Margin = Padding.Empty;
        AddressTextBox.Name = "AddressTextBox";
        AddressTextBox.TabIndex = 3;
        AddressTextBox.TextAlign = HorizontalAlignment.Left;

        // 
        // PortLabel
        // 
        PortLabel.Anchor = AnchorStyles.None;
        PortLabel.AutoSize = true;
        PortLabel.Margin = new Padding(4, 0, 4, 0);
        PortLabel.Name = "PortLabel";
        PortLabel.TabIndex = 4;
        PortLabel.Text = ":";
        PortLabel.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // PortTextBox
        // 
        PortTextBox.Anchor = AnchorStyles.Left;
        PortTextBox.Margin = Padding.Empty;
        PortTextBox.Name = "PortTextBox";
        PortTextBox.Size = new Size(PortWidth, 23);
        PortTextBox.TabIndex = 5;
        PortTextBox.TextAlign = HorizontalAlignment.Center;

        // 
        // buttonLayout
        // 
        buttonLayout.AutoSize = true;
        buttonLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        buttonLayout.ColumnCount = 3;
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        buttonLayout.Controls.Add(ControlButton, 1, 0);
        buttonLayout.Controls.Add(CancelButtonControl, 2, 0);
        buttonLayout.Dock = DockStyle.Fill;
        buttonLayout.Margin = new Padding(0, 10, 0, 0);
        buttonLayout.Name = "buttonLayout";
        buttonLayout.RowCount = 1;
        buttonLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        // 
        // ControlButton (Save)
        // 
        ControlButton.AutoSize = true;
        ControlButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ControlButton.Margin = new Padding(0, 0, 8, 0);
        ControlButton.MinimumSize = new Size(ButtonWidth, ButtonHeight);
        ControlButton.Name = "ControlButton";
        ControlButton.Padding = new Padding(8, 0, 8, 0);
        ControlButton.TabIndex = 1;
        ControlButton.Text = "Save";
        ControlButton.UseVisualStyleBackColor = true;
        ControlButton.Click += ControlButton_Click;

        // 
        // CancelButtonControl (Cancel)
        // 
        CancelButtonControl.AutoSize = true;
        CancelButtonControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        CancelButtonControl.Margin = Padding.Empty;
        CancelButtonControl.MinimumSize = new Size(ButtonWidth, ButtonHeight);
        CancelButtonControl.Name = "CancelButtonControl";
        CancelButtonControl.Padding = new Padding(8, 0, 8, 0);
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
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        CancelButton = CancelButtonControl;
        Controls.Add(_rootLayout);
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = Icon.FromHandle(Resources.SwiftRelay.GetHicon());
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        Name = "ServerForm";
        StartPosition = FormStartPosition.CenterParent;

        _rootLayout.ResumeLayout(false);
        _rootLayout.PerformLayout();
        _fieldsLayout.ResumeLayout(false);
        _fieldsLayout.PerformLayout();
        addressPortLayout.ResumeLayout(false);
        addressPortLayout.PerformLayout();
        buttonLayout.ResumeLayout(false);
        buttonLayout.PerformLayout();
        ConfigurationGroupBox.ResumeLayout(false);
        ConfigurationGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
