using System.ComponentModel;

namespace Netch.Forms
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.TabControl.Controls.Add(this.GeneralTabPage);
            this.TabControl.Controls.Add(this.NFTabPage);
            this.TabControl.Controls.Add(this.WinTUNTabPage);
            this.TabControl.Controls.Add(this.OtherTabPage);
            this.TabControl.ItemSize = new System.Drawing.Size(70, 24);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(12, 4);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(436, 360);
            this.TabControl.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.BackColor = System.Drawing.Color.White;
            this.GeneralTabPage.Controls.Add(this.PortGroupBox);
            this.GeneralTabPage.Controls.Add(this.ProfileGroupBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 28);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.GeneralTabPage.Size = new System.Drawing.Size(428, 328);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "General";
            // 
            // PortGroupBox
            // 
            this.PortGroupBox.BackColor = System.Drawing.Color.White;
            this.PortGroupBox.Controls.Add(this.Socks5PortLabel);
            this.PortGroupBox.Controls.Add(this.Socks5PortTextBox);
            this.PortGroupBox.Controls.Add(this.AllowDevicesCheckBox);
            this.PortGroupBox.Controls.Add(this.ServerPingTypeLabel);
            this.PortGroupBox.Controls.Add(this.ICMPingRadioBtn);
            this.PortGroupBox.Controls.Add(this.TCPingRadioBtn);
            this.PortGroupBox.Controls.Add(this.STUNServerLabel);
            this.PortGroupBox.Controls.Add(this.STUN_ServerComboBox);
            this.PortGroupBox.Location = new System.Drawing.Point(10, 8);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Size = new System.Drawing.Size(408, 125);
            this.PortGroupBox.TabIndex = 0;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Local Listener & Testing";
            // 
            // Socks5PortLabel
            // 
            this.Socks5PortLabel.AutoSize = true;
            this.Socks5PortLabel.Location = new System.Drawing.Point(16, 26);
            this.Socks5PortLabel.Name = "Socks5PortLabel";
            this.Socks5PortLabel.Size = new System.Drawing.Size(49, 17);
            this.Socks5PortLabel.TabIndex = 0;
            this.Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            this.Socks5PortTextBox.Location = new System.Drawing.Point(130, 22);
            this.Socks5PortTextBox.Name = "Socks5PortTextBox";
            this.Socks5PortTextBox.Size = new System.Drawing.Size(80, 23);
            this.Socks5PortTextBox.TabIndex = 1;
            this.Socks5PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllowDevicesCheckBox
            // 
            this.AllowDevicesCheckBox.AutoSize = true;
            this.AllowDevicesCheckBox.Location = new System.Drawing.Point(230, 24);
            this.AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            this.AllowDevicesCheckBox.Size = new System.Drawing.Size(168, 21);
            this.AllowDevicesCheckBox.TabIndex = 2;
            this.AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            this.AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServerPingTypeLabel
            // 
            this.ServerPingTypeLabel.AutoSize = true;
            this.ServerPingTypeLabel.Location = new System.Drawing.Point(16, 58);
            this.ServerPingTypeLabel.Name = "ServerPingTypeLabel";
            this.ServerPingTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.ServerPingTypeLabel.TabIndex = 3;
            this.ServerPingTypeLabel.Text = "Ping Protocol";
            // 
            // ICMPingRadioBtn
            // 
            this.ICMPingRadioBtn.AutoSize = true;
            this.ICMPingRadioBtn.Location = new System.Drawing.Point(130, 57);
            this.ICMPingRadioBtn.Name = "ICMPingRadioBtn";
            this.ICMPingRadioBtn.Size = new System.Drawing.Size(75, 21);
            this.ICMPingRadioBtn.TabIndex = 4;
            this.ICMPingRadioBtn.TabStop = true;
            this.ICMPingRadioBtn.Text = "ICMPing";
            this.ICMPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TCPingRadioBtn
            // 
            this.TCPingRadioBtn.AutoSize = true;
            this.TCPingRadioBtn.Location = new System.Drawing.Point(230, 57);
            this.TCPingRadioBtn.Name = "TCPingRadioBtn";
            this.TCPingRadioBtn.Size = new System.Drawing.Size(66, 21);
            this.TCPingRadioBtn.TabIndex = 5;
            this.TCPingRadioBtn.TabStop = true;
            this.TCPingRadioBtn.Text = "TCPing";
            this.TCPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // STUNServerLabel
            // 
            this.STUNServerLabel.AutoSize = true;
            this.STUNServerLabel.Location = new System.Drawing.Point(16, 90);
            this.STUNServerLabel.Name = "STUNServerLabel";
            this.STUNServerLabel.Size = new System.Drawing.Size(80, 17);
            this.STUNServerLabel.TabIndex = 6;
            this.STUNServerLabel.Text = "STUN Server";
            // 
            // STUN_ServerComboBox
            // 
            this.STUN_ServerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.STUN_ServerComboBox.Location = new System.Drawing.Point(130, 86);
            this.STUN_ServerComboBox.Name = "STUN_ServerComboBox";
            this.STUN_ServerComboBox.Size = new System.Drawing.Size(260, 25);
            this.STUN_ServerComboBox.TabIndex = 7;
            // 
            // ProfileGroupBox
            // 
            this.ProfileGroupBox.BackColor = System.Drawing.Color.White;
            this.ProfileGroupBox.Controls.Add(this.ProfileCountLabel);
            this.ProfileGroupBox.Controls.Add(this.ProfileCountTextBox);
            this.ProfileGroupBox.Controls.Add(this.DetectionTickLabel);
            this.ProfileGroupBox.Controls.Add(this.DetectionTickTextBox);
            this.ProfileGroupBox.Controls.Add(this.StartedPingLabel);
            this.ProfileGroupBox.Controls.Add(this.StartedPingIntervalTextBox);
            this.ProfileGroupBox.Controls.Add(this.LanguageLabel);
            this.ProfileGroupBox.Controls.Add(this.LanguageComboBox);
            this.ProfileGroupBox.Location = new System.Drawing.Point(10, 142);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Size = new System.Drawing.Size(408, 168);
            this.ProfileGroupBox.TabIndex = 1;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles & Timing";
            // 
            // ProfileCountLabel
            // 
            this.ProfileCountLabel.AutoSize = true;
            this.ProfileCountLabel.Location = new System.Drawing.Point(16, 25);
            this.ProfileCountLabel.Name = "ProfileCountLabel";
            this.ProfileCountLabel.Size = new System.Drawing.Size(83, 17);
            this.ProfileCountLabel.TabIndex = 0;
            this.ProfileCountLabel.Text = "Profile Count";
            // 
            // ProfileCountTextBox
            // 
            this.ProfileCountTextBox.Location = new System.Drawing.Point(170, 21);
            this.ProfileCountTextBox.Name = "ProfileCountTextBox";
            this.ProfileCountTextBox.Size = new System.Drawing.Size(80, 23);
            this.ProfileCountTextBox.TabIndex = 1;
            this.ProfileCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetectionTickLabel
            // 
            this.DetectionTickLabel.AutoSize = true;
            this.DetectionTickLabel.Location = new System.Drawing.Point(16, 57);
            this.DetectionTickLabel.Name = "DetectionTickLabel";
            this.DetectionTickLabel.Size = new System.Drawing.Size(120, 17);
            this.DetectionTickLabel.TabIndex = 2;
            this.DetectionTickLabel.Text = "Detection Tick(sec)";
            // 
            // DetectionTickTextBox
            // 
            this.DetectionTickTextBox.Location = new System.Drawing.Point(170, 53);
            this.DetectionTickTextBox.Name = "DetectionTickTextBox";
            this.DetectionTickTextBox.Size = new System.Drawing.Size(80, 23);
            this.DetectionTickTextBox.TabIndex = 3;
            this.DetectionTickTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartedPingLabel
            // 
            this.StartedPingLabel.AutoSize = true;
            this.StartedPingLabel.Location = new System.Drawing.Point(16, 89);
            this.StartedPingLabel.Name = "StartedPingLabel";
            this.StartedPingLabel.Size = new System.Drawing.Size(149, 17);
            this.StartedPingLabel.TabIndex = 4;
            this.StartedPingLabel.Text = "Delay test after start(sec)";
            // 
            // StartedPingIntervalTextBox
            // 
            this.StartedPingIntervalTextBox.Location = new System.Drawing.Point(170, 85);
            this.StartedPingIntervalTextBox.Name = "StartedPingIntervalTextBox";
            this.StartedPingIntervalTextBox.Size = new System.Drawing.Size(80, 23);
            this.StartedPingIntervalTextBox.TabIndex = 5;
            this.StartedPingIntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(16, 123);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(65, 17);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(170, 119);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(120, 25);
            this.LanguageComboBox.TabIndex = 7;
            // 
            // NFTabPage
            // 
            this.NFTabPage.BackColor = System.Drawing.Color.White;
            this.NFTabPage.Controls.Add(this.TrafficFilterGroupBox);
            this.NFTabPage.Controls.Add(this.DNSGroupBox);
            this.NFTabPage.Location = new System.Drawing.Point(4, 28);
            this.NFTabPage.Name = "NFTabPage";
            this.NFTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.NFTabPage.Size = new System.Drawing.Size(428, 328);
            this.NFTabPage.TabIndex = 1;
            this.NFTabPage.Text = "Process Mode";
            // 
            // TrafficFilterGroupBox
            // 
            this.TrafficFilterGroupBox.BackColor = System.Drawing.Color.White;
            this.TrafficFilterGroupBox.Controls.Add(this.FilterTCPCheckBox);
            this.TrafficFilterGroupBox.Controls.Add(this.FilterUDPCheckBox);
            this.TrafficFilterGroupBox.Controls.Add(this.FilterICMPCheckBox);
            this.TrafficFilterGroupBox.Controls.Add(this.ICMPDelayLabel);
            this.TrafficFilterGroupBox.Controls.Add(this.ICMPDelayTextBox);
            this.TrafficFilterGroupBox.Controls.Add(this.ChildProcessHandleCheckBox);
            this.TrafficFilterGroupBox.Location = new System.Drawing.Point(10, 8);
            this.TrafficFilterGroupBox.Name = "TrafficFilterGroupBox";
            this.TrafficFilterGroupBox.Size = new System.Drawing.Size(408, 145);
            this.TrafficFilterGroupBox.TabIndex = 0;
            this.TrafficFilterGroupBox.TabStop = false;
            this.TrafficFilterGroupBox.Text = "Protocol Filtering";
            // 
            // FilterTCPCheckBox
            // 
            this.FilterTCPCheckBox.AutoSize = true;
            this.FilterTCPCheckBox.Location = new System.Drawing.Point(16, 24);
            this.FilterTCPCheckBox.Name = "FilterTCPCheckBox";
            this.FilterTCPCheckBox.Size = new System.Drawing.Size(95, 21);
            this.FilterTCPCheckBox.TabIndex = 0;
            this.FilterTCPCheckBox.Text = "Handle TCP";
            this.FilterTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterUDPCheckBox
            // 
            this.FilterUDPCheckBox.AutoSize = true;
            this.FilterUDPCheckBox.Location = new System.Drawing.Point(16, 52);
            this.FilterUDPCheckBox.Name = "FilterUDPCheckBox";
            this.FilterUDPCheckBox.Size = new System.Drawing.Size(98, 21);
            this.FilterUDPCheckBox.TabIndex = 1;
            this.FilterUDPCheckBox.Text = "Handle UDP";
            this.FilterUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterICMPCheckBox
            // 
            this.FilterICMPCheckBox.AutoSize = true;
            this.FilterICMPCheckBox.Location = new System.Drawing.Point(16, 80);
            this.FilterICMPCheckBox.Name = "FilterICMPCheckBox";
            this.FilterICMPCheckBox.Size = new System.Drawing.Size(102, 21);
            this.FilterICMPCheckBox.TabIndex = 2;
            this.FilterICMPCheckBox.Text = "Handle ICMP";
            this.FilterICMPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ICMPDelayLabel
            // 
            this.ICMPDelayLabel.AutoSize = true;
            this.ICMPDelayLabel.Location = new System.Drawing.Point(34, 110);
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.Size = new System.Drawing.Size(97, 17);
            this.ICMPDelayLabel.TabIndex = 3;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterICMPCheckBox, "Checked", true));
            this.ICMPDelayTextBox.Location = new System.Drawing.Point(145, 107);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(55, 23);
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChildProcessHandleCheckBox
            // 
            this.ChildProcessHandleCheckBox.AutoSize = true;
            this.ChildProcessHandleCheckBox.Location = new System.Drawing.Point(200, 24);
            this.ChildProcessHandleCheckBox.Name = "ChildProcessHandleCheckBox";
            this.ChildProcessHandleCheckBox.Size = new System.Drawing.Size(147, 21);
            this.ChildProcessHandleCheckBox.TabIndex = 5;
            this.ChildProcessHandleCheckBox.Text = "Handle child process";
            this.ChildProcessHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSGroupBox
            // 
            this.DNSGroupBox.BackColor = System.Drawing.Color.White;
            this.DNSGroupBox.Controls.Add(this.FilterDNSCheckBox);
            this.DNSGroupBox.Controls.Add(this.DNSHijackLabel);
            this.DNSGroupBox.Controls.Add(this.DNSHijackHostTextBox);
            this.DNSGroupBox.Controls.Add(this.DNSProxyCheckBox);
            this.DNSGroupBox.Controls.Add(this.HandleProcDNSCheckBox);
            this.DNSGroupBox.Location = new System.Drawing.Point(10, 160);
            this.DNSGroupBox.Name = "DNSGroupBox";
            this.DNSGroupBox.Size = new System.Drawing.Size(408, 145);
            this.DNSGroupBox.TabIndex = 1;
            this.DNSGroupBox.TabStop = false;
            this.DNSGroupBox.Text = "DNS Settings";
            // 
            // FilterDNSCheckBox
            // 
            this.FilterDNSCheckBox.AutoSize = true;
            this.FilterDNSCheckBox.Location = new System.Drawing.Point(16, 24);
            this.FilterDNSCheckBox.Name = "FilterDNSCheckBox";
            this.FilterDNSCheckBox.Size = new System.Drawing.Size(189, 21);
            this.FilterDNSCheckBox.TabIndex = 0;
            this.FilterDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.FilterDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSHijackLabel
            // 
            this.DNSHijackLabel.AutoSize = true;
            this.DNSHijackLabel.Location = new System.Drawing.Point(34, 54);
            this.DNSHijackLabel.Name = "DNSHijackLabel";
            this.DNSHijackLabel.Size = new System.Drawing.Size(34, 17);
            this.DNSHijackLabel.TabIndex = 1;
            this.DNSHijackLabel.Text = "DNS";
            // 
            // DNSHijackHostTextBox
            // 
            this.DNSHijackHostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSHijackHostTextBox.Location = new System.Drawing.Point(80, 51);
            this.DNSHijackHostTextBox.Name = "DNSHijackHostTextBox";
            this.DNSHijackHostTextBox.Size = new System.Drawing.Size(210, 23);
            this.DNSHijackHostTextBox.TabIndex = 2;
            this.DNSHijackHostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DNSProxyCheckBox
            // 
            this.DNSProxyCheckBox.AutoSize = true;
            this.DNSProxyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.DNSProxyCheckBox.Location = new System.Drawing.Point(16, 82);
            this.DNSProxyCheckBox.Name = "DNSProxyCheckBox";
            this.DNSProxyCheckBox.Size = new System.Drawing.Size(180, 21);
            this.DNSProxyCheckBox.TabIndex = 3;
            this.DNSProxyCheckBox.Text = "Handle DNS through proxy";
            this.DNSProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.FilterDNSCheckBox, "Checked", true));
            this.HandleProcDNSCheckBox.Location = new System.Drawing.Point(16, 110);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.Size = new System.Drawing.Size(206, 21);
            this.HandleProcDNSCheckBox.TabIndex = 4;
            this.HandleProcDNSCheckBox.Text = "Handle handled process\'s DNS";
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // WinTUNTabPage
            // 
            this.WinTUNTabPage.BackColor = System.Drawing.Color.White;
            this.WinTUNTabPage.Controls.Add(this.WinTUNGroupBox);
            this.WinTUNTabPage.Controls.Add(this.GlobalBypassIPsButton);
            this.WinTUNTabPage.Location = new System.Drawing.Point(4, 28);
            this.WinTUNTabPage.Name = "WinTUNTabPage";
            this.WinTUNTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.WinTUNTabPage.Size = new System.Drawing.Size(428, 328);
            this.WinTUNTabPage.TabIndex = 2;
            this.WinTUNTabPage.Text = "WinTUN";
            // 
            // WinTUNGroupBox
            // 
            this.WinTUNGroupBox.BackColor = System.Drawing.Color.White;
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPAddressLabel);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPAddressTextBox);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPNetmaskLabel);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPNetmaskTextBox);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPGatewayLabel);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPGatewayTextBox);
            this.WinTUNGroupBox.Controls.Add(this.UseCustomDNSCheckBox);
            this.WinTUNGroupBox.Controls.Add(this.ProxyDNSCheckBox);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPDNSLabel);
            this.WinTUNGroupBox.Controls.Add(this.TUNTAPDNSTextBox);
            this.WinTUNGroupBox.Location = new System.Drawing.Point(10, 8);
            this.WinTUNGroupBox.Name = "WinTUNGroupBox";
            this.WinTUNGroupBox.Size = new System.Drawing.Size(408, 225);
            this.WinTUNGroupBox.TabIndex = 0;
            this.WinTUNGroupBox.TabStop = false;
            this.WinTUNGroupBox.Text = "Network Settings";
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(16, 26);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(56, 17);
            this.TUNTAPAddressLabel.TabIndex = 0;
            this.TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(110, 23);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(280, 23);
            this.TUNTAPAddressTextBox.TabIndex = 1;
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Location = new System.Drawing.Point(16, 58);
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.Size = new System.Drawing.Size(60, 17);
            this.TUNTAPNetmaskLabel.TabIndex = 2;
            this.TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Location = new System.Drawing.Point(110, 55);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.Size = new System.Drawing.Size(280, 23);
            this.TUNTAPNetmaskTextBox.TabIndex = 3;
            this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(16, 90);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(57, 17);
            this.TUNTAPGatewayLabel.TabIndex = 4;
            this.TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(110, 87);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(280, 23);
            this.TUNTAPGatewayTextBox.TabIndex = 5;
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UseCustomDNSCheckBox
            // 
            this.UseCustomDNSCheckBox.AutoSize = true;
            this.UseCustomDNSCheckBox.Location = new System.Drawing.Point(16, 122);
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
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(170, 122);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(87, 21);
            this.ProxyDNSCheckBox.TabIndex = 7;
            this.ProxyDNSCheckBox.Text = "Proxy DNS";
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(16, 156);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(34, 17);
            this.TUNTAPDNSLabel.TabIndex = 8;
            this.TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.UseCustomDNSCheckBox, "Checked", true));
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(110, 153);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(280, 23);
            this.TUNTAPDNSTextBox.TabIndex = 9;
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GlobalBypassIPsButton
            // 
            this.GlobalBypassIPsButton.Location = new System.Drawing.Point(10, 248);
            this.GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            this.GlobalBypassIPsButton.Size = new System.Drawing.Size(140, 28);
            this.GlobalBypassIPsButton.TabIndex = 1;
            this.GlobalBypassIPsButton.Text = "Global Bypass IPs";
            this.GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            this.GlobalBypassIPsButton.Click += new System.EventHandler(this.GlobalBypassIPsButton_Click);
            // 
            // OtherTabPage
            // 
            this.OtherTabPage.BackColor = System.Drawing.Color.White;
            this.OtherTabPage.Controls.Add(this.StartupBehaviorGroupBox);
            this.OtherTabPage.Controls.Add(this.UpdateNoticeGroupBox);
            this.OtherTabPage.Location = new System.Drawing.Point(4, 28);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(8);
            this.OtherTabPage.Size = new System.Drawing.Size(428, 328);
            this.OtherTabPage.TabIndex = 3;
            this.OtherTabPage.Text = "Others";
            // 
            // StartupBehaviorGroupBox
            // 
            this.StartupBehaviorGroupBox.BackColor = System.Drawing.Color.White;
            this.StartupBehaviorGroupBox.Controls.Add(this.StartWhenOpenedCheckBox);
            this.StartupBehaviorGroupBox.Controls.Add(this.MinimizeWhenStartedCheckBox);
            this.StartupBehaviorGroupBox.Controls.Add(this.ExitWhenClosedCheckBox);
            this.StartupBehaviorGroupBox.Controls.Add(this.StopWhenExitedCheckBox);
            this.StartupBehaviorGroupBox.Controls.Add(this.RunAtStartupCheckBox);
            this.StartupBehaviorGroupBox.Location = new System.Drawing.Point(10, 8);
            this.StartupBehaviorGroupBox.Name = "StartupBehaviorGroupBox";
            this.StartupBehaviorGroupBox.Size = new System.Drawing.Size(408, 145);
            this.StartupBehaviorGroupBox.TabIndex = 0;
            this.StartupBehaviorGroupBox.TabStop = false;
            this.StartupBehaviorGroupBox.Text = "Startup & Exit Behavior";
            // 
            // StartWhenOpenedCheckBox
            // 
            this.StartWhenOpenedCheckBox.AutoSize = true;
            this.StartWhenOpenedCheckBox.Location = new System.Drawing.Point(16, 25);
            this.StartWhenOpenedCheckBox.Name = "StartWhenOpenedCheckBox";
            this.StartWhenOpenedCheckBox.Size = new System.Drawing.Size(137, 21);
            this.StartWhenOpenedCheckBox.TabIndex = 0;
            this.StartWhenOpenedCheckBox.Text = "Start when opened";
            this.StartWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimizeWhenStartedCheckBox
            // 
            this.MinimizeWhenStartedCheckBox.AutoSize = true;
            this.MinimizeWhenStartedCheckBox.Location = new System.Drawing.Point(215, 25);
            this.MinimizeWhenStartedCheckBox.Name = "MinimizeWhenStartedCheckBox";
            this.MinimizeWhenStartedCheckBox.Size = new System.Drawing.Size(157, 21);
            this.MinimizeWhenStartedCheckBox.TabIndex = 1;
            this.MinimizeWhenStartedCheckBox.Text = "Minimize when started";
            this.MinimizeWhenStartedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitWhenClosedCheckBox
            // 
            this.ExitWhenClosedCheckBox.AutoSize = true;
            this.ExitWhenClosedCheckBox.Location = new System.Drawing.Point(16, 58);
            this.ExitWhenClosedCheckBox.Name = "ExitWhenClosedCheckBox";
            this.ExitWhenClosedCheckBox.Size = new System.Drawing.Size(123, 21);
            this.ExitWhenClosedCheckBox.TabIndex = 2;
            this.ExitWhenClosedCheckBox.Text = "Exit when closed";
            this.ExitWhenClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopWhenExitedCheckBox
            // 
            this.StopWhenExitedCheckBox.AutoSize = true;
            this.StopWhenExitedCheckBox.Location = new System.Drawing.Point(215, 58);
            this.StopWhenExitedCheckBox.Name = "StopWhenExitedCheckBox";
            this.StopWhenExitedCheckBox.Size = new System.Drawing.Size(125, 21);
            this.StopWhenExitedCheckBox.TabIndex = 3;
            this.StopWhenExitedCheckBox.Text = "Stop when exited";
            this.StopWhenExitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunAtStartupCheckBox
            // 
            this.RunAtStartupCheckBox.AutoSize = true;
            this.RunAtStartupCheckBox.Location = new System.Drawing.Point(16, 91);
            this.RunAtStartupCheckBox.Name = "RunAtStartupCheckBox";
            this.RunAtStartupCheckBox.Size = new System.Drawing.Size(109, 21);
            this.RunAtStartupCheckBox.TabIndex = 4;
            this.RunAtStartupCheckBox.Text = "Run at startup";
            this.RunAtStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateNoticeGroupBox
            // 
            this.UpdateNoticeGroupBox.BackColor = System.Drawing.Color.White;
            this.UpdateNoticeGroupBox.Controls.Add(this.CheckUpdateWhenOpenedCheckBox);
            this.UpdateNoticeGroupBox.Controls.Add(this.CheckBetaUpdateCheckBox);
            this.UpdateNoticeGroupBox.Controls.Add(this.NoSupportDialogCheckBox);
            this.UpdateNoticeGroupBox.Location = new System.Drawing.Point(10, 162);
            this.UpdateNoticeGroupBox.Name = "UpdateNoticeGroupBox";
            this.UpdateNoticeGroupBox.Size = new System.Drawing.Size(408, 100);
            this.UpdateNoticeGroupBox.TabIndex = 1;
            this.UpdateNoticeGroupBox.TabStop = false;
            this.UpdateNoticeGroupBox.Text = "Updates & Notifications";
            // 
            // CheckUpdateWhenOpenedCheckBox
            // 
            this.CheckUpdateWhenOpenedCheckBox.AutoSize = true;
            this.CheckUpdateWhenOpenedCheckBox.Location = new System.Drawing.Point(16, 25);
            this.CheckUpdateWhenOpenedCheckBox.Name = "CheckUpdateWhenOpenedCheckBox";
            this.CheckUpdateWhenOpenedCheckBox.Size = new System.Drawing.Size(187, 21);
            this.CheckUpdateWhenOpenedCheckBox.TabIndex = 0;
            this.CheckUpdateWhenOpenedCheckBox.Text = "Check update when opened";
            this.CheckUpdateWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBetaUpdateCheckBox
            // 
            this.CheckBetaUpdateCheckBox.AutoSize = true;
            this.CheckBetaUpdateCheckBox.Location = new System.Drawing.Point(215, 25);
            this.CheckBetaUpdateCheckBox.Name = "CheckBetaUpdateCheckBox";
            this.CheckBetaUpdateCheckBox.Size = new System.Drawing.Size(136, 21);
            this.CheckBetaUpdateCheckBox.TabIndex = 1;
            this.CheckBetaUpdateCheckBox.Text = "Check Beta update";
            this.CheckBetaUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoSupportDialogCheckBox
            // 
            this.NoSupportDialogCheckBox.AutoSize = true;
            this.NoSupportDialogCheckBox.Location = new System.Drawing.Point(16, 58);
            this.NoSupportDialogCheckBox.Name = "NoSupportDialogCheckBox";
            this.NoSupportDialogCheckBox.Size = new System.Drawing.Size(169, 21);
            this.NoSupportDialogCheckBox.TabIndex = 2;
            this.NoSupportDialogCheckBox.Text = "Disable Support Warning";
            this.NoSupportDialogCheckBox.UseVisualStyleBackColor = true;
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(280, 382);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(80, 26);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "OK";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Location = new System.Drawing.Point(368, 382);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(80, 26);
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
            this.ClientSize = new System.Drawing.Size(460, 420);
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
            this.PortGroupBox.PerformLayout();
            this.ProfileGroupBox.ResumeLayout(false);
            this.ProfileGroupBox.PerformLayout();
            this.NFTabPage.ResumeLayout(false);
            this.TrafficFilterGroupBox.ResumeLayout(false);
            this.TrafficFilterGroupBox.PerformLayout();
            this.DNSGroupBox.ResumeLayout(false);
            this.DNSGroupBox.PerformLayout();
            this.WinTUNTabPage.ResumeLayout(false);
            this.WinTUNGroupBox.ResumeLayout(false);
            this.WinTUNGroupBox.PerformLayout();
            this.OtherTabPage.ResumeLayout(false);
            this.StartupBehaviorGroupBox.ResumeLayout(false);
            this.StartupBehaviorGroupBox.PerformLayout();
            this.UpdateNoticeGroupBox.ResumeLayout(false);
            this.UpdateNoticeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.TabPage NFTabPage;
        private System.Windows.Forms.TabPage WinTUNTabPage;
        private System.Windows.Forms.TabPage OtherTabPage;

        // General
        private System.Windows.Forms.GroupBox PortGroupBox;
        private System.Windows.Forms.Label Socks5PortLabel;
        private System.Windows.Forms.TextBox Socks5PortTextBox;
        private System.Windows.Forms.CheckBox AllowDevicesCheckBox;
        private System.Windows.Forms.Label ServerPingTypeLabel;
        private System.Windows.Forms.RadioButton ICMPingRadioBtn;
        private System.Windows.Forms.RadioButton TCPingRadioBtn;
        private System.Windows.Forms.Label STUNServerLabel;
        private System.Windows.Forms.ComboBox STUN_ServerComboBox;

        private System.Windows.Forms.GroupBox ProfileGroupBox;
        private System.Windows.Forms.Label ProfileCountLabel;
        private System.Windows.Forms.TextBox ProfileCountTextBox;
        private System.Windows.Forms.Label DetectionTickLabel;
        private System.Windows.Forms.TextBox DetectionTickTextBox;
        private System.Windows.Forms.Label StartedPingLabel;
        private System.Windows.Forms.TextBox StartedPingIntervalTextBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;

        // Process Mode
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

        // WinTUN
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

        // Others
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

        // Bottom buttons
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;

        private System.Windows.Forms.ErrorProvider errorProvider;

        // Compatibility dummy fields referenced by SettingForm.cs
        private System.Windows.Forms.TextBox ChinaDNSTextBox;
        private System.Windows.Forms.TextBox OtherDNSTextBox;
        private System.Windows.Forms.TextBox AioDNSListenPortTextBox;
    }
}
