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
    private bool _adjustingColumns;
    private int _sortColumn = 1;
    private bool _sortAscending = true;

    // Controls
    private SplitContainer _splitContainer = null!;
    private TextBox _searchTextBox = null!;
    private ListView _modeListView = null!;
    private Button _btnSelectAll = null!;
    private Button _btnInvert = null!;
    private Button _btnClear = null!;
    private Button _btnEditMode = null!;
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
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Text = i18N.Translate("Multi-Mode Selector");
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Size = new Size(1020, 600);
        MinimumSize = new Size(880, 500);
        StartPosition = FormStartPosition.CenterParent;
        Icon = Properties.Resources.icon;

        // Main layout: Bottom panel and SplitContainer
        var bottomPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Bottom,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 2,
            RowCount = 1,
            Padding = new Padding(12, 8, 12, 8)
        };
        bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        bottomPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

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
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = true,
            Padding = new Padding(0, 6, 0, 6)
        };

        _btnSelectAll = new Button
        {
            Text = i18N.Translate("Select All"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(65, 24),
            Padding = new Padding(6, 0, 6, 0),
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 4, 0)
        };
        _btnSelectAll.Click += BtnSelectAll_Click;

        _btnInvert = new Button
        {
            Text = i18N.Translate("Invert"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(65, 24),
            Padding = new Padding(6, 0, 6, 0),
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 4, 0)
        };
        _btnInvert.Click += BtnInvert_Click;

        _btnClear = new Button
        {
            Text = i18N.Translate("Clear"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(65, 24),
            Padding = new Padding(6, 0, 6, 0),
            FlatStyle = FlatStyle.System,
            Margin = new Padding(0, 0, 12, 0)
        };
        _btnClear.Click += BtnClear_Click;

        _btnEditMode = new Button
        {
            Text = i18N.Translate("Edit Mode"),
            Enabled = false,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(80, 24),
            Padding = new Padding(8, 0, 8, 0),
            FlatStyle = FlatStyle.System,
            Margin = Padding.Empty
        };
        _btnEditMode.Click += BtnEditMode_Click;

        quickActionPanel.Controls.Add(_btnSelectAll);
        quickActionPanel.Controls.Add(_btnInvert);
        quickActionPanel.Controls.Add(_btnClear);
        quickActionPanel.Controls.Add(_btnEditMode);

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
        _modeListView.Columns.Add(i18N.Translate("Select"), 68);
        _modeListView.Columns.Add(i18N.Translate("Mode Name"), 280);
        _modeListView.Columns.Add(i18N.Translate("Category"), 95);
        _modeListView.Columns.Add(i18N.Translate("Rules"), 75, HorizontalAlignment.Right);

        _modeListView.ItemChecked += ModeListView_ItemChecked;
        _modeListView.SelectedIndexChanged += ModeListView_SelectedIndexChanged;
        _modeListView.ColumnClick += ModeListView_ColumnClick;
        _modeListView.Resize += (_, _) => AdjustListViewColumns();
        _modeListView.ClientSizeChanged += (_, _) => AdjustListViewColumns();

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
            AutoSize = true,
            Padding = new Padding(0, 0, 0, 2),
            Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 30, 30),
            Text = ""
        };

        _lblPreviewPath = new Label
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            Padding = new Padding(0, 0, 0, 4),
            Font = new Font("Microsoft YaHei UI", 8.25F),
            ForeColor = Color.Gray,
            Text = ""
        };

        _protocolFlowPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = true,
            Padding = new Padding(0, 2, 0, 4)
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
        var rightButtonPanel = new FlowLayoutPanel
        {
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Margin = Padding.Empty
        };

        _btnSaveAsGroup = new Button
        {
            Text = i18N.Translate("Save as Mode Group..."),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(140, 30),
            Padding = new Padding(10, 0, 10, 0),
            Margin = new Padding(0, 0, 8, 0),
            FlatStyle = FlatStyle.System
        };
        _btnSaveAsGroup.Click += BtnSaveAsGroup_Click;

        _btnApply = new Button
        {
            Text = i18N.Translate("Apply"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(85, 30),
            Padding = new Padding(10, 0, 10, 0),
            Margin = new Padding(0, 0, 8, 0),
            FlatStyle = FlatStyle.System
        };
        _btnApply.Click += BtnApply_Click;

        _btnCancel = new Button
        {
            Text = i18N.Translate("Cancel"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(80, 30),
            Padding = new Padding(10, 0, 10, 0),
            Margin = Padding.Empty,
            FlatStyle = FlatStyle.System
        };
        _btnCancel.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };

        rightButtonPanel.Controls.Add(_btnSaveAsGroup);
        rightButtonPanel.Controls.Add(_btnApply);
        rightButtonPanel.Controls.Add(_btnCancel);

        _lblCount = new Label
        {
            Anchor = AnchorStyles.Left,
            AutoSize = true,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(40, 40, 40),
            Text = i18N.Translate("Selected: 0 modes"),
            Margin = Padding.Empty
        };

        _lblRulesSummary = new Label
        {
            AutoSize = true,
            ForeColor = Color.Gray,
            Text = "",
            Margin = Padding.Empty,
            Visible = false
        };

        bottomPanel.Controls.Add(_lblCount, 0, 0);
        bottomPanel.Controls.Add(rightButtonPanel, 1, 0);

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
            var minTrigger = LogicalToDeviceUnits(640);
            if (_splitContainer.Width > minTrigger)
            {
                _splitContainer.Panel1MinSize = LogicalToDeviceUnits(440);
                _splitContainer.Panel2MinSize = LogicalToDeviceUnits(350);

                var rightWidth = LogicalToDeviceUnits(380);
                var desiredDistance = Math.Max(_splitContainer.Panel1MinSize, _splitContainer.Width - rightWidth);
                _splitContainer.SplitterDistance = Math.Min(desiredDistance, _splitContainer.Width - _splitContainer.Panel2MinSize);
                _splitContainer.FixedPanel = FixedPanel.Panel2;
            }

            AdjustListViewColumns();
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Failed to set SplitContainer.SplitterDistance");
        }
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        AdjustListViewColumns();
    }

    private void AdjustListViewColumns()
    {
        if (_adjustingColumns || _modeListView.Columns.Count < 4 || _modeListView.ClientSize.Width <= 0)
            return;

        _adjustingColumns = true;
        try
        {
            var clientWidth = _modeListView.ClientSize.Width;
            var selectW = LogicalToDeviceUnits(68);
            var categoryW = LogicalToDeviceUnits(95);
            var rulesW = LogicalToDeviceUnits(78);
            var nameW = Math.Max(LogicalToDeviceUnits(160), clientWidth - selectW - categoryW - rulesW - LogicalToDeviceUnits(4));

            _modeListView.Columns[0].Width = selectW;
            _modeListView.Columns[1].Width = nameW;
            _modeListView.Columns[2].Width = categoryW;
            _modeListView.Columns[3].Width = rulesW;
        }
        finally
        {
            _adjustingColumns = false;
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
        var colNames = new[] { i18N.Translate("Select"), i18N.Translate("Mode Name"), i18N.Translate("Category"), i18N.Translate("Rules") };
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
                case 0: // Checked state
                    cmp = _checkedModes.Contains(b).CompareTo(_checkedModes.Contains(a));
                    if (cmp == 0)
                        cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
                case 2: // Category
                    var catA = Path.GetDirectoryName(ModeService.Instance.GetRelativePath(a.FullName)) ?? "-";
                    var catB = Path.GetDirectoryName(ModeService.Instance.GetRelativePath(b.FullName)) ?? "-";
                    cmp = string.Compare(catA, catB, StringComparison.OrdinalIgnoreCase);
                    if (cmp == 0)
                        cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
                case 3: // Rules count
                    cmp = a.Handle.Count.CompareTo(b.Handle.Count);
                    if (cmp == 0)
                        cmp = string.Compare(a.i18NRemark, b.i18NRemark, StringComparison.OrdinalIgnoreCase);
                    break;
                case 1: // Mode Name
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

            var item = new ListViewItem("")
            {
                Tag = mode,
                Checked = _checkedModes.Contains(mode)
            };

            item.SubItems.Add(mode.i18NRemark);
            item.SubItems.Add(category);
            item.SubItems.Add($"{mode.Handle.Count}");

            _modeListView.Items.Add(item);
        }

        _modeListView.EndUpdate();
        _updatingCheckState = false;
        if (IsHandleCreated)
            BeginInvoke((Action)AdjustListViewColumns);
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
            _btnEditMode.Enabled = true;
            ShowModePreview(mode);
        }
        else
        {
            _btnEditMode.Enabled = false;
        }
    }

    private void BtnEditMode_Click(object? sender, EventArgs e)
    {
        if (_modeListView.SelectedItems.Count == 0 || _modeListView.SelectedItems[0].Tag is not Redirector mode)
            return;

        if (mode is CompositeMode)
        {
            MessageBoxX.Show(i18N.Translate("Mode groups cannot be edited in Process Mode editor."), owner: this);
            return;
        }

        using var editor = new ProcessForm(mode);
        editor.ShowDialog(this);

        SortModes();
        RefreshListView();

        foreach (ListViewItem item in _modeListView.Items)
        {
            if (ReferenceEquals(item.Tag, mode))
            {
                item.Selected = true;
                item.EnsureVisible();
                break;
            }
        }

        ShowModePreview(mode);
        UpdateSelectionSummary();
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
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Text = title;
        Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        ShowInTaskbar = false;

        var rootLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 1,
            RowCount = 3,
            Padding = new Padding(16),
            MinimumSize = new Size(400, 0)
        };
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var lblPrompt = new Label
        {
            Text = prompt,
            AutoSize = true,
            MaximumSize = new Size(368, 0),
            Margin = new Padding(0, 0, 0, 8),
            TextAlign = ContentAlignment.MiddleLeft
        };

        _textBox = new TextBox
        {
            Text = defaultValue,
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 0, 0, 14)
        };
        _textBox.SelectAll();

        var buttonPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            FlowDirection = FlowDirection.RightToLeft,
            WrapContents = false,
            Margin = Padding.Empty
        };

        var btnCancel = new Button
        {
            Text = i18N.Translate("Cancel"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(80, 28),
            Padding = new Padding(8, 0, 8, 0),
            Margin = Padding.Empty,
            DialogResult = DialogResult.Cancel,
            FlatStyle = FlatStyle.System
        };

        var btnOk = new Button
        {
            Text = i18N.Translate("OK"),
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            MinimumSize = new Size(80, 28),
            Padding = new Padding(8, 0, 8, 0),
            Margin = new Padding(0, 0, 8, 0),
            DialogResult = DialogResult.OK,
            FlatStyle = FlatStyle.System
        };

        buttonPanel.Controls.Add(btnCancel);
        buttonPanel.Controls.Add(btnOk);

        rootLayout.Controls.Add(lblPrompt, 0, 0);
        rootLayout.Controls.Add(_textBox, 0, 1);
        rootLayout.Controls.Add(buttonPanel, 0, 2);

        Controls.Add(rootLayout);

        AcceptButton = btnOk;
        CancelButton = btnCancel;
    }

    public static string? Show(string title, string prompt, string defaultValue = "", IWin32Window? owner = null)
    {
        using var dlg = new InputDialog(title, prompt, defaultValue);
        return dlg.ShowDialog(owner) == DialogResult.OK ? dlg.InputText : null;
    }
}
