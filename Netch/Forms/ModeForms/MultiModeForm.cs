using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Netch.Models.Modes.ProcessMode;
using Netch.Services;
using Netch.Utils;

namespace Netch.Forms.ModeForms;

public class MultiModeForm : Form
{
    private readonly List<Redirector> _allProcessModes = new();
    private readonly HashSet<Redirector> _checkedModes = new();
    private bool _updatingCheckState;
    private int _sortColumn;
    private bool _sortAscending = true;

    // Controls
    private SplitContainer _splitContainer = null!;
    private TextBox _searchTextBox = null!;
    private ListView _modeListView = null!;
    private Button _btnSelectAll = null!;
    private Button _btnInvert = null!;
    private Button _btnClear = null!;
    private Label _lblCount = null!;
    private Label _lblRulesSummary = null!;
    private Button _btnSaveAsGroup = null!;
    private Button _btnApply = null!;
    private Button _btnCancel = null!;

    // Preview Controls
    private Label _lblPreviewTitle = null!;
    private Label _lblPreviewPath = null!;
    private FlowLayoutPanel _protocolFlowPanel = null!;
    private TabControl _tabControlRules = null!;
    private TabPage _tabHandle = null!;
    private TabPage _tabBypass = null!;
    private TextBox _txtHandle = null!;
    private TextBox _txtBypass = null!;
    private Label _lblEmptyPreviewTip = null!;

    public Redirector? ResultMode { get; private set; }

    public MultiModeForm(IEnumerable<Redirector>? preselected = null)
    {
        InitializeComponents();
        LoadModes(preselected);
    }

    private void InitializeComponents()
    {
        Text = i18N.Translate("Multi-Mode Selector");
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Size = new Size(820, 560);
        MinimumSize = new Size(720, 480);
        StartPosition = FormStartPosition.CenterParent;
        Icon = Properties.Resources.icon;

        // Main layout: Bottom panel and SplitContainer
        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 48,
            Padding = new Padding(12, 8, 12, 8)
        };

        _splitContainer = new SplitContainer
        {
            Dock = DockStyle.Fill,
            SplitterWidth = 6
        };

        // ----------------- Left Panel (Mode List) -----------------
        var leftPanel = _splitContainer.Panel1;
        leftPanel.Padding = new Padding(12, 12, 4, 0);

