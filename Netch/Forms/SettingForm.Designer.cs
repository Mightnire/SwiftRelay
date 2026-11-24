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
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.GeneralTabPage);
            this.TabControl.Controls.Add(this.NFTabPage);
            this.TabControl.Controls.Add(this.WinTUNTabPage);
            this.TabControl.Controls.Add(this.OtherTabPage);
            this.TabControl.ItemSize = new System.Drawing.Size(95, 26);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(12, 4);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(476, 452);
            this.TabControl.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.AutoScroll = true;
            this.GeneralTabPage.BackColor = System.Drawing.Color.White;
            this.GeneralTabPage.Controls.Add(this.PortGroupBox);
            this.GeneralTabPage.Controls.Add(this.ProfileGroupBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 30);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.GeneralTabPage.Size = new System.Drawing.Size(468, 418);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "General";
            // 
            // PortGroupBox
            // 
            var portTable = new System.Windows.Forms.TableLayoutPanel();
            portTable.SuspendLayout();
            this.PortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortGroupBox.BackColor = System.Drawing.Color.White;
            this.PortGroupBox.Controls.Add(portTable);
            this.PortGroupBox.Location = new System.Drawing.Point(12, 10);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.PortGroupBox.Size = new System.Drawing.Size(444, 142);
            this.PortGroupBox.TabIndex = 0;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Local Listener & Testing";
            // 
            // portTable
            // 
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
            pingPanel.Margin = new System.Windows.Forms.Padding(0);
            pingPanel.Controls.Add(this.ICMPingRadioBtn);
            pingPanel.Controls.Add(this.TCPingRadioBtn);
            portTable.Controls.Add(pingPanel, 1, 1);
            portTable.SetColumnSpan(pingPanel, 2);
            portTable.Controls.Add(this.STUNServerLabel, 0, 2);
            portTable.Controls.Add(this.STUN_ServerComboBox, 1, 2);
            portTable.SetColumnSpan(this.STUN_ServerComboBox, 2);
            portTable.Dock = System.Windows.Forms.DockStyle.Fill;
            portTable.Location = new System.Drawing.Point(10, 24);
            portTable.Name = "portTable";
            portTable.RowCount = 3;
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            portTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            portTable.Size = new System.Drawing.Size(424, 108);
            portTable.TabIndex = 0;
            // 
            // Socks5PortLabel
            // 
            this.Socks5PortLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Socks5PortLabel.AutoSize = true;
            this.Socks5PortLabel.Location = new System.Drawing.Point(0, 9);
            this.Socks5PortLabel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Socks5PortLabel.Name = "Socks5PortLabel";
            this.Socks5PortLabel.Size = new System.Drawing.Size(49, 17);
            this.Socks5PortLabel.TabIndex = 0;
            this.Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            this.Socks5PortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Socks5PortTextBox.Location = new System.Drawing.Point(57, 6);
            this.Socks5PortTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Socks5PortTextBox.Name = "Socks5PortTextBox";
            this.Socks5PortTextBox.Size = new System.Drawing.Size(80, 23);
            this.Socks5PortTextBox.TabIndex = 1;
            this.Socks5PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllowDevicesCheckBox
            // 
            this.AllowDevicesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AllowDevicesCheckBox.AutoSize = true;
            this.AllowDevicesCheckBox.Location = new System.Drawing.Point(157, 7);
            this.AllowDevicesCheckBox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            this.AllowDevicesCheckBox.Size = new System.Drawing.Size(168, 21);
            this.AllowDevicesCheckBox.TabIndex = 2;
            this.AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            this.AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServerPingTypeLabel
            // 
            this.ServerPingTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerPingTypeLabel.AutoSize = true;
            this.ServerPingTypeLabel.Location = new System.Drawing.Point(0, 44);
            this.ServerPingTypeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ServerPingTypeLabel.Name = "ServerPingTypeLabel";
            this.ServerPingTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.ServerPingTypeLabel.TabIndex = 3;
            this.ServerPingTypeLabel.Text = "Latency Protocol";
            // 
            // ICMPingRadioBtn
            // 
            this.ICMPingRadioBtn.AutoSize = true;
            this.ICMPingRadioBtn.Location = new System.Drawing.Point(0, 3);
            this.ICMPingRadioBtn.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.ICMPingRadioBtn.Name = "ICMPingRadioBtn";
            this.ICMPingRadioBtn.Size = new System.Drawing.Size(68, 21);
            this.ICMPingRadioBtn.TabIndex = 4;
            this.ICMPingRadioBtn.TabStop = true;
            this.ICMPingRadioBtn.Text = "ICMPing";
            this.ICMPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TCPingRadioBtn
            // 
            this.TCPingRadioBtn.AutoSize = true;
            this.TCPingRadioBtn.Location = new System.Drawing.Point(83, 3);
            this.TCPingRadioBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TCPingRadioBtn.Name = "TCPingRadioBtn";
            this.TCPingRadioBtn.Size = new System.Drawing.Size(60, 21);
            this.TCPingRadioBtn.TabIndex = 5;
            this.TCPingRadioBtn.TabStop = true;
            this.TCPingRadioBtn.Text = "TCPing";
            this.TCPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // STUNServerLabel
            // 
            this.STUNServerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.STUNServerLabel.AutoSize = true;
            this.STUNServerLabel.Location = new System.Drawing.Point(0, 78);
            this.STUNServerLabel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.STUNServerLabel.Name = "STUNServerLabel";
            this.STUNServerLabel.Size = new System.Drawing.Size(42, 17);
            this.STUNServerLabel.TabIndex = 6;
            this.STUNServerLabel.Text = "STUN";
            // 
            // STUN_ServerComboBox
            // 
            this.STUN_ServerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STUN_ServerComboBox.FormattingEnabled = true;
            this.STUN_ServerComboBox.Location = new System.Drawing.Point(57, 73);
            this.STUN_ServerComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.STUN_ServerComboBox.Name = "STUN_ServerComboBox";
            this.STUN_ServerComboBox.Size = new System.Drawing.Size(357, 25);
            this.STUN_ServerComboBox.TabIndex = 7;
            // 
            // ProfileGroupBox
            // 
            var profileTable = new System.Windows.Forms.TableLayoutPanel();
            profileTable.SuspendLayout();
            this.ProfileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileGroupBox.BackColor = System.Drawing.Color.White;
            this.ProfileGroupBox.Controls.Add(profileTable);
            this.ProfileGroupBox.Location = new System.Drawing.Point(12, 162);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.ProfileGroupBox.Size = new System.Drawing.Size(444, 182);
            this.ProfileGroupBox.TabIndex = 1;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles & Timing";
            // 
            // profileTable
            // 
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
            profileTable.Location = new System.Drawing.Point(10, 24);
            profileTable.Name = "profileTable";
            profileTable.RowCount = 4;
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            profileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            profileTable.Size = new System.Drawing.Size(424, 148);
            profileTable.TabIndex = 0;
            // 
            // ProfileCountLabel
            // 
            this.ProfileCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfileCountLabel.AutoSize = true;
            this.ProfileCountLabel.Location = new System.Drawing.Point(0, 8);
            this.ProfileCountLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.ProfileCountLabel.Name = "ProfileCountLabel";
            this.ProfileCountLabel.Size = new System.Drawing.Size(83, 17);
            this.ProfileCountLabel.TabIndex = 0;
            this.ProfileCountLabel.Text = "Profile Count";
            // 
            // ProfileCountTextBox
            // 
            this.ProfileCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfileCountTextBox.Location = new System.Drawing.Point(150, 5);
            this.ProfileCountTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ProfileCountTextBox.Name = "ProfileCountTextBox";
            this.ProfileCountTextBox.Size = new System.Drawing.Size(80, 23);
            this.ProfileCountTextBox.TabIndex = 1;
            this.ProfileCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetectionTickLabel
            // 
            this.DetectionTickLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DetectionTickLabel.AutoSize = true;
            this.DetectionTickLabel.Location = new System.Drawing.Point(0, 42);
            this.DetectionTickLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.DetectionTickLabel.Name = "DetectionTickLabel";
            this.DetectionTickLabel.Size = new System.Drawing.Size(120, 17);
            this.DetectionTickLabel.TabIndex = 2;
            this.DetectionTickLabel.Text = "Detection Tick(sec)";
            // 
            // DetectionTickTextBox
            // 
            this.DetectionTickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DetectionTickTextBox.Location = new System.Drawing.Point(150, 39);
            this.DetectionTickTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DetectionTickTextBox.Name = "DetectionTickTextBox";
            this.DetectionTickTextBox.Size = new System.Drawing.Size(80, 23);
            this.DetectionTickTextBox.TabIndex = 3;
            this.DetectionTickTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartedPingLabel
            // 
            this.StartedPingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartedPingLabel.AutoSize = true;
            this.StartedPingLabel.Location = new System.Drawing.Point(0, 76);
            this.StartedPingLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.StartedPingLabel.Name = "StartedPingLabel";
            this.StartedPingLabel.Size = new System.Drawing.Size(149, 17);
            this.StartedPingLabel.TabIndex = 4;
            this.StartedPingLabel.Text = "Delay test after start(sec)";
            // 
            // StartedPingIntervalTextBox
            // 
            this.StartedPingIntervalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartedPingIntervalTextBox.Location = new System.Drawing.Point(150, 73);
            this.StartedPingIntervalTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.StartedPingIntervalTextBox.Name = "StartedPingIntervalTextBox";
            this.StartedPingIntervalTextBox.Size = new System.Drawing.Size(80, 23);
            this.StartedPingIntervalTextBox.TabIndex = 5;
            this.StartedPingIntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(0, 111);
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(65, 17);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(150, 107);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(130, 25);
            this.LanguageComboBox.TabIndex = 7;
            // 
            // NFTabPage
            // 
            this.NFTabPage.AutoScroll = true;
            this.NFTabPage.BackColor = System.Drawing.Color.White;
            this.NFTabPage.Controls.Add(this.TrafficFilterGroupBox);
            this.NFTabPage.Controls.Add(this.DNSGroupBox);
            this.NFTabPage.Location = new System.Drawing.Point(4, 30);
            this.NFTabPage.Name = "NFTabPage";
            this.NFTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.NFTabPage.Size = new System.Drawing.Size(468, 418);
            this.NFTabPage.TabIndex = 1;
            this.NFTabPage.Text = "Process Mode";
            // 
            // TrafficFilterGroupBox
            // 
            var tfTable = new System.Windows.Forms.TableLayoutPanel();
            tfTable.SuspendLayout();
            this.TrafficFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficFilterGroupBox.BackColor = System.Drawing.Color.White;
            this.TrafficFilterGroupBox.Controls.Add(tfTable);
            this.TrafficFilterGroupBox.Location = new System.Drawing.Point(12, 10);
            this.TrafficFilterGroupBox.Name = "TrafficFilterGroupBox";
            this.TrafficFilterGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.TrafficFilterGroupBox.Size = new System.Drawing.Size(444, 160);
            this.TrafficFilterGroupBox.TabIndex = 0;
            this.TrafficFilterGroupBox.TabStop = false;
            this.TrafficFilterGroupBox.Text = "Protocol Filtering";
            // 
            // tfTable
            // 
            tfTable.ColumnCount = 2;
            tfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tfTable.Controls.Add(this.FilterTCPCheckBox, 0, 0);
            tfTable.Controls.Add(this.ChildProcessHandleCheckBox, 1, 0);
            tfTable.Controls.Add(this.FilterUDPCheckBox, 0, 1);
            tfTable.Controls.Add(this.FilterICMPCheckBox, 0, 2);
            var icmpDelayPanel = new System.Windows.Forms.FlowLayoutPanel();
            icmpDelayPanel.AutoSize = true;
            icmpDelayPanel.Margin = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.ICMPDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICMPDelayLabel.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(65, 23);
            icmpDelayPanel.Controls.Add(this.ICMPDelayLabel);
            icmpDelayPanel.Controls.Add(this.ICMPDelayTextBox);
            tfTable.Controls.Add(icmpDelayPanel, 0, 3);
            tfTable.SetColumnSpan(icmpDelayPanel, 2);
            tfTable.Dock = System.Windows.Forms.DockStyle.Fill;
            tfTable.Location = new System.Drawing.Point(10, 24);
            tfTable.Name = "tfTable";
            tfTable.RowCount = 4;
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tfTable.Size = new System.Drawing.Size(424, 126);
            tfTable.TabIndex = 0;
            // 
            // FilterTCPCheckBox
            // 
            this.FilterTCPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterTCPCheckBox.AutoSize = true;
            this.FilterTCPCheckBox.Location = new System.Drawing.Point(3, 4);
            this.FilterTCPCheckBox.Name = "FilterTCPCheckBox";
            this.FilterTCPCheckBox.Size = new System.Drawing.Size(95, 21);
            this.FilterTCPCheckBox.TabIndex = 0;
            this.FilterTCPCheckBox.Text = "Handle TCP";
            this.FilterTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterUDPCheckBox
            // 
            this.FilterUDPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterUDPCheckBox.AutoSize = true;
            this.FilterUDPCheckBox.Location = new System.Drawing.Point(3, 34);
            this.FilterUDPCheckBox.Name = "FilterUDPCheckBox";
            this.FilterUDPCheckBox.Size = new System.Drawing.Size(98, 21);
            this.FilterUDPCheckBox.TabIndex = 1;
            this.FilterUDPCheckBox.Text = "Handle UDP";
            this.FilterUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterICMPCheckBox
            // 
            this.FilterICMPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterICMPCheckBox.AutoSize = true;
            this.FilterICMPCheckBox.Location = new System.Drawing.Point(3, 64);
            this.FilterICMPCheckBox.Name = "FilterICMPCheckBox";
            this.FilterICMPCheckBox.Size = new System.Drawing.Size(102, 21);
            this.FilterICMPCheckBox.TabIndex = 2;
            this.FilterICMPCheckBox.Text = "Handle ICMP";
            this.FilterICMPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ICMPDelayLabel
            // 
            this.ICMPDelayLabel.AutoSize = true;
            this.ICMPDelayLabel.Location = new System.Drawing.Point(0, 6);
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.Size = new System.Drawing.Size(97, 17);
            this.ICMPDelayLabel.TabIndex = 3;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterICMPCheckBox, "Checked", true));
            this.ICMPDelayTextBox.Location = new System.Drawing.Point(103, 3);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(65, 23);
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChildProcessHandleCheckBox
            // 
            this.ChildProcessHandleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChildProcessHandleCheckBox.AutoSize = true;
            this.ChildProcessHandleCheckBox.Location = new System.Drawing.Point(215, 4);
            this.ChildProcessHandleCheckBox.Name = "ChildProcessHandleCheckBox";
            this.ChildProcessHandleCheckBox.Size = new System.Drawing.Size(103, 21);
            this.ChildProcessHandleCheckBox.TabIndex = 5;
            this.ChildProcessHandleCheckBox.Text = "Child Process";
            this.ChildProcessHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSGroupBox
            // 
            var dnsTable = new System.Windows.Forms.TableLayoutPanel();
            dnsTable.SuspendLayout();
            this.DNSGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DNSGroupBox.BackColor = System.Drawing.Color.White;
            this.DNSGroupBox.Controls.Add(dnsTable);
            this.DNSGroupBox.Location = new System.Drawing.Point(12, 180);
            this.DNSGroupBox.Name = "DNSGroupBox";
            this.DNSGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.DNSGroupBox.Size = new System.Drawing.Size(444, 160);
            this.DNSGroupBox.TabIndex = 1;
            this.DNSGroupBox.TabStop = false;
            this.DNSGroupBox.Text = "DNS";
            // 
            // dnsTable
            // 
            dnsTable.ColumnCount = 1;
            dnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            dnsTable.Controls.Add(this.FilterDNSCheckBox, 0, 0);
            var dnsHostPanel = new System.Windows.Forms.FlowLayoutPanel();
            dnsHostPanel.AutoSize = true;
            dnsHostPanel.Margin = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.DNSHijackLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSHijackLabel.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.DNSHijackHostTextBox.Size = new System.Drawing.Size(220, 23);
            dnsHostPanel.Controls.Add(this.DNSHijackLabel);
            dnsHostPanel.Controls.Add(this.DNSHijackHostTextBox);
            dnsTable.Controls.Add(dnsHostPanel, 0, 1);
            dnsTable.Controls.Add(this.DNSProxyCheckBox, 0, 2);
            dnsTable.Controls.Add(this.HandleProcDNSCheckBox, 0, 3);
            dnsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            dnsTable.Location = new System.Drawing.Point(10, 24);
            dnsTable.Name = "dnsTable";
            dnsTable.RowCount = 4;
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            dnsTable.Size = new System.Drawing.Size(424, 126);
            dnsTable.TabIndex = 0;
            // 
            // FilterDNSCheckBox
            // 
            this.FilterDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilterDNSCheckBox.AutoSize = true;
            this.FilterDNSCheckBox.Location = new System.Drawing.Point(3, 4);
            this.FilterDNSCheckBox.Name = "FilterDNSCheckBox";
            this.FilterDNSCheckBox.Size = new System.Drawing.Size(189, 21);
            this.FilterDNSCheckBox.TabIndex = 0;
            this.FilterDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.FilterDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSHijackLabel
            // 
            this.DNSHijackLabel.AutoSize = true;
            this.DNSHijackLabel.Location = new System.Drawing.Point(0, 6);
            this.DNSHijackLabel.Name = "DNSHijackLabel";
            this.DNSHijackLabel.Size = new System.Drawing.Size(34, 17);
            this.DNSHijackLabel.TabIndex = 1;
            this.DNSHijackLabel.Text = "DNS";
            // 
            // DNSHijackHostTextBox
            // 
            this.DNSHijackHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSHijackHostTextBox.Location = new System.Drawing.Point(40, 3);
            this.DNSHijackHostTextBox.Name = "DNSHijackHostTextBox";
            this.DNSHijackHostTextBox.Size = new System.Drawing.Size(220, 23);
            this.DNSHijackHostTextBox.TabIndex = 2;
            this.DNSHijackHostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DNSProxyCheckBox
            // 
            this.DNSProxyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSProxyCheckBox.AutoSize = true;
            this.DNSProxyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSProxyCheckBox.Location = new System.Drawing.Point(3, 68);
            this.DNSProxyCheckBox.Name = "DNSProxyCheckBox";
            this.DNSProxyCheckBox.Size = new System.Drawing.Size(180, 21);
            this.DNSProxyCheckBox.TabIndex = 3;
            this.DNSProxyCheckBox.Text = "Handle DNS through proxy";
            this.DNSProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.HandleProcDNSCheckBox.Location = new System.Drawing.Point(3, 99);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.Size = new System.Drawing.Size(206, 21);
            this.HandleProcDNSCheckBox.TabIndex = 4;
            this.HandleProcDNSCheckBox.Text = "Handle handled process\'s DNS";
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // WinTUNTabPage
            // 
            this.WinTUNTabPage.AutoScroll = true;
            this.WinTUNTabPage.BackColor = System.Drawing.Color.White;
            this.WinTUNTabPage.Controls.Add(this.WinTUNGroupBox);
            this.WinTUNTabPage.Controls.Add(this.GlobalBypassIPsButton);
            this.WinTUNTabPage.Location = new System.Drawing.Point(4, 30);
            this.WinTUNTabPage.Name = "WinTUNTabPage";
            this.WinTUNTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.WinTUNTabPage.Size = new System.Drawing.Size(468, 418);
            this.WinTUNTabPage.TabIndex = 2;
            this.WinTUNTabPage.Text = "WinTUN";
            // 
            // WinTUNGroupBox
            // 
            var tunTable = new System.Windows.Forms.TableLayoutPanel();
            tunTable.SuspendLayout();
            this.WinTUNGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinTUNGroupBox.BackColor = System.Drawing.Color.White;
            this.WinTUNGroupBox.Controls.Add(tunTable);
            this.WinTUNGroupBox.Location = new System.Drawing.Point(12, 10);
            this.WinTUNGroupBox.Name = "WinTUNGroupBox";
            this.WinTUNGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.WinTUNGroupBox.Size = new System.Drawing.Size(444, 210);
            this.WinTUNGroupBox.TabIndex = 0;
            this.WinTUNGroupBox.TabStop = false;
            this.WinTUNGroupBox.Text = "Network Settings";
            // 
            // tunTable
            // 
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
            tunDnsCheckPanel.Margin = new System.Windows.Forms.Padding(0);
            tunDnsCheckPanel.Controls.Add(this.UseCustomDNSCheckBox);
            tunDnsCheckPanel.Controls.Add(this.ProxyDNSCheckBox);
            tunTable.Controls.Add(tunDnsCheckPanel, 0, 3);
            tunTable.SetColumnSpan(tunDnsCheckPanel, 2);
            tunTable.Controls.Add(this.TUNTAPDNSLabel, 0, 4);
            tunTable.Controls.Add(this.TUNTAPDNSTextBox, 1, 4);
            tunTable.Dock = System.Windows.Forms.DockStyle.Fill;
            tunTable.Location = new System.Drawing.Point(10, 24);
            tunTable.Name = "tunTable";
            tunTable.RowCount = 5;
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tunTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tunTable.Size = new System.Drawing.Size(424, 176);
            tunTable.TabIndex = 0;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(0, 8);
            this.TUNTAPAddressLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(56, 17);
            this.TUNTAPAddressLabel.TabIndex = 0;
            this.TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(70, 5);
            this.TUNTAPAddressTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(344, 23);
            this.TUNTAPAddressTextBox.TabIndex = 1;
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Location = new System.Drawing.Point(0, 42);
            this.TUNTAPNetmaskLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.Size = new System.Drawing.Size(60, 17);
            this.TUNTAPNetmaskLabel.TabIndex = 2;
            this.TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPNetmaskTextBox.Location = new System.Drawing.Point(70, 39);
            this.TUNTAPNetmaskTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.Size = new System.Drawing.Size(344, 23);
            this.TUNTAPNetmaskTextBox.TabIndex = 3;
            this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(0, 76);
            this.TUNTAPGatewayLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(57, 17);
            this.TUNTAPGatewayLabel.TabIndex = 4;
            this.TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(70, 73);
            this.TUNTAPGatewayTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(344, 23);
            this.TUNTAPGatewayTextBox.TabIndex = 5;
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UseCustomDNSCheckBox
            // 
            this.UseCustomDNSCheckBox.AutoSize = true;
            this.UseCustomDNSCheckBox.Location = new System.Drawing.Point(0, 6);
            this.UseCustomDNSCheckBox.Margin = new System.Windows.Forms.Padding(0, 6, 15, 6);
            this.UseCustomDNSCheckBox.Name = "UseCustomDNSCheckBox";
            this.UseCustomDNSCheckBox.Size = new System.Drawing.Size(126, 21);
            this.UseCustomDNSCheckBox.TabIndex = 6;
            this.UseCustomDNSCheckBox.Text = "Use custom DNS";
            this.UseCustomDNSCheckBox.UseVisualStyleBackColor = true;
            this.UseCustomDNSCheckBox.Click += new System.EventHandler(this.TUNTAPUseCustomDNSCheckBox_CheckedChanged);
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(141, 6);
            this.ProxyDNSCheckBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(87, 21);
            this.ProxyDNSCheckBox.TabIndex = 7;
            this.ProxyDNSCheckBox.Text = "Proxy DNS";
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(0, 111);
            this.TUNTAPDNSLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(34, 17);
            this.TUNTAPDNSLabel.TabIndex = 8;
            this.TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TUNTAPDNSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.UseCustomDNSCheckBox, "Checked", true));
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(70, 107);
            this.TUNTAPDNSTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(344, 23);
            this.TUNTAPDNSTextBox.TabIndex = 9;
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GlobalBypassIPsButton
            // 
            this.GlobalBypassIPsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GlobalBypassIPsButton.Location = new System.Drawing.Point(12, 230);
            this.GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            this.GlobalBypassIPsButton.Size = new System.Drawing.Size(444, 30);
            this.GlobalBypassIPsButton.TabIndex = 1;
            this.GlobalBypassIPsButton.Text = "Global Bypass IPs";
            this.GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            this.GlobalBypassIPsButton.Click += new System.EventHandler(this.GlobalBypassIPsButton_Click);
            // 
            // OtherTabPage
            // 
            this.OtherTabPage.AutoScroll = true;
            this.OtherTabPage.BackColor = System.Drawing.Color.White;
            this.OtherTabPage.Controls.Add(this.StartupBehaviorGroupBox);
            this.OtherTabPage.Controls.Add(this.UpdateNoticeGroupBox);
            this.OtherTabPage.Location = new System.Drawing.Point(4, 30);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.OtherTabPage.Size = new System.Drawing.Size(468, 418);
            this.OtherTabPage.TabIndex = 3;
            this.OtherTabPage.Text = "Other";
            // 
            // StartupBehaviorGroupBox
            // 
            var sbPanel = new System.Windows.Forms.FlowLayoutPanel();
            sbPanel.SuspendLayout();
            this.StartupBehaviorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartupBehaviorGroupBox.BackColor = System.Drawing.Color.White;
            this.StartupBehaviorGroupBox.Controls.Add(sbPanel);
            this.StartupBehaviorGroupBox.Location = new System.Drawing.Point(12, 10);
            this.StartupBehaviorGroupBox.Name = "StartupBehaviorGroupBox";
            this.StartupBehaviorGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.StartupBehaviorGroupBox.Size = new System.Drawing.Size(444, 180);
            this.StartupBehaviorGroupBox.TabIndex = 0;
            this.StartupBehaviorGroupBox.TabStop = false;
            this.StartupBehaviorGroupBox.Text = "Startup Behavior";
            // 
            // sbPanel
            // 
            sbPanel.Controls.Add(this.StartWhenOpenedCheckBox);
            sbPanel.Controls.Add(this.MinimizeWhenStartedCheckBox);
            sbPanel.Controls.Add(this.ExitWhenClosedCheckBox);
            sbPanel.Controls.Add(this.StopWhenExitedCheckBox);
            sbPanel.Controls.Add(this.RunAtStartupCheckBox);
            sbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            sbPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            sbPanel.Location = new System.Drawing.Point(10, 24);
            sbPanel.Name = "sbPanel";
            sbPanel.Size = new System.Drawing.Size(424, 146);
            sbPanel.TabIndex = 0;
            sbPanel.WrapContents = false;
            // 
            // StartWhenOpenedCheckBox
            // 
            this.StartWhenOpenedCheckBox.AutoSize = true;
            this.StartWhenOpenedCheckBox.Location = new System.Drawing.Point(6, 4);
            this.StartWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.StartWhenOpenedCheckBox.Name = "StartWhenOpenedCheckBox";
            this.StartWhenOpenedCheckBox.Size = new System.Drawing.Size(141, 21);
            this.StartWhenOpenedCheckBox.TabIndex = 0;
            this.StartWhenOpenedCheckBox.Text = "Start when opened";
            this.StartWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimizeWhenStartedCheckBox
            // 
            this.MinimizeWhenStartedCheckBox.AutoSize = true;
            this.MinimizeWhenStartedCheckBox.Location = new System.Drawing.Point(6, 33);
            this.MinimizeWhenStartedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.MinimizeWhenStartedCheckBox.Name = "MinimizeWhenStartedCheckBox";
            this.MinimizeWhenStartedCheckBox.Size = new System.Drawing.Size(161, 21);
            this.MinimizeWhenStartedCheckBox.TabIndex = 1;
            this.MinimizeWhenStartedCheckBox.Text = "Minimize when started";
            this.MinimizeWhenStartedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitWhenClosedCheckBox
            // 
            this.ExitWhenClosedCheckBox.AutoSize = true;
            this.ExitWhenClosedCheckBox.Location = new System.Drawing.Point(6, 62);
            this.ExitWhenClosedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.ExitWhenClosedCheckBox.Name = "ExitWhenClosedCheckBox";
            this.ExitWhenClosedCheckBox.Size = new System.Drawing.Size(125, 21);
            this.ExitWhenClosedCheckBox.TabIndex = 2;
            this.ExitWhenClosedCheckBox.Text = "Exit when closed";
            this.ExitWhenClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopWhenExitedCheckBox
            // 
            this.StopWhenExitedCheckBox.AutoSize = true;
            this.StopWhenExitedCheckBox.Location = new System.Drawing.Point(6, 91);
            this.StopWhenExitedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.StopWhenExitedCheckBox.Name = "StopWhenExitedCheckBox";
            this.StopWhenExitedCheckBox.Size = new System.Drawing.Size(129, 21);
            this.StopWhenExitedCheckBox.TabIndex = 3;
            this.StopWhenExitedCheckBox.Text = "Stop when exited";
            this.StopWhenExitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunAtStartupCheckBox
            // 
            this.RunAtStartupCheckBox.AutoSize = true;
            this.RunAtStartupCheckBox.Location = new System.Drawing.Point(6, 120);
            this.RunAtStartupCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.RunAtStartupCheckBox.Name = "RunAtStartupCheckBox";
            this.RunAtStartupCheckBox.Size = new System.Drawing.Size(110, 21);
            this.RunAtStartupCheckBox.TabIndex = 4;
            this.RunAtStartupCheckBox.Text = "Run at startup";
            this.RunAtStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateNoticeGroupBox
            // 
            var unPanel = new System.Windows.Forms.FlowLayoutPanel();
            unPanel.SuspendLayout();
            this.UpdateNoticeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateNoticeGroupBox.BackColor = System.Drawing.Color.White;
            this.UpdateNoticeGroupBox.Controls.Add(unPanel);
            this.UpdateNoticeGroupBox.Location = new System.Drawing.Point(12, 200);
            this.UpdateNoticeGroupBox.Name = "UpdateNoticeGroupBox";
            this.UpdateNoticeGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.UpdateNoticeGroupBox.Size = new System.Drawing.Size(444, 130);
            this.UpdateNoticeGroupBox.TabIndex = 1;
            this.UpdateNoticeGroupBox.TabStop = false;
            this.UpdateNoticeGroupBox.Text = "Updates & Notifications";
            // 
            // unPanel
            // 
            unPanel.Controls.Add(this.CheckUpdateWhenOpenedCheckBox);
            unPanel.Controls.Add(this.CheckBetaUpdateCheckBox);
            unPanel.Controls.Add(this.NoSupportDialogCheckBox);
            unPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            unPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            unPanel.Location = new System.Drawing.Point(10, 24);
            unPanel.Name = "unPanel";
            unPanel.Size = new System.Drawing.Size(424, 96);
            unPanel.TabIndex = 0;
            unPanel.WrapContents = false;
            // 
            // CheckUpdateWhenOpenedCheckBox
            // 
            this.CheckUpdateWhenOpenedCheckBox.AutoSize = true;
            this.CheckUpdateWhenOpenedCheckBox.Location = new System.Drawing.Point(6, 4);
            this.CheckUpdateWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.CheckUpdateWhenOpenedCheckBox.Name = "CheckUpdateWhenOpenedCheckBox";
            this.CheckUpdateWhenOpenedCheckBox.Size = new System.Drawing.Size(187, 21);
            this.CheckUpdateWhenOpenedCheckBox.TabIndex = 0;
            this.CheckUpdateWhenOpenedCheckBox.Text = "Check update when opened";
            this.CheckUpdateWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBetaUpdateCheckBox
            // 
            this.CheckBetaUpdateCheckBox.AutoSize = true;
            this.CheckBetaUpdateCheckBox.Location = new System.Drawing.Point(6, 33);
            this.CheckBetaUpdateCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.CheckBetaUpdateCheckBox.Name = "CheckBetaUpdateCheckBox";
            this.CheckBetaUpdateCheckBox.Size = new System.Drawing.Size(136, 21);
            this.CheckBetaUpdateCheckBox.TabIndex = 1;
            this.CheckBetaUpdateCheckBox.Text = "Check Beta update";
            this.CheckBetaUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoSupportDialogCheckBox
            // 
            this.NoSupportDialogCheckBox.AutoSize = true;
            this.NoSupportDialogCheckBox.Location = new System.Drawing.Point(6, 62);
            this.NoSupportDialogCheckBox.Margin = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.NoSupportDialogCheckBox.Name = "NoSupportDialogCheckBox";
            this.NoSupportDialogCheckBox.Size = new System.Drawing.Size(169, 21);
            this.NoSupportDialogCheckBox.TabIndex = 2;
            this.NoSupportDialogCheckBox.Text = "Disable Support Warning";
            this.NoSupportDialogCheckBox.UseVisualStyleBackColor = true;
            // 
            // ControlButton
            // 
            this.ControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlButton.Location = new System.Drawing.Point(322, 478);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(80, 28);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "OK";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButtonControl.Location = new System.Drawing.Point(408, 478);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(80, 28);
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
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.TabControl.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.PortGroupBox.ResumeLayout(false);
            portTable.ResumeLayout(false);
            portTable.PerformLayout();
            pingPanel.ResumeLayout(false);
            pingPanel.PerformLayout();
            this.ProfileGroupBox.ResumeLayout(false);
            profileTable.ResumeLayout(false);
            profileTable.PerformLayout();
            this.NFTabPage.ResumeLayout(false);
            this.TrafficFilterGroupBox.ResumeLayout(false);
            tfTable.ResumeLayout(false);
            tfTable.PerformLayout();
            icmpDelayPanel.ResumeLayout(false);
            icmpDelayPanel.PerformLayout();
            this.DNSGroupBox.ResumeLayout(false);
            dnsTable.ResumeLayout(false);
            dnsTable.PerformLayout();
            dnsHostPanel.ResumeLayout(false);
            dnsHostPanel.PerformLayout();
            this.WinTUNTabPage.ResumeLayout(false);
            this.WinTUNGroupBox.ResumeLayout(false);
            tunTable.ResumeLayout(false);
            tunTable.PerformLayout();
            tunDnsCheckPanel.ResumeLayout(false);
            tunDnsCheckPanel.PerformLayout();
            this.OtherTabPage.ResumeLayout(false);
            this.StartupBehaviorGroupBox.ResumeLayout(false);
            sbPanel.ResumeLayout(false);
            sbPanel.PerformLayout();
            this.UpdateNoticeGroupBox.ResumeLayout(false);
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
