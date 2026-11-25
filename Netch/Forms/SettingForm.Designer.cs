namespace Netch.Forms
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var rootLayout = new System.Windows.Forms.TableLayoutPanel();
            var bottomButtonFlow = new System.Windows.Forms.FlowLayoutPanel();
            var generalTabLayout = new System.Windows.Forms.TableLayoutPanel();
            var nfTabLayout = new System.Windows.Forms.TableLayoutPanel();
            var tunTabLayout = new System.Windows.Forms.TableLayoutPanel();
            var otherTabLayout = new System.Windows.Forms.TableLayoutPanel();

            this.TabControl = new System.Windows.Forms.TabControl();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.PortGroupBox = new System.Windows.Forms.GroupBox();
            this.Socks5PortLabel = new System.Windows.Forms.Label();
            this.Socks5PortTextBox = new System.Windows.Forms.TextBox();
            this.AllowDevicesCheckBox = new System.Windows.Forms.CheckBox();
            this.ServerPingTypeLabel = new System.Windows.Forms.Label();
            this.ICMPingRadioBtn = new System.Windows.Forms.RadioButton();
            this.TCPingRadioBtn = new System.Windows.Forms.RadioButton();
            this.STUNServerLabel = new System.Windows.Forms.Label();
            this.STUN_ServerComboBox = new System.Windows.Forms.ComboBox();
            this.ProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.ProfileCountLabel = new System.Windows.Forms.Label();
            this.ProfileCountTextBox = new System.Windows.Forms.TextBox();
            this.DetectionTickLabel = new System.Windows.Forms.Label();
            this.DetectionTickTextBox = new System.Windows.Forms.TextBox();
            this.StartedPingLabel = new System.Windows.Forms.Label();
            this.StartedPingIntervalTextBox = new System.Windows.Forms.TextBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.NFTabPage = new System.Windows.Forms.TabPage();
            this.TrafficFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterTCPCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterUDPCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterICMPCheckBox = new System.Windows.Forms.CheckBox();
            this.ICMPDelayLabel = new System.Windows.Forms.Label();
            this.ICMPDelayTextBox = new System.Windows.Forms.TextBox();
            this.ChildProcessHandleCheckBox = new System.Windows.Forms.CheckBox();
            this.DNSGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.DNSHijackLabel = new System.Windows.Forms.Label();
            this.DNSHijackHostTextBox = new System.Windows.Forms.TextBox();
            this.DNSProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleProcDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.WinTUNTabPage = new System.Windows.Forms.TabPage();
            this.WinTUNGroupBox = new System.Windows.Forms.GroupBox();
            this.TUNTAPAddressLabel = new System.Windows.Forms.Label();
            this.TUNTAPAddressTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPNetmaskLabel = new System.Windows.Forms.Label();
            this.TUNTAPNetmaskTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPGatewayLabel = new System.Windows.Forms.Label();
            this.TUNTAPGatewayTextBox = new System.Windows.Forms.TextBox();
            this.UseCustomDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.ProxyDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.TUNTAPDNSLabel = new System.Windows.Forms.Label();
            this.TUNTAPDNSTextBox = new System.Windows.Forms.TextBox();
            this.GlobalBypassIPsButton = new System.Windows.Forms.Button();
            this.OtherTabPage = new System.Windows.Forms.TabPage();
            this.StartupBehaviorGroupBox = new System.Windows.Forms.GroupBox();
            this.StartWhenOpenedCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimizeWhenStartedCheckBox = new System.Windows.Forms.CheckBox();
            this.ExitWhenClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.StopWhenExitedCheckBox = new System.Windows.Forms.CheckBox();
            this.RunAtStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateNoticeGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckUpdateWhenOpenedCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckBetaUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.NoSupportDialogCheckBox = new System.Windows.Forms.CheckBox();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChinaDNSTextBox = new System.Windows.Forms.TextBox();
            this.OtherDNSTextBox = new System.Windows.Forms.TextBox();
            this.AioDNSListenPortTextBox = new System.Windows.Forms.TextBox();

            rootLayout.SuspendLayout();
            bottomButtonFlow.SuspendLayout();
            generalTabLayout.SuspendLayout();
            nfTabLayout.SuspendLayout();
            tunTabLayout.SuspendLayout();
            otherTabLayout.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.PortGroupBox.SuspendLayout();
            this.ProfileGroupBox.SuspendLayout();
            this.NFTabPage.SuspendLayout();
            this.TrafficFilterGroupBox.SuspendLayout();
            this.DNSGroupBox.SuspendLayout();
            this.WinTUNTabPage.SuspendLayout();
            this.WinTUNGroupBox.SuspendLayout();
            this.OtherTabPage.SuspendLayout();
            this.StartupBehaviorGroupBox.SuspendLayout();
            this.UpdateNoticeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.Controls.Add(this.TabControl, 0, 0);
            rootLayout.Controls.Add(bottomButtonFlow, 0, 1);
            rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rootLayout.Location = new System.Drawing.Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new System.Windows.Forms.Padding(12);
            rootLayout.RowCount = 2;
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.Size = new System.Drawing.Size(500, 518);
            rootLayout.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.GeneralTabPage);
            this.TabControl.Controls.Add(this.NFTabPage);
            this.TabControl.Controls.Add(this.WinTUNTabPage);
            this.TabControl.Controls.Add(this.OtherTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(12, 4);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.AutoScroll = true;
            this.GeneralTabPage.BackColor = System.Drawing.Color.White;
            this.GeneralTabPage.Controls.Add(generalTabLayout);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "General";
            // 
            // generalTabLayout
            // 
            generalTabLayout.AutoSize = true;
            generalTabLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            generalTabLayout.ColumnCount = 1;
            generalTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            generalTabLayout.Controls.Add(this.PortGroupBox, 0, 0);
            generalTabLayout.Controls.Add(this.ProfileGroupBox, 0, 1);
            generalTabLayout.Dock = System.Windows.Forms.DockStyle.Top;
            generalTabLayout.Margin = new System.Windows.Forms.Padding(0);
            generalTabLayout.Name = "generalTabLayout";
            generalTabLayout.RowCount = 2;
            generalTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            generalTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            generalTabLayout.TabIndex = 0;
            // 
            // PortGroupBox
            // 
            var portTable = new System.Windows.Forms.TableLayoutPanel();
            portTable.SuspendLayout();
            this.PortGroupBox.AutoSize = true;
            this.PortGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PortGroupBox.BackColor = System.Drawing.Color.White;
            this.PortGroupBox.Controls.Add(portTable);
            this.PortGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.PortGroupBox.TabIndex = 0;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Local Listener & Testing";
            // 
            // portTable
            // 
            portTable.AutoSize = true;
            portTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            portTable.ColumnCount = 3;
            portTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            portTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            portTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            portTable.Controls.Add(this.Socks5PortLabel, 0, 0);
            portTable.Controls.Add(this.Socks5PortTextBox, 1, 0);
            portTable.Controls.Add(this.AllowDevicesCheckBox, 2, 0);
            portTable.Controls.Add(this.ServerPingTypeLabel, 0, 1);
            var pingPanel = new System.Windows.Forms.FlowLayoutPanel();
            pingPanel.AutoSize = true;
            pingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pingPanel.WrapContents = false;
            pingPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            pingPanel.Controls.Add(this.ICMPingRadioBtn);
            pingPanel.Controls.Add(this.TCPingRadioBtn);
            portTable.Controls.Add(pingPanel, 1, 1);
            portTable.SetColumnSpan(pingPanel, 2);
            portTable.Controls.Add(this.STUNServerLabel, 0, 2);
            portTable.Controls.Add(this.STUN_ServerComboBox, 1, 2);
            portTable.SetColumnSpan(this.STUN_ServerComboBox, 2);
            portTable.Dock = System.Windows.Forms.DockStyle.Fill;
            portTable.Name = "portTable";
            portTable.RowCount = 3;
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            portTable.TabIndex = 0;
            // 
            // Socks5PortLabel
            // 
            this.Socks5PortLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Socks5PortLabel.AutoSize = true;
            this.Socks5PortLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.Socks5PortLabel.Name = "Socks5PortLabel";
            this.Socks5PortLabel.TabIndex = 0;
            this.Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            this.Socks5PortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Socks5PortTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 10, 4);
            this.Socks5PortTextBox.Name = "Socks5PortTextBox";
            this.Socks5PortTextBox.Size = new System.Drawing.Size(80, 23);
            this.Socks5PortTextBox.TabIndex = 1;
            this.Socks5PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllowDevicesCheckBox
            // 
            this.AllowDevicesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AllowDevicesCheckBox.AutoSize = true;
            this.AllowDevicesCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            this.AllowDevicesCheckBox.TabIndex = 2;
            this.AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            this.AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServerPingTypeLabel
            // 
            this.ServerPingTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerPingTypeLabel.AutoSize = true;
            this.ServerPingTypeLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.ServerPingTypeLabel.Name = "ServerPingTypeLabel";
            this.ServerPingTypeLabel.TabIndex = 3;
            this.ServerPingTypeLabel.Text = "Ping Protocol";
            // 
            // ICMPingRadioBtn
            // 
            this.ICMPingRadioBtn.AutoSize = true;
            this.ICMPingRadioBtn.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.ICMPingRadioBtn.Name = "ICMPingRadioBtn";
            this.ICMPingRadioBtn.TabIndex = 4;
            this.ICMPingRadioBtn.TabStop = true;
            this.ICMPingRadioBtn.Text = "ICMPing";
            this.ICMPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TCPingRadioBtn
            // 
            this.TCPingRadioBtn.AutoSize = true;
            this.TCPingRadioBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TCPingRadioBtn.Name = "TCPingRadioBtn";
            this.TCPingRadioBtn.TabIndex = 5;
            this.TCPingRadioBtn.TabStop = true;
            this.TCPingRadioBtn.Text = "TCPing";
            this.TCPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // STUNServerLabel
            // 
            this.STUNServerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STUNServerLabel.AutoSize = true;
            this.STUNServerLabel.Margin = new System.Windows.Forms.Padding(0, 6, 8, 6);
            this.STUNServerLabel.Name = "STUNServerLabel";
            this.STUNServerLabel.TabIndex = 6;
            this.STUNServerLabel.Text = "STUN Server";
            // 
            // STUN_ServerComboBox
            // 
            this.STUN_ServerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.STUN_ServerComboBox.FormattingEnabled = true;
            this.STUN_ServerComboBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.STUN_ServerComboBox.Name = "STUN_ServerComboBox";
            this.STUN_ServerComboBox.TabIndex = 7;
            // 
            // ProfileGroupBox
            // 
            var profileTable = new System.Windows.Forms.TableLayoutPanel();
            profileTable.SuspendLayout();
            this.ProfileGroupBox.AutoSize = true;
            this.ProfileGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProfileGroupBox.BackColor = System.Drawing.Color.White;
            this.ProfileGroupBox.Controls.Add(profileTable);
            this.ProfileGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.ProfileGroupBox.TabIndex = 1;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles & Timing";
            // 
            // profileTable
            // 
            profileTable.AutoSize = true;
            profileTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            profileTable.ColumnCount = 2;
            profileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            profileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            profileTable.Controls.Add(this.ProfileCountLabel, 0, 0);
            profileTable.Controls.Add(this.ProfileCountTextBox, 1, 0);
            profileTable.Controls.Add(this.DetectionTickLabel, 0, 1);
            profileTable.Controls.Add(this.DetectionTickTextBox, 1, 1);
            profileTable.Controls.Add(this.StartedPingLabel, 0, 2);
            profileTable.Controls.Add(this.StartedPingIntervalTextBox, 1, 2);
            profileTable.Controls.Add(this.LanguageLabel, 0, 3);
            profileTable.Controls.Add(this.LanguageComboBox, 1, 3);
            profileTable.Dock = System.Windows.Forms.DockStyle.Fill;
            profileTable.Name = "profileTable";
            profileTable.RowCount = 4;
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            profileTable.TabIndex = 0;
            // 
            // ProfileCountLabel
            // 
            this.ProfileCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfileCountLabel.AutoSize = true;
            this.ProfileCountLabel.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.ProfileCountLabel.Name = "ProfileCountLabel";
            this.ProfileCountLabel.TabIndex = 0;
            this.ProfileCountLabel.Text = "Profile Count";
            // 
            // ProfileCountTextBox
            // 
            this.ProfileCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfileCountTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ProfileCountTextBox.Name = "ProfileCountTextBox";
            this.ProfileCountTextBox.Size = new System.Drawing.Size(80, 23);
            this.ProfileCountTextBox.TabIndex = 1;
            this.ProfileCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetectionTickLabel
            // 
            this.DetectionTickLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DetectionTickLabel.AutoSize = true;
            this.DetectionTickLabel.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.DetectionTickLabel.Name = "DetectionTickLabel";
            this.DetectionTickLabel.TabIndex = 2;
            this.DetectionTickLabel.Text = "Detection Tick(sec)";
            // 
            // DetectionTickTextBox
            // 
            this.DetectionTickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DetectionTickTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.DetectionTickTextBox.Name = "DetectionTickTextBox";
            this.DetectionTickTextBox.Size = new System.Drawing.Size(80, 23);
            this.DetectionTickTextBox.TabIndex = 3;
            this.DetectionTickTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartedPingLabel
            // 
            this.StartedPingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartedPingLabel.AutoSize = true;
            this.StartedPingLabel.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.StartedPingLabel.Name = "StartedPingLabel";
            this.StartedPingLabel.TabIndex = 4;
            this.StartedPingLabel.Text = "Delay test after start(sec)";
            // 
            // StartedPingIntervalTextBox
            // 
            this.StartedPingIntervalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartedPingIntervalTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.StartedPingIntervalTextBox.Name = "StartedPingIntervalTextBox";
            this.StartedPingIntervalTextBox.Size = new System.Drawing.Size(80, 23);
            this.StartedPingIntervalTextBox.TabIndex = 5;
            this.StartedPingIntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(140, 25);
            this.LanguageComboBox.TabIndex = 7;
            // 
            // NFTabPage
            // 
            this.NFTabPage.AutoScroll = true;
            this.NFTabPage.BackColor = System.Drawing.Color.White;
            this.NFTabPage.Controls.Add(nfTabLayout);
            this.NFTabPage.Name = "NFTabPage";
            this.NFTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.NFTabPage.TabIndex = 1;
            this.NFTabPage.Text = "Process Mode";
            // 
            // nfTabLayout
            // 
            nfTabLayout.AutoSize = true;
            nfTabLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            nfTabLayout.ColumnCount = 1;
            nfTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            nfTabLayout.Controls.Add(this.TrafficFilterGroupBox, 0, 0);
            nfTabLayout.Controls.Add(this.DNSGroupBox, 0, 1);
            nfTabLayout.Dock = System.Windows.Forms.DockStyle.Top;
            nfTabLayout.Margin = new System.Windows.Forms.Padding(0);
            nfTabLayout.Name = "nfTabLayout";
            nfTabLayout.RowCount = 2;
            nfTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            nfTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            nfTabLayout.TabIndex = 0;
            // 
            // TrafficFilterGroupBox
            // 
            var tfTable = new System.Windows.Forms.TableLayoutPanel();
            tfTable.SuspendLayout();
            this.TrafficFilterGroupBox.AutoSize = true;
            this.TrafficFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TrafficFilterGroupBox.BackColor = System.Drawing.Color.White;
            this.TrafficFilterGroupBox.Controls.Add(tfTable);
            this.TrafficFilterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficFilterGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TrafficFilterGroupBox.Name = "TrafficFilterGroupBox";
            this.TrafficFilterGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.TrafficFilterGroupBox.TabIndex = 0;
            this.TrafficFilterGroupBox.TabStop = false;
            this.TrafficFilterGroupBox.Text = "Protocol Filtering";
            // 
            // tfTable
            // 
            tfTable.AutoSize = true;
            tfTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tfTable.ColumnCount = 2;
            tfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tfTable.Controls.Add(this.FilterTCPCheckBox, 0, 0);
            tfTable.Controls.Add(this.ChildProcessHandleCheckBox, 1, 0);
            tfTable.Controls.Add(this.FilterUDPCheckBox, 0, 1);
            tfTable.Controls.Add(this.FilterICMPCheckBox, 0, 2);
            var icmpDelayPanel = new System.Windows.Forms.FlowLayoutPanel();
            icmpDelayPanel.AutoSize = true;
            icmpDelayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            icmpDelayPanel.WrapContents = false;
            icmpDelayPanel.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.ICMPDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICMPDelayLabel.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(65, 23);
            icmpDelayPanel.Controls.Add(this.ICMPDelayLabel);
            icmpDelayPanel.Controls.Add(this.ICMPDelayTextBox);
            tfTable.Controls.Add(icmpDelayPanel, 0, 3);
            tfTable.SetColumnSpan(icmpDelayPanel, 2);
            tfTable.Dock = System.Windows.Forms.DockStyle.Fill;
            tfTable.Name = "tfTable";
            tfTable.RowCount = 4;
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tfTable.TabIndex = 0;
            // 
            // FilterTCPCheckBox
            // 
            this.FilterTCPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterTCPCheckBox.AutoSize = true;
            this.FilterTCPCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterTCPCheckBox.Name = "FilterTCPCheckBox";
            this.FilterTCPCheckBox.TabIndex = 0;
            this.FilterTCPCheckBox.Text = "Handle TCP";
            this.FilterTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterUDPCheckBox
            // 
            this.FilterUDPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterUDPCheckBox.AutoSize = true;
            this.FilterUDPCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterUDPCheckBox.Name = "FilterUDPCheckBox";
            this.FilterUDPCheckBox.TabIndex = 1;
            this.FilterUDPCheckBox.Text = "Handle UDP";
            this.FilterUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterICMPCheckBox
            // 
            this.FilterICMPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterICMPCheckBox.AutoSize = true;
            this.FilterICMPCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterICMPCheckBox.Name = "FilterICMPCheckBox";
            this.FilterICMPCheckBox.TabIndex = 2;
            this.FilterICMPCheckBox.Text = "Handle ICMP";
            this.FilterICMPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ICMPDelayLabel
            // 
            this.ICMPDelayLabel.AutoSize = true;
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.TabIndex = 3;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterICMPCheckBox, "Checked", true));
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChildProcessHandleCheckBox
            // 
            this.ChildProcessHandleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChildProcessHandleCheckBox.AutoSize = true;
            this.ChildProcessHandleCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChildProcessHandleCheckBox.Name = "ChildProcessHandleCheckBox";
            this.ChildProcessHandleCheckBox.TabIndex = 5;
            this.ChildProcessHandleCheckBox.Text = "Handle child process";
            this.ChildProcessHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSGroupBox
            // 
            var dnsTable = new System.Windows.Forms.TableLayoutPanel();
            dnsTable.SuspendLayout();
            this.DNSGroupBox.AutoSize = true;
            this.DNSGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DNSGroupBox.BackColor = System.Drawing.Color.White;
            this.DNSGroupBox.Controls.Add(dnsTable);
            this.DNSGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNSGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.DNSGroupBox.Name = "DNSGroupBox";
            this.DNSGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.DNSGroupBox.TabIndex = 1;
            this.DNSGroupBox.TabStop = false;
            this.DNSGroupBox.Text = "DNS Settings";
            // 
            // dnsTable
            // 
            dnsTable.AutoSize = true;
            dnsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            dnsTable.ColumnCount = 1;
            dnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            dnsTable.Controls.Add(this.FilterDNSCheckBox, 0, 0);
            var dnsHostPanel = new System.Windows.Forms.FlowLayoutPanel();
            dnsHostPanel.AutoSize = true;
            dnsHostPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            dnsHostPanel.WrapContents = false;
            dnsHostPanel.Margin = new System.Windows.Forms.Padding(20, 4, 0, 4);
            this.DNSHijackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSHijackLabel.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.DNSHijackHostTextBox.Size = new System.Drawing.Size(220, 23);
            dnsHostPanel.Controls.Add(this.DNSHijackLabel);
            dnsHostPanel.Controls.Add(this.DNSHijackHostTextBox);
            dnsTable.Controls.Add(dnsHostPanel, 0, 1);
            dnsTable.Controls.Add(this.DNSProxyCheckBox, 0, 2);
            dnsTable.Controls.Add(this.HandleProcDNSCheckBox, 0, 3);
            dnsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            dnsTable.Name = "dnsTable";
            dnsTable.RowCount = 4;
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.TabIndex = 0;
            // 
            // FilterDNSCheckBox
            // 
            this.FilterDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterDNSCheckBox.AutoSize = true;
            this.FilterDNSCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterDNSCheckBox.Name = "FilterDNSCheckBox";
            this.FilterDNSCheckBox.TabIndex = 0;
            this.FilterDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.FilterDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSHijackLabel
            // 
            this.DNSHijackLabel.AutoSize = true;
            this.DNSHijackLabel.Name = "DNSHijackLabel";
            this.DNSHijackLabel.TabIndex = 1;
            this.DNSHijackLabel.Text = "DNS";
            // 
            // DNSHijackHostTextBox
            // 
            this.DNSHijackHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSHijackHostTextBox.Name = "DNSHijackHostTextBox";
            this.DNSHijackHostTextBox.TabIndex = 2;
            this.DNSHijackHostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DNSProxyCheckBox
            // 
            this.DNSProxyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSProxyCheckBox.AutoSize = true;
            this.DNSProxyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSProxyCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DNSProxyCheckBox.Name = "DNSProxyCheckBox";
            this.DNSProxyCheckBox.TabIndex = 3;
            this.DNSProxyCheckBox.Text = "Handle DNS through proxy";
            this.DNSProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.HandleProcDNSCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.TabIndex = 4;
            this.HandleProcDNSCheckBox.Text = "Handle handled process's DNS";
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // WinTUNTabPage
            // 
            this.WinTUNTabPage.AutoScroll = true;
            this.WinTUNTabPage.BackColor = System.Drawing.Color.White;
            this.WinTUNTabPage.Controls.Add(tunTabLayout);
            this.WinTUNTabPage.Name = "WinTUNTabPage";
            this.WinTUNTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.WinTUNTabPage.TabIndex = 2;
            this.WinTUNTabPage.Text = "WinTUN";
            // 
            // tunTabLayout
            // 
            tunTabLayout.AutoSize = true;
            tunTabLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tunTabLayout.ColumnCount = 1;
            tunTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tunTabLayout.Controls.Add(this.WinTUNGroupBox, 0, 0);
            tunTabLayout.Controls.Add(this.GlobalBypassIPsButton, 0, 1);
            tunTabLayout.Dock = System.Windows.Forms.DockStyle.Top;
            tunTabLayout.Margin = new System.Windows.Forms.Padding(0);
            tunTabLayout.Name = "tunTabLayout";
            tunTabLayout.RowCount = 2;
            tunTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTabLayout.TabIndex = 0;
            // 
            // WinTUNGroupBox
            // 
            var tunTable = new System.Windows.Forms.TableLayoutPanel();
            tunTable.SuspendLayout();
            this.WinTUNGroupBox.AutoSize = true;
            this.WinTUNGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WinTUNGroupBox.BackColor = System.Drawing.Color.White;
            this.WinTUNGroupBox.Controls.Add(tunTable);
            this.WinTUNGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinTUNGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.WinTUNGroupBox.Name = "WinTUNGroupBox";
            this.WinTUNGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.WinTUNGroupBox.TabIndex = 0;
            this.WinTUNGroupBox.TabStop = false;
            this.WinTUNGroupBox.Text = "Network Settings";
            // 
            // tunTable
            // 
            tunTable.AutoSize = true;
            tunTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tunTable.ColumnCount = 2;
            tunTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tunTable.Controls.Add(this.TUNTAPAddressLabel, 0, 0);
            tunTable.Controls.Add(this.TUNTAPAddressTextBox, 1, 0);
            tunTable.Controls.Add(this.TUNTAPNetmaskLabel, 0, 1);
            tunTable.Controls.Add(this.TUNTAPNetmaskTextBox, 1, 1);
            tunTable.Controls.Add(this.TUNTAPGatewayLabel, 0, 2);
            tunTable.Controls.Add(this.TUNTAPGatewayTextBox, 1, 2);
            var tunDnsCheckPanel = new System.Windows.Forms.FlowLayoutPanel();
            tunDnsCheckPanel.AutoSize = true;
            tunDnsCheckPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tunDnsCheckPanel.WrapContents = false;
            tunDnsCheckPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            tunDnsCheckPanel.Controls.Add(this.UseCustomDNSCheckBox);
            tunDnsCheckPanel.Controls.Add(this.ProxyDNSCheckBox);
            tunTable.Controls.Add(tunDnsCheckPanel, 0, 3);
            tunTable.SetColumnSpan(tunDnsCheckPanel, 2);
            tunTable.Controls.Add(this.TUNTAPDNSLabel, 0, 4);
            tunTable.Controls.Add(this.TUNTAPDNSTextBox, 1, 4);
            tunTable.Dock = System.Windows.Forms.DockStyle.Fill;
            tunTable.Name = "tunTable";
            tunTable.RowCount = 5;
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tunTable.TabIndex = 0;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.TabIndex = 0;
            this.TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPAddressTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.TabIndex = 1;
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.TabIndex = 2;
            this.TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPNetmaskTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.TabIndex = 3;
            this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.TabIndex = 4;
            this.TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPGatewayTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.TabIndex = 5;
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UseCustomDNSCheckBox
            // 
            this.UseCustomDNSCheckBox.AutoSize = true;
            this.UseCustomDNSCheckBox.Margin = new System.Windows.Forms.Padding(0, 4, 15, 4);
            this.UseCustomDNSCheckBox.Name = "UseCustomDNSCheckBox";
            this.UseCustomDNSCheckBox.TabIndex = 6;
            this.UseCustomDNSCheckBox.Text = "Use custom DNS";
            this.UseCustomDNSCheckBox.UseVisualStyleBackColor = true;
            this.UseCustomDNSCheckBox.Click += new System.EventHandler(this.TUNTAPUseCustomDNSCheckBox_CheckedChanged);
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.ProxyDNSCheckBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.TabIndex = 7;
            this.ProxyDNSCheckBox.Text = "Proxy DNS";
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.TUNTAPDNSLabel.Margin = new System.Windows.Forms.Padding(0, 6, 10, 6);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.TabIndex = 8;
            this.TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPDNSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.TUNTAPDNSTextBox.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.TabIndex = 9;
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GlobalBypassIPsButton
            // 
            this.GlobalBypassIPsButton.AutoSize = true;
            this.GlobalBypassIPsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalBypassIPsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalBypassIPsButton.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalBypassIPsButton.MinimumSize = new System.Drawing.Size(0, 30);
            this.GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            this.GlobalBypassIPsButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GlobalBypassIPsButton.TabIndex = 1;
            this.GlobalBypassIPsButton.Text = "Global Bypass IPs";
            this.GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            this.GlobalBypassIPsButton.Click += new System.EventHandler(this.GlobalBypassIPsButton_Click);
            // 
            // OtherTabPage
            // 
            this.OtherTabPage.AutoScroll = true;
            this.OtherTabPage.BackColor = System.Drawing.Color.White;
            this.OtherTabPage.Controls.Add(otherTabLayout);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.OtherTabPage.TabIndex = 3;
            this.OtherTabPage.Text = "Others";
            // 
            // otherTabLayout
            // 
            otherTabLayout.AutoSize = true;
            otherTabLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            otherTabLayout.ColumnCount = 1;
            otherTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            otherTabLayout.Controls.Add(this.StartupBehaviorGroupBox, 0, 0);
            otherTabLayout.Controls.Add(this.UpdateNoticeGroupBox, 0, 1);
            otherTabLayout.Dock = System.Windows.Forms.DockStyle.Top;
            otherTabLayout.Margin = new System.Windows.Forms.Padding(0);
            otherTabLayout.Name = "otherTabLayout";
            otherTabLayout.RowCount = 2;
            otherTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            otherTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            otherTabLayout.TabIndex = 0;
            // 
            // StartupBehaviorGroupBox
            // 
            var sbPanel = new System.Windows.Forms.FlowLayoutPanel();
            sbPanel.SuspendLayout();
            this.StartupBehaviorGroupBox.AutoSize = true;
            this.StartupBehaviorGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartupBehaviorGroupBox.BackColor = System.Drawing.Color.White;
            this.StartupBehaviorGroupBox.Controls.Add(sbPanel);
            this.StartupBehaviorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartupBehaviorGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StartupBehaviorGroupBox.Name = "StartupBehaviorGroupBox";
            this.StartupBehaviorGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.StartupBehaviorGroupBox.TabIndex = 0;
            this.StartupBehaviorGroupBox.TabStop = false;
            this.StartupBehaviorGroupBox.Text = "Startup & Exit Behavior";
            // 
            // sbPanel
            // 
            sbPanel.AutoSize = true;
            sbPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sbPanel.Controls.Add(this.StartWhenOpenedCheckBox);
            sbPanel.Controls.Add(this.MinimizeWhenStartedCheckBox);
            sbPanel.Controls.Add(this.ExitWhenClosedCheckBox);
            sbPanel.Controls.Add(this.StopWhenExitedCheckBox);
            sbPanel.Controls.Add(this.RunAtStartupCheckBox);
            sbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            sbPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            sbPanel.Name = "sbPanel";
            sbPanel.TabIndex = 0;
            sbPanel.WrapContents = false;
            // 
            // StartWhenOpenedCheckBox
            // 
            this.StartWhenOpenedCheckBox.AutoSize = true;
            this.StartWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.StartWhenOpenedCheckBox.Name = "StartWhenOpenedCheckBox";
            this.StartWhenOpenedCheckBox.TabIndex = 0;
            this.StartWhenOpenedCheckBox.Text = "Start when opened";
            this.StartWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimizeWhenStartedCheckBox
            // 
            this.MinimizeWhenStartedCheckBox.AutoSize = true;
            this.MinimizeWhenStartedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.MinimizeWhenStartedCheckBox.Name = "MinimizeWhenStartedCheckBox";
            this.MinimizeWhenStartedCheckBox.TabIndex = 1;
            this.MinimizeWhenStartedCheckBox.Text = "Minimize when started";
            this.MinimizeWhenStartedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitWhenClosedCheckBox
            // 
            this.ExitWhenClosedCheckBox.AutoSize = true;
            this.ExitWhenClosedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.ExitWhenClosedCheckBox.Name = "ExitWhenClosedCheckBox";
            this.ExitWhenClosedCheckBox.TabIndex = 2;
            this.ExitWhenClosedCheckBox.Text = "Exit when closed";
            this.ExitWhenClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopWhenExitedCheckBox
            // 
            this.StopWhenExitedCheckBox.AutoSize = true;
            this.StopWhenExitedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.StopWhenExitedCheckBox.Name = "StopWhenExitedCheckBox";
            this.StopWhenExitedCheckBox.TabIndex = 3;
            this.StopWhenExitedCheckBox.Text = "Stop when exited";
            this.StopWhenExitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunAtStartupCheckBox
            // 
            this.RunAtStartupCheckBox.AutoSize = true;
            this.RunAtStartupCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.RunAtStartupCheckBox.Name = "RunAtStartupCheckBox";
            this.RunAtStartupCheckBox.TabIndex = 4;
            this.RunAtStartupCheckBox.Text = "Run at startup";
            this.RunAtStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateNoticeGroupBox
            // 
            var unPanel = new System.Windows.Forms.FlowLayoutPanel();
            unPanel.SuspendLayout();
            this.UpdateNoticeGroupBox.AutoSize = true;
            this.UpdateNoticeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateNoticeGroupBox.BackColor = System.Drawing.Color.White;
            this.UpdateNoticeGroupBox.Controls.Add(unPanel);
            this.UpdateNoticeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateNoticeGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateNoticeGroupBox.Name = "UpdateNoticeGroupBox";
            this.UpdateNoticeGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.UpdateNoticeGroupBox.TabIndex = 1;
            this.UpdateNoticeGroupBox.TabStop = false;
            this.UpdateNoticeGroupBox.Text = "Updates & Notifications";
            // 
            // unPanel
            // 
            unPanel.AutoSize = true;
            unPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            unPanel.Controls.Add(this.CheckUpdateWhenOpenedCheckBox);
            unPanel.Controls.Add(this.CheckBetaUpdateCheckBox);
            unPanel.Controls.Add(this.NoSupportDialogCheckBox);
            unPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            unPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            unPanel.Name = "unPanel";
            unPanel.TabIndex = 0;
            unPanel.WrapContents = false;
            // 
            // CheckUpdateWhenOpenedCheckBox
            // 
            this.CheckUpdateWhenOpenedCheckBox.AutoSize = true;
            this.CheckUpdateWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.CheckUpdateWhenOpenedCheckBox.Name = "CheckUpdateWhenOpenedCheckBox";
            this.CheckUpdateWhenOpenedCheckBox.TabIndex = 0;
            this.CheckUpdateWhenOpenedCheckBox.Text = "Check update when opened";
            this.CheckUpdateWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBetaUpdateCheckBox
            // 
            this.CheckBetaUpdateCheckBox.AutoSize = true;
            this.CheckBetaUpdateCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.CheckBetaUpdateCheckBox.Name = "CheckBetaUpdateCheckBox";
            this.CheckBetaUpdateCheckBox.TabIndex = 1;
            this.CheckBetaUpdateCheckBox.Text = "Check Beta update";
            this.CheckBetaUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoSupportDialogCheckBox
            // 
            this.NoSupportDialogCheckBox.AutoSize = true;
            this.NoSupportDialogCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.NoSupportDialogCheckBox.Name = "NoSupportDialogCheckBox";
            this.NoSupportDialogCheckBox.TabIndex = 2;
            this.NoSupportDialogCheckBox.Text = "Disable Support Warning";
            this.NoSupportDialogCheckBox.UseVisualStyleBackColor = true;
            // 
            // bottomButtonFlow
            // 
            bottomButtonFlow.AutoSize = true;
            bottomButtonFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bottomButtonFlow.Controls.Add(this.CancelButtonControl);
            bottomButtonFlow.Controls.Add(this.ControlButton);
            bottomButtonFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomButtonFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            bottomButtonFlow.Margin = new System.Windows.Forms.Padding(0);
            bottomButtonFlow.Name = "bottomButtonFlow";
            bottomButtonFlow.TabIndex = 1;
            bottomButtonFlow.WrapContents = false;
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ControlButton.MinimumSize = new System.Drawing.Size(80, 28);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "OK";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.AutoSize = true;
            this.CancelButtonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButtonControl.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButtonControl.MinimumSize = new System.Drawing.Size(80, 28);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CancelButtonControl.TabIndex = 2;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.ControlButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(500, 518);
            this.Controls.Add(rootLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);

            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            bottomButtonFlow.ResumeLayout(false);
            bottomButtonFlow.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            generalTabLayout.ResumeLayout(false);
            generalTabLayout.PerformLayout();
            this.PortGroupBox.ResumeLayout(false);
            this.PortGroupBox.PerformLayout();
            portTable.ResumeLayout(false);
            portTable.PerformLayout();
            pingPanel.ResumeLayout(false);
            pingPanel.PerformLayout();
            this.ProfileGroupBox.ResumeLayout(false);
            this.ProfileGroupBox.PerformLayout();
            profileTable.ResumeLayout(false);
            profileTable.PerformLayout();
            this.NFTabPage.ResumeLayout(false);
            this.NFTabPage.PerformLayout();
            nfTabLayout.ResumeLayout(false);
            nfTabLayout.PerformLayout();
            this.TrafficFilterGroupBox.ResumeLayout(false);
            this.TrafficFilterGroupBox.PerformLayout();
            tfTable.ResumeLayout(false);
            tfTable.PerformLayout();
            icmpDelayPanel.ResumeLayout(false);
            icmpDelayPanel.PerformLayout();
            this.DNSGroupBox.ResumeLayout(false);
            this.DNSGroupBox.PerformLayout();
            dnsTable.ResumeLayout(false);
            dnsTable.PerformLayout();
            dnsHostPanel.ResumeLayout(false);
            dnsHostPanel.PerformLayout();
            this.WinTUNTabPage.ResumeLayout(false);
            this.WinTUNTabPage.PerformLayout();
            tunTabLayout.ResumeLayout(false);
            tunTabLayout.PerformLayout();
            this.WinTUNGroupBox.ResumeLayout(false);
            this.WinTUNGroupBox.PerformLayout();
            tunTable.ResumeLayout(false);
            tunTable.PerformLayout();
            tunDnsCheckPanel.ResumeLayout(false);
            tunDnsCheckPanel.PerformLayout();
            this.OtherTabPage.ResumeLayout(false);
            this.OtherTabPage.PerformLayout();
            otherTabLayout.ResumeLayout(false);
            otherTabLayout.PerformLayout();
            this.StartupBehaviorGroupBox.ResumeLayout(false);
            this.StartupBehaviorGroupBox.PerformLayout();
            sbPanel.ResumeLayout(false);
            sbPanel.PerformLayout();
            this.UpdateNoticeGroupBox.ResumeLayout(false);
            this.UpdateNoticeGroupBox.PerformLayout();
            unPanel.ResumeLayout(false);
            unPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.TabPage NFTabPage;
        private System.Windows.Forms.TabPage WinTUNTabPage;
        private System.Windows.Forms.TabPage OtherTabPage;
        private System.Windows.Forms.GroupBox PortGroupBox;
        private System.Windows.Forms.GroupBox ProfileGroupBox;
        private System.Windows.Forms.Label Socks5PortLabel;
        private System.Windows.Forms.TextBox Socks5PortTextBox;
        private System.Windows.Forms.CheckBox AllowDevicesCheckBox;
        private System.Windows.Forms.Label ServerPingTypeLabel;
        private System.Windows.Forms.RadioButton ICMPingRadioBtn;
        private System.Windows.Forms.RadioButton TCPingRadioBtn;
        private System.Windows.Forms.Label STUNServerLabel;
        private System.Windows.Forms.ComboBox STUN_ServerComboBox;
        private System.Windows.Forms.Label ProfileCountLabel;
        private System.Windows.Forms.TextBox ProfileCountTextBox;
        private System.Windows.Forms.Label DetectionTickLabel;
        private System.Windows.Forms.TextBox DetectionTickTextBox;
        private System.Windows.Forms.Label StartedPingLabel;
        private System.Windows.Forms.TextBox StartedPingIntervalTextBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.GroupBox TrafficFilterGroupBox;
        private System.Windows.Forms.CheckBox FilterTCPCheckBox;
        private System.Windows.Forms.CheckBox FilterUDPCheckBox;
        private System.Windows.Forms.CheckBox FilterICMPCheckBox;
        private System.Windows.Forms.Label ICMPDelayLabel;
        private System.Windows.Forms.TextBox ICMPDelayTextBox;
        private System.Windows.Forms.CheckBox ChildProcessHandleCheckBox;
        private System.Windows.Forms.GroupBox DNSGroupBox;
        private System.Windows.Forms.CheckBox FilterDNSCheckBox;
        private System.Windows.Forms.Label DNSHijackLabel;
        private System.Windows.Forms.TextBox DNSHijackHostTextBox;
        private System.Windows.Forms.CheckBox DNSProxyCheckBox;
        private System.Windows.Forms.CheckBox HandleProcDNSCheckBox;
        private System.Windows.Forms.GroupBox WinTUNGroupBox;
        private System.Windows.Forms.Label TUNTAPAddressLabel;
        private System.Windows.Forms.TextBox TUNTAPAddressTextBox;
        private System.Windows.Forms.Label TUNTAPNetmaskLabel;
        private System.Windows.Forms.TextBox TUNTAPNetmaskTextBox;
        private System.Windows.Forms.Label TUNTAPGatewayLabel;
        private System.Windows.Forms.TextBox TUNTAPGatewayTextBox;
        private System.Windows.Forms.CheckBox UseCustomDNSCheckBox;
        private System.Windows.Forms.CheckBox ProxyDNSCheckBox;
        private System.Windows.Forms.Label TUNTAPDNSLabel;
        private System.Windows.Forms.TextBox TUNTAPDNSTextBox;
        private System.Windows.Forms.Button GlobalBypassIPsButton;
        private System.Windows.Forms.GroupBox StartupBehaviorGroupBox;
        private System.Windows.Forms.CheckBox StartWhenOpenedCheckBox;
        private System.Windows.Forms.CheckBox MinimizeWhenStartedCheckBox;
        private System.Windows.Forms.CheckBox ExitWhenClosedCheckBox;
        private System.Windows.Forms.CheckBox StopWhenExitedCheckBox;
        private System.Windows.Forms.CheckBox RunAtStartupCheckBox;
        private System.Windows.Forms.GroupBox UpdateNoticeGroupBox;
        private System.Windows.Forms.CheckBox CheckUpdateWhenOpenedCheckBox;
        private System.Windows.Forms.CheckBox CheckBetaUpdateCheckBox;
        private System.Windows.Forms.CheckBox NoSupportDialogCheckBox;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox ChinaDNSTextBox;
        private System.Windows.Forms.TextBox OtherDNSTextBox;
        private System.Windows.Forms.TextBox AioDNSListenPortTextBox;
    }
}