        var searchPanel = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink
        };

        _searchTextBox = new TextBox
        {
            Dock = DockStyle.Top,
            Font = new Font("Microsoft YaHei UI", 9.5F),
            PlaceholderText = i18N.Translate("Search mode name or process...")
        };
        _searchTextBox.TextChanged += SearchTextBox_TextChanged;
        searchPanel.Controls.Add(_searchTextBox);

        var quickActionPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 36,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Padding = new Padding(0, 6, 0, 6)
        };

        _btnSelectAll = new Button
        {
            Text = i18N.Translate("Select All"),
            Width = 65,
            Height = 24,
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 4, 0)
        };
        _btnSelectAll.Click += BtnSelectAll_Click;

        _btnInvert = new Button
        {
            Text = i18N.Translate("Invert"),
            Width = 65,
            Height = 24,
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 4, 0)
        };
        _btnInvert.Click += BtnInvert_Click;

        _btnClear = new Button
        {
            Text = i18N.Translate("Clear"),
            Width = 65,
            Height = 24,
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 0, 0)
        };
        _btnClear.Click += BtnClear_Click;

        quickActionPanel.Controls.Add(_btnSelectAll);
        quickActionPanel.Controls.Add(_btnInvert);
        quickActionPanel.Controls.Add(_btnClear);

        _modeListView = new ListView
        {
            Dock = DockStyle.Fill,
            View = View.Details,
            CheckBoxes = true,
            FullRowSelect = true,
            MultiSelect = false,
            GridLines = false,
            BorderStyle = BorderStyle.FixedSingle,
            HeaderStyle = ColumnHeaderStyle.Clickable
        };
        _modeListView.Columns.Add(i18N.Translate("Mode Name"), 220);
        _modeListView.Columns.Add(i18N.Translate("Category"), 90);
        _modeListView.Columns.Add(i18N.Translate("Rules"), 65, HorizontalAlignment.Right);

        _modeListView.ItemChecked += ModeListView_ItemChecked;
        _modeListView.SelectedIndexChanged += ModeListView_SelectedIndexChanged;
        _modeListView.ColumnClick += ModeListView_ColumnClick;

        leftPanel.Controls.Add(_modeListView);
        leftPanel.Controls.Add(quickActionPanel);
        leftPanel.Controls.Add(searchPanel);

        // ----------------- Right Panel (Rule Preview) -----------------
        var rightPanel = _splitContainer.Panel2;
        rightPanel.Padding = new Padding(4, 12, 12, 0);

        var previewGroupBox = new GroupBox
        {
            Text = i18N.Translate("Rule Preview"),
            Dock = DockStyle.Fill,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
            Padding = new Padding(10, 8, 10, 10)
        };

        _lblPreviewTitle = new Label
        {
            Dock = DockStyle.Top,
            Height = 28,
            Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 30, 30),
            Text = ""
        };

        _lblPreviewPath = new Label
        {
            Dock = DockStyle.Top,
            Height = 20,
            Font = new Font("Microsoft YaHei UI", 8.25F),
            ForeColor = Color.Gray,
            Text = ""
        };

        _protocolFlowPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 26,
            FlowDirection = FlowDirection.LeftToRight,
            Padding = new Padding(0, 2, 0, 2)
        };

        _tabControlRules = new TabControl
        {
            Dock = DockStyle.Fill
        };

        _tabHandle = new TabPage(i18N.Translate("Accelerated Processes"));
        _tabBypass = new TabPage(i18N.Translate("Bypass Rules"));

        _txtHandle = new TextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            BackColor = Color.White,
            Font = new Font("Consolas", 9F),
            BorderStyle = BorderStyle.None
        };
        _tabHandle.Controls.Add(_txtHandle);

        _txtBypass = new TextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            BackColor = Color.White,
            Font = new Font("Consolas", 9F),
            BorderStyle = BorderStyle.None
        };
        _tabBypass.Controls.Add(_txtBypass);

        _tabControlRules.TabPages.Add(_tabHandle);
        _tabControlRules.TabPages.Add(_tabBypass);

        _lblEmptyPreviewTip = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            ForeColor = Color.DarkGray,
            Text = i18N.Translate("Click a mode on the left to preview its rules")
        };

        previewGroupBox.Controls.Add(_tabControlRules);
        previewGroupBox.Controls.Add(_protocolFlowPanel);
        previewGroupBox.Controls.Add(_lblPreviewPath);
        previewGroupBox.Controls.Add(_lblPreviewTitle);
        previewGroupBox.Controls.Add(_lblEmptyPreviewTip);
        _lblEmptyPreviewTip.BringToFront();

        rightPanel.Controls.Add(previewGroupBox);

        // ----------------- Bottom Control Bar -----------------
        var rightButtonPanel = new Panel
        {
            Dock = DockStyle.Right,
            Width = 345,
            Height = 32
        };

        _btnSaveAsGroup = new Button
        {
            Text = i18N.Translate("Save as Mode Group..."),
            Height = 30,
            Width = 150,
            Location = new Point(0, 1),
            FlatStyle = FlatStyle.System
        };
        _btnSaveAsGroup.Click += BtnSaveAsGroup_Click;

        _btnApply = new Button
        {
            Text = i18N.Translate("Apply"),
            Height = 30,
            Width = 85,
            Location = new Point(158, 1),
            FlatStyle = FlatStyle.System
        };
        _btnApply.Click += BtnApply_Click;

        _btnCancel = new Button
        {
            Text = i18N.Translate("Cancel"),
            Height = 30,
            Width = 80,
            Location = new Point(251, 1),
            FlatStyle = FlatStyle.System
        };
        _btnCancel.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };

        rightButtonPanel.Controls.Add(_btnSaveAsGroup);
        rightButtonPanel.Controls.Add(_btnApply);
        rightButtonPanel.Controls.Add(_btnCancel);

        var leftInfoPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Padding = new Padding(0, 4, 0, 0)
        };

        _lblCount = new Label
        {
            AutoSize = true,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(40, 40, 40),
            Text = i18N.Translate("Selected: 0 modes"),
            Margin = new Padding(0, 3, 0, 0)
        };

        _lblRulesSummary = new Label
        {
            AutoSize = true,
            ForeColor = Color.Gray,
            Text = "",
            Margin = new Padding(0, 3, 0, 0),
            Visible = false
        };

        leftInfoPanel.Controls.Add(_lblCount);

        bottomPanel.Controls.Add(leftInfoPanel);
        bottomPanel.Controls.Add(rightButtonPanel);

        Controls.Add(_splitContainer);
        Controls.Add(bottomPanel);

        AcceptButton = _btnApply;
        CancelButton = _btnCancel;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        try
        {
            if (_splitContainer.Width > 560)
            {
                _splitContainer.Panel1MinSize = 340;
                _splitContainer.Panel2MinSize = 260;

                var desiredDistance = (int)(ClientSize.Width * 0.54);
                if (desiredDistance >= _splitContainer.Panel1MinSize &&
                    desiredDistance <= _splitContainer.Width - _splitContainer.Panel2MinSize)
                {
                    _splitContainer.SplitterDistance = desiredDistance;
                }
                else
                {
                    _splitContainer.SplitterDistance = 430;
                }
                _splitContainer.FixedPanel = FixedPanel.Panel1;
            }
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Failed to set SplitContainer.SplitterDistance");
        }
    }

    private void ModeListView_ColumnClick(object? sender, ColumnClickEventArgs e)
    {
        if (_sortColumn == e.Column)
        {
            _sortAscending = !_sortAscending;
        }
        else
        {
            _sortColumn = e.Column;
            _sortAscending = true;
        }

        SortModes();
        UpdateColumnHeaders();
        RefreshListView();
    }

    private void UpdateColumnHeaders()
    {
        var colNames = new[] { i18N.Translate("Mode Name"), i18N.Translate("Category"), i18N.Translate("Rules") };
        for (var i = 0; i < _modeListView.Columns.Count && i < colNames.Length; i++)
        {
            if (i == _sortColumn)
                _modeListView.Columns[i].Text = $"{colNames[i]} {(_sortAscending ? "▲" : "▼")}";
            else
                _modeListView.Columns[i].Text = colNames[i];
        }
    }

    private void SortModes()
    {
        _allProcessModes.Sort((a, b) =>
        {
            int cmp;
            switch (_sortColumn)
            {
                case 1: // Category
                    var catA = Path.GetDirectoryName(ModeService.Instance.GetRelativePath(a.FullName)) ?? "-";
                    var catB = Path.GetDirectoryName(ModeService.Instance.GetRelativePath(b.FullName)) ?? "-";
                    cmp = string.Compare(catA, catB, StringComparison.OrdinalIgnoreCase);
                    if (cmp == 0)
                        cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
                case 2: // Rules count
                    cmp = a.Handle.Count.CompareTo(b.Handle.Count);
                    if (cmp == 0)
                        cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
                case 0: // Mode Name
                default:
                    cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
            }

            return _sortAscending ? cmp : -cmp;
        });
    }

    private void LoadModes(IEnumerable<Redirector>? preselected)
    {
        _allProcessModes.Clear();
        _checkedModes.Clear();

        if (preselected != null)
        {
            foreach (var m in preselected)
                _checkedModes.Add(m);
        }

        // Only include ProcessModes
        foreach (var mode in Global.Modes.OfType<Redirector>())
        {
            _allProcessModes.Add(mode);
        }

        SortModes();
        UpdateColumnHeaders();

        RefreshListView();
        UpdateSelectionSummary();
    }

    private void RefreshListView()
    {
        _updatingCheckState = true;
        _modeListView.BeginUpdate();
        _modeListView.Items.Clear();

        var query = _searchTextBox.Text.Trim();

        foreach (var mode in _allProcessModes)
        {
            if (!string.IsNullOrEmpty(query))
            {
                var matchesName = mode.i18NRemark.Contains(query, StringComparison.OrdinalIgnoreCase);
                var matchesFileName = Path.GetFileName(mode.FullName).Contains(query, StringComparison.OrdinalIgnoreCase);
                var matchesProcess = mode.Handle.Any(h => h.Contains(query, StringComparison.OrdinalIgnoreCase));

                if (!matchesName && !matchesFileName && !matchesProcess)
                    continue;
            }

            var relPath = ModeService.Instance.GetRelativePath(mode.FullName);
            var category = Path.GetDirectoryName(relPath);
            if (string.IsNullOrEmpty(category))
                category = "-";

            var item = new ListViewItem(mode.i18NRemark)
            {
                Tag = mode,
                Checked = _checkedModes.Contains(mode)
            };

            item.SubItems.Add(category);
            item.SubItems.Add($"{mode.Handle.Count}");

            _modeListView.Items.Add(item);
        }

        _modeListView.EndUpdate();
        _updatingCheckState = false;
    }

    private void SearchTextBox_TextChanged(object? sender, EventArgs e)
    {
        RefreshListView();
    }

    private void ModeListView_ItemChecked(object? sender, ItemCheckedEventArgs e)
    {
        if (_updatingCheckState)
            return;

        if (e.Item.Tag is Redirector mode)
        {
            if (e.Item.Checked)
                _checkedModes.Add(mode);
            else
                _checkedModes.Remove(mode);

            UpdateSelectionSummary();
        }
    }

    private void ModeListView_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (_modeListView.SelectedItems.Count > 0 && _modeListView.SelectedItems[0].Tag is Redirector mode)
        {
            ShowModePreview(mode);
        }
    }

    private void ShowModePreview(Redirector mode)
    {
        _lblEmptyPreviewTip.Visible = false;

        _lblPreviewTitle.Text = mode.i18NRemark;
        _lblPreviewPath.Text = ModeService.Instance.GetRelativePath(mode.FullName);

        // Protocol badges
        _protocolFlowPanel.Controls.Clear();
        AddProtocolBadge("TCP", mode.FilterTCP);
        AddProtocolBadge("UDP", mode.FilterUDP);
        AddProtocolBadge("ICMP", mode.FilterICMP);
        AddProtocolBadge("DNS", mode.FilterDNS);

        _tabHandle.Text = $"{i18N.Translate("Accelerated Processes")} ({mode.Handle.Count})";
        _tabBypass.Text = $"{i18N.Translate("Bypass Rules")} ({mode.Bypass.Count})";

        _txtHandle.Text = string.Join(Environment.NewLine, mode.Handle);
        _txtBypass.Text = string.Join(Environment.NewLine, mode.Bypass);
    }

    private void AddProtocolBadge(string name, bool? enabled)
    {
        var badge = new Label
        {
            AutoSize = true,
            Font = new Font("Microsoft YaHei UI", 8F),
            Margin = new Padding(0, 0, 6, 0),
            Padding = new Padding(4, 2, 4, 2)
        };

        if (enabled == true)
        {
            badge.Text = $"{name}: {i18N.Translate("On")}";
            badge.BackColor = Color.FromArgb(230, 244, 234);
            badge.ForeColor = Color.FromArgb(19, 115, 51);
        }
        else if (enabled == false)
        {
            badge.Text = $"{name}: {i18N.Translate("Off")}";
            badge.BackColor = Color.FromArgb(252, 232, 230);
            badge.ForeColor = Color.FromArgb(197, 34, 31);
        }
        else
        {
            badge.Text = $"{name}: {i18N.Translate("Auto")}";
            badge.BackColor = Color.FromArgb(241, 243, 244);
            badge.ForeColor = Color.FromArgb(95, 99, 104);
        }

        _protocolFlowPanel.Controls.Add(badge);
    }

    private void UpdateSelectionSummary()
    {
        var count = _checkedModes.Count;

        if (count > 0)
        {
            var totalHandles = _checkedModes.SelectMany(m => m.Handle).Distinct().Count();
            _lblCount.Text = i18N.TranslateFormat("Selected: {0} mode(s), {1} rule(s)", count, totalHandles);
            _lblRulesSummary.Text = "";
            _btnApply.Enabled = true;
            _btnSaveAsGroup.Enabled = count >= 2;
        }
        else
        {
            _lblCount.Text = i18N.Translate("Selected: 0 modes");
            _lblRulesSummary.Text = "";
            _btnApply.Enabled = false;
            _btnSaveAsGroup.Enabled = false;
        }
    }

    private void BtnSelectAll_Click(object? sender, EventArgs e)
    {
        _updatingCheckState = true;
        foreach (ListViewItem item in _modeListView.Items)
        {
            item.Checked = true;
            if (item.Tag is Redirector mode)
                _checkedModes.Add(mode);
        }
        _updatingCheckState = false;
        UpdateSelectionSummary();
    }

    private void BtnInvert_Click(object? sender, EventArgs e)
    {
        _updatingCheckState = true;
        foreach (ListViewItem item in _modeListView.Items)
        {
            item.Checked = !item.Checked;
            if (item.Tag is Redirector mode)
            {
                if (item.Checked)
                    _checkedModes.Add(mode);
                else
                    _checkedModes.Remove(mode);
            }
        }
        _updatingCheckState = false;
        UpdateSelectionSummary();
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        _updatingCheckState = true;
        foreach (ListViewItem item in _modeListView.Items)
        {
            item.Checked = false;
        }
        _checkedModes.Clear();
        _updatingCheckState = false;
        UpdateSelectionSummary();
    }

    private void BtnApply_Click(object? sender, EventArgs e)
    {
        if (_checkedModes.Count == 0)
        {
            MessageBoxX.Show(i18N.Translate("Please select at least one process mode."));
            return;
        }

        if (_checkedModes.Count == 1)
        {
            ResultMode = _checkedModes.First();
        }
        else
        {
            var summaryName = string.Join(" + ", _checkedModes.Take(2).Select(m => m.i18NRemark));
            if (_checkedModes.Count > 2)
                summaryName += $" (+{_checkedModes.Count - 2})";

            ResultMode = CompositeMode.FromModes(_checkedModes, summaryName, isTemp: true);
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnSaveAsGroup_Click(object? sender, EventArgs e)
    {
        if (_checkedModes.Count < 2)
        {
            MessageBoxX.Show(i18N.Translate("Please select at least two process modes to create a group."));
            return;
        }

        var defaultName = string.Join(" + ", _checkedModes.Take(3).Select(m => m.i18NRemark));
        if (_checkedModes.Count > 3)
            defaultName += "...";

        var groupName = InputDialog.Show(
            i18N.Translate("Save as Mode Group"),
            i18N.Translate("Please enter a name for this mode group:"),
            defaultName,
            this);

        if (string.IsNullOrWhiteSpace(groupName))
            return;

        // Clean invalid file name chars
        foreach (var c in Path.GetInvalidFileNameChars())
            groupName = groupName.Replace(c, '_');

        var groupDir = Path.Combine(ModeService.Instance.ModeDirectoryFullName, "Group");
        if (!Directory.Exists(groupDir))
            Directory.CreateDirectory(groupDir);

        var filePath = Path.Combine(groupDir, $"{groupName}.json");
        if (File.Exists(filePath))
        {
            if (MessageBoxX.Show(i18N.Translate("A mode group with the same name already exists. Overwrite?"), confirm: true, owner: this) != DialogResult.OK)
                return;
        }

        var composite = CompositeMode.FromModes(_checkedModes, groupName, isTemp: false);
        composite.FullName = filePath;

        try
        {
            composite.WriteFile();
            ModeService.Instance.Add(composite);
            ResultMode = composite;
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Save mode group failed");
            MessageBoxX.Show($"{i18N.Translate("Save mode group failed")}: {ex.Message}", Enums.LogLevel.ERROR, owner: this);
        }
    }
}

public class InputDialog : Form
{
    private readonly TextBox _textBox;

    public string InputText => _textBox.Text.Trim();

    public InputDialog(string title, string prompt, string defaultValue = "")
    {
        Text = title;
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Size = new Size(400, 160);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        ShowInTaskbar = false;

        var lblPrompt = new Label
        {
            Text = prompt,
            Location = new Point(16, 16),
            Size = new Size(350, 20),
            TextAlign = ContentAlignment.MiddleLeft
        };

        _textBox = new TextBox
        {
            Text = defaultValue,
            Location = new Point(16, 42),
            Size = new Size(350, 24)
        };
        _textBox.SelectAll();

        var btnOk = new Button
        {
            Text = i18N.Translate("OK"),
            Location = new Point(200, 80),
            Size = new Size(80, 28),
            DialogResult = DialogResult.OK,
            FlatStyle = FlatStyle.System
        };

        var btnCancel = new Button
        {
            Text = i18N.Translate("Cancel"),
            Location = new Point(286, 80),
            Size = new Size(80, 28),
            DialogResult = DialogResult.Cancel,
            FlatStyle = FlatStyle.System
        };

        Controls.Add(lblPrompt);
        Controls.Add(_textBox);
        Controls.Add(btnOk);
        Controls.Add(btnCancel);

        AcceptButton = btnOk;
        CancelButton = btnCancel;
    }

    public static string? Show(string title, string prompt, string defaultValue = "", IWin32Window? owner = null)
    {
        using var dlg = new InputDialog(title, prompt, defaultValue);
        return dlg.ShowDialog(owner) == DialogResult.OK ? dlg.InputText : null;
    }
}
