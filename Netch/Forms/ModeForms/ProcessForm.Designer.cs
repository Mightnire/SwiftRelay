using System;
using System.Windows.Forms;

namespace Netch.Forms.ModeForms
{
    partial class ProcessForm
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
            var rootLayout = new System.Windows.Forms.TableLayoutPanel();
            var configTable = new System.Windows.Forms.TableLayoutPanel();
            var middleLayout = new System.Windows.Forms.TableLayoutPanel();
            var protocolTable = new System.Windows.Forms.TableLayoutPanel();
            var dnsTable = new System.Windows.Forms.TableLayoutPanel();
            var scopeFlow = new System.Windows.Forms.FlowLayoutPanel();
            var rulesLayout = new System.Windows.Forms.TableLayoutPanel();
            var handleGroupTable = new System.Windows.Forms.TableLayoutPanel();
            var handleBtnFlow = new System.Windows.Forms.FlowLayoutPanel();
            var bypassGroupTable = new System.Windows.Forms.TableLayoutPanel();
            var bypassBtnFlow = new System.Windows.Forms.FlowLayoutPanel();
            var bottomLayout = new System.Windows.Forms.TableLayoutPanel();

            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.ProtocolGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleTCPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleUDPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleICMPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.ICMPDelayLabel = new System.Windows.Forms.Label();
            this.ICMPDelayTextBox = new System.Windows.Forms.TextBox();
            this.DNSGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.DNSLabel = new System.Windows.Forms.Label();
            this.DNSTextBox = new System.Windows.Forms.TextBox();
            this.ProxyDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleProcDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.ScopeGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleChildProcCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleLoopbackCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleLANCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleSelectButton = new System.Windows.Forms.Button();
            this.HandleScanButton = new System.Windows.Forms.Button();
            this.HandleRuleRichTextBox = new System.Windows.Forms.TextBox();
            this.BypassGroupBox = new System.Windows.Forms.GroupBox();
            this.BypassSelectButton = new System.Windows.Forms.Button();
            this.BypassScanButton = new System.Windows.Forms.Button();
            this.BypassRuleRichTextBox = new System.Windows.Forms.TextBox();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();

            rootLayout.SuspendLayout();
            configTable.SuspendLayout();
            middleLayout.SuspendLayout();
            protocolTable.SuspendLayout();
            dnsTable.SuspendLayout();
            scopeFlow.SuspendLayout();
            rulesLayout.SuspendLayout();
            handleGroupTable.SuspendLayout();
            handleBtnFlow.SuspendLayout();
            bypassGroupTable.SuspendLayout();
            bypassBtnFlow.SuspendLayout();
            bottomLayout.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.ProtocolGroupBox.SuspendLayout();
            this.DNSGroupBox.SuspendLayout();
            this.ScopeGroupBox.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.BypassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.Controls.Add(this.ConfigurationGroupBox, 0, 0);
            rootLayout.Controls.Add(middleLayout, 0, 1);
            rootLayout.Controls.Add(rulesLayout, 0, 2);
            rootLayout.Controls.Add(bottomLayout, 0, 3);
            rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rootLayout.Location = new System.Drawing.Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new System.Windows.Forms.Padding(12);
            rootLayout.RowCount = 4;
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.Size = new System.Drawing.Size(860, 660);
            rootLayout.TabIndex = 0;
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.AutoSize = true;
            this.ConfigurationGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfigurationGroupBox.Controls.Add(configTable);
            this.ConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.ConfigurationGroupBox.TabIndex = 0;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // configTable
            // 
            configTable.AutoSize = true;
            configTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            configTable.ColumnCount = 2;
            configTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            configTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            configTable.Controls.Add(this.RemarkLabel, 0, 0);
            configTable.Controls.Add(this.RemarkTextBox, 1, 0);
            configTable.Controls.Add(this.FilenameLabel, 0, 1);
            configTable.Controls.Add(this.FilenameTextBox, 1, 1);
            configTable.Dock = System.Windows.Forms.DockStyle.Fill;
            configTable.Margin = new System.Windows.Forms.Padding(0);
            configTable.Name = "configTable";
            configTable.RowCount = 2;
            configTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            configTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            configTable.TabIndex = 0;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Margin = new System.Windows.Forms.Padding(4, 5, 12, 5);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "Remark";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarkTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.TextChanged += new System.EventHandler(this.RemarkTextBox_TextChanged);
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 12, 5);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.TabIndex = 2;
            this.FilenameLabel.Text = "Filename";
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.ReadOnly = true;
            this.FilenameTextBox.TabIndex = 3;
            // 
            // middleLayout
            // 
            middleLayout.AutoSize = true;
            middleLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            middleLayout.ColumnCount = 3;
            middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            middleLayout.Controls.Add(this.ProtocolGroupBox, 0, 0);
            middleLayout.Controls.Add(this.DNSGroupBox, 1, 0);
            middleLayout.Controls.Add(this.ScopeGroupBox, 2, 0);
            middleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            middleLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            middleLayout.Name = "middleLayout";
            middleLayout.RowCount = 1;
            middleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            middleLayout.TabIndex = 1;
            // 
            // ProtocolGroupBox
            // 
            this.ProtocolGroupBox.AutoSize = true;
            this.ProtocolGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProtocolGroupBox.Controls.Add(protocolTable);
            this.ProtocolGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProtocolGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ProtocolGroupBox.Name = "ProtocolGroupBox";
            this.ProtocolGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.ProtocolGroupBox.TabIndex = 1;
            this.ProtocolGroupBox.TabStop = false;
            this.ProtocolGroupBox.Text = "Protocol Filtering";
            // 
            // protocolTable
            // 
            protocolTable.AutoSize = true;
            protocolTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            protocolTable.ColumnCount = 2;
            protocolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            protocolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            protocolTable.Controls.Add(this.HandleTCPCheckBox, 0, 0);
            protocolTable.Controls.Add(this.HandleUDPCheckBox, 0, 1);
            protocolTable.Controls.Add(this.HandleICMPCheckBox, 0, 2);
            protocolTable.Controls.Add(this.ICMPDelayLabel, 0, 3);
            protocolTable.Controls.Add(this.ICMPDelayTextBox, 1, 3);
            protocolTable.SetColumnSpan(this.HandleTCPCheckBox, 2);
            protocolTable.SetColumnSpan(this.HandleUDPCheckBox, 2);
            protocolTable.SetColumnSpan(this.HandleICMPCheckBox, 2);
            protocolTable.Dock = System.Windows.Forms.DockStyle.Fill;
            protocolTable.Margin = new System.Windows.Forms.Padding(0);
            protocolTable.Name = "protocolTable";
            protocolTable.RowCount = 4;
            protocolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            protocolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            protocolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            protocolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            protocolTable.TabIndex = 0;
            // 
            // HandleTCPCheckBox
            // 
            this.HandleTCPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleTCPCheckBox.AutoCheck = false;
            this.HandleTCPCheckBox.AutoSize = true;
            this.HandleTCPCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleTCPCheckBox.Name = "HandleTCPCheckBox";
            this.HandleTCPCheckBox.TabIndex = 0;
            this.HandleTCPCheckBox.Text = "Handle TCP";
            this.HandleTCPCheckBox.ThreeState = true;
            this.HandleTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleUDPCheckBox
            // 
            this.HandleUDPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleUDPCheckBox.AutoCheck = false;
            this.HandleUDPCheckBox.AutoSize = true;
            this.HandleUDPCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleUDPCheckBox.Name = "HandleUDPCheckBox";
            this.HandleUDPCheckBox.TabIndex = 1;
            this.HandleUDPCheckBox.Text = "Handle UDP";
            this.HandleUDPCheckBox.ThreeState = true;
            this.HandleUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleICMPCheckBox
            // 
            this.HandleICMPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleICMPCheckBox.AutoCheck = false;
            this.HandleICMPCheckBox.AutoSize = true;
            this.HandleICMPCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleICMPCheckBox.Name = "HandleICMPCheckBox";
            this.HandleICMPCheckBox.TabIndex = 2;
            this.HandleICMPCheckBox.Text = "Handle ICMP";
            this.HandleICMPCheckBox.ThreeState = true;
            this.HandleICMPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ICMPDelayLabel
            // 
            this.ICMPDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICMPDelayLabel.AutoSize = true;
            this.ICMPDelayLabel.Margin = new System.Windows.Forms.Padding(20, 5, 8, 5);
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.TabIndex = 3;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICMPDelayTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(60, 23);
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DNSGroupBox
            // 
            this.DNSGroupBox.AutoSize = true;
            this.DNSGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DNSGroupBox.Controls.Add(dnsTable);
            this.DNSGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNSGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.DNSGroupBox.Name = "DNSGroupBox";
            this.DNSGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.DNSGroupBox.TabIndex = 2;
            this.DNSGroupBox.TabStop = false;
            this.DNSGroupBox.Text = "DNS Settings";
            // 
            // dnsTable
            // 
            dnsTable.AutoSize = true;
            dnsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            dnsTable.ColumnCount = 2;
            dnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            dnsTable.Controls.Add(this.HandleDNSCheckBox, 0, 0);
            dnsTable.Controls.Add(this.DNSLabel, 0, 1);
            dnsTable.Controls.Add(this.DNSTextBox, 1, 1);
            dnsTable.Controls.Add(this.ProxyDNSCheckBox, 0, 2);
            dnsTable.Controls.Add(this.HandleProcDNSCheckBox, 0, 3);
            dnsTable.SetColumnSpan(this.HandleDNSCheckBox, 2);
            dnsTable.SetColumnSpan(this.ProxyDNSCheckBox, 2);
            dnsTable.SetColumnSpan(this.HandleProcDNSCheckBox, 2);
            dnsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            dnsTable.Margin = new System.Windows.Forms.Padding(0);
            dnsTable.Name = "dnsTable";
            dnsTable.RowCount = 4;
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            dnsTable.TabIndex = 0;
            // 
            // HandleDNSCheckBox
            // 
            this.HandleDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleDNSCheckBox.AutoCheck = false;
            this.HandleDNSCheckBox.AutoSize = true;
            this.HandleDNSCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleDNSCheckBox.Name = "HandleDNSCheckBox";
            this.HandleDNSCheckBox.TabIndex = 0;
            this.HandleDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.HandleDNSCheckBox.ThreeState = true;
            this.HandleDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSLabel
            // 
            this.DNSLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSLabel.AutoSize = true;
            this.DNSLabel.Margin = new System.Windows.Forms.Padding(20, 5, 8, 5);
            this.DNSLabel.Name = "DNSLabel";
            this.DNSLabel.TabIndex = 1;
            this.DNSLabel.Text = "DNS";
            // 
            // DNSTextBox
            // 
            this.DNSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DNSTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this.DNSTextBox.Name = "DNSTextBox";
            this.DNSTextBox.TabIndex = 2;
            this.DNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProxyDNSCheckBox.AutoCheck = false;
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.TabIndex = 3;
            this.ProxyDNSCheckBox.Text = "Handle DNS through proxy";
            this.ProxyDNSCheckBox.ThreeState = true;
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HandleProcDNSCheckBox.AutoCheck = false;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.TabIndex = 4;
            this.HandleProcDNSCheckBox.Text = "Handle handled process's DNS";
            this.HandleProcDNSCheckBox.ThreeState = true;
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScopeGroupBox
            // 
            this.ScopeGroupBox.AutoSize = true;
            this.ScopeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScopeGroupBox.Controls.Add(scopeFlow);
            this.ScopeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScopeGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ScopeGroupBox.Name = "ScopeGroupBox";
            this.ScopeGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.ScopeGroupBox.TabIndex = 3;
            this.ScopeGroupBox.TabStop = false;
            this.ScopeGroupBox.Text = "Scope & Process";
            // 
            // scopeFlow
            // 
            scopeFlow.AutoSize = true;
            scopeFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            scopeFlow.Controls.Add(this.HandleChildProcCheckBox);
            scopeFlow.Controls.Add(this.HandleLoopbackCheckBox);
            scopeFlow.Controls.Add(this.HandleLANCheckBox);
            scopeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            scopeFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            scopeFlow.Margin = new System.Windows.Forms.Padding(0);
            scopeFlow.Name = "scopeFlow";
            scopeFlow.TabIndex = 0;
            scopeFlow.WrapContents = false;
            // 
            // HandleChildProcCheckBox
            // 
            this.HandleChildProcCheckBox.AutoCheck = false;
            this.HandleChildProcCheckBox.AutoSize = true;
            this.HandleChildProcCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleChildProcCheckBox.Name = "HandleChildProcCheckBox";
            this.HandleChildProcCheckBox.TabIndex = 0;
            this.HandleChildProcCheckBox.Text = "Handle child process";
            this.HandleChildProcCheckBox.ThreeState = true;
            this.HandleChildProcCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLoopbackCheckBox
            // 
            this.HandleLoopbackCheckBox.AutoSize = true;
            this.HandleLoopbackCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleLoopbackCheckBox.Name = "HandleLoopbackCheckBox";
            this.HandleLoopbackCheckBox.TabIndex = 1;
            this.HandleLoopbackCheckBox.Text = "Handle local loopback";
            this.HandleLoopbackCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLANCheckBox
            // 
            this.HandleLANCheckBox.AutoSize = true;
            this.HandleLANCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandleLANCheckBox.Name = "HandleLANCheckBox";
            this.HandleLANCheckBox.TabIndex = 2;
            this.HandleLANCheckBox.Text = "Handle LAN";
            this.HandleLANCheckBox.UseVisualStyleBackColor = true;
            // 
            // rulesLayout
            // 
            rulesLayout.ColumnCount = 2;
            rulesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            rulesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            rulesLayout.Controls.Add(this.HandleGroupBox, 0, 0);
            rulesLayout.Controls.Add(this.BypassGroupBox, 1, 0);
            rulesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rulesLayout.Margin = new System.Windows.Forms.Padding(0);
            rulesLayout.Name = "rulesLayout";
            rulesLayout.RowCount = 1;
            rulesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rulesLayout.TabIndex = 2;
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(handleGroupTable);
            this.HandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 10);
            this.HandleGroupBox.TabIndex = 4;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Handle rules";
            // 
            // handleGroupTable
            // 
            handleGroupTable.ColumnCount = 1;
            handleGroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            handleGroupTable.Controls.Add(handleBtnFlow, 0, 0);
            handleGroupTable.Controls.Add(this.HandleRuleRichTextBox, 0, 1);
            handleGroupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            handleGroupTable.Margin = new System.Windows.Forms.Padding(0);
            handleGroupTable.Name = "handleGroupTable";
            handleGroupTable.RowCount = 2;
            handleGroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            handleGroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            handleGroupTable.TabIndex = 0;
            // 
            // handleBtnFlow
            // 
            handleBtnFlow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            handleBtnFlow.AutoSize = true;
            handleBtnFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            handleBtnFlow.Controls.Add(this.HandleSelectButton);
            handleBtnFlow.Controls.Add(this.HandleScanButton);
            handleBtnFlow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            handleBtnFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            handleBtnFlow.Name = "handleBtnFlow";
            handleBtnFlow.TabIndex = 0;
            handleBtnFlow.WrapContents = false;
            // 
            // HandleSelectButton
            // 
            this.HandleSelectButton.AutoSize = true;
            this.HandleSelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HandleSelectButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.HandleSelectButton.MinimumSize = new System.Drawing.Size(75, 24);
            this.HandleSelectButton.Name = "HandleSelectButton";
            this.HandleSelectButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HandleSelectButton.TabIndex = 0;
            this.HandleSelectButton.Text = "Select";
            this.HandleSelectButton.UseVisualStyleBackColor = true;
            this.HandleSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // HandleScanButton
            // 
            this.HandleScanButton.AutoSize = true;
            this.HandleScanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HandleScanButton.Margin = new System.Windows.Forms.Padding(0);
            this.HandleScanButton.MinimumSize = new System.Drawing.Size(75, 24);
            this.HandleScanButton.Name = "HandleScanButton";
            this.HandleScanButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HandleScanButton.TabIndex = 1;
            this.HandleScanButton.Text = "Scan";
            this.HandleScanButton.UseVisualStyleBackColor = true;
            this.HandleScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // HandleRuleRichTextBox
            // 
            this.HandleRuleRichTextBox.AcceptsReturn = true;
            this.HandleRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandleRuleRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.HandleRuleRichTextBox.Multiline = true;
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HandleRuleRichTextBox.TabIndex = 2;
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassGroupBox
            // 
            this.BypassGroupBox.Controls.Add(bypassGroupTable);
            this.BypassGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassGroupBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BypassGroupBox.Name = "BypassGroupBox";
            this.BypassGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 10);
            this.BypassGroupBox.TabIndex = 5;
            this.BypassGroupBox.TabStop = false;
            this.BypassGroupBox.Text = "Bypass rules";
            // 
            // bypassGroupTable
            // 
            bypassGroupTable.ColumnCount = 1;
            bypassGroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bypassGroupTable.Controls.Add(bypassBtnFlow, 0, 0);
            bypassGroupTable.Controls.Add(this.BypassRuleRichTextBox, 0, 1);
            bypassGroupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            bypassGroupTable.Margin = new System.Windows.Forms.Padding(0);
            bypassGroupTable.Name = "bypassGroupTable";
            bypassGroupTable.RowCount = 2;
            bypassGroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            bypassGroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bypassGroupTable.TabIndex = 0;
            // 
            // bypassBtnFlow
            // 
            bypassBtnFlow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            bypassBtnFlow.AutoSize = true;
            bypassBtnFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bypassBtnFlow.Controls.Add(this.BypassSelectButton);
            bypassBtnFlow.Controls.Add(this.BypassScanButton);
            bypassBtnFlow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            bypassBtnFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            bypassBtnFlow.Name = "bypassBtnFlow";
            bypassBtnFlow.TabIndex = 0;
            bypassBtnFlow.WrapContents = false;
            // 
            // BypassSelectButton
            // 
            this.BypassSelectButton.AutoSize = true;
            this.BypassSelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BypassSelectButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BypassSelectButton.MinimumSize = new System.Drawing.Size(75, 24);
            this.BypassSelectButton.Name = "BypassSelectButton";
            this.BypassSelectButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.BypassSelectButton.TabIndex = 0;
            this.BypassSelectButton.Text = "Select";
            this.BypassSelectButton.UseVisualStyleBackColor = true;
            this.BypassSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BypassScanButton
            // 
            this.BypassScanButton.AutoSize = true;
            this.BypassScanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BypassScanButton.Margin = new System.Windows.Forms.Padding(0);
            this.BypassScanButton.MinimumSize = new System.Drawing.Size(75, 24);
            this.BypassScanButton.Name = "BypassScanButton";
            this.BypassScanButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.BypassScanButton.TabIndex = 1;
            this.BypassScanButton.Text = "Scan";
            this.BypassScanButton.UseVisualStyleBackColor = true;
            this.BypassScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // BypassRuleRichTextBox
            // 
            this.BypassRuleRichTextBox.AcceptsReturn = true;
            this.BypassRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BypassRuleRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BypassRuleRichTextBox.Multiline = true;
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BypassRuleRichTextBox.TabIndex = 2;
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // bottomLayout
            // 
            bottomLayout.AutoSize = true;
            bottomLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bottomLayout.ColumnCount = 4;
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.Controls.Add(this.ValidationButton, 0, 0);
            bottomLayout.Controls.Add(this.ControlButton, 2, 0);
            bottomLayout.Controls.Add(this.CancelButtonControl, 3, 0);
            bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomLayout.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            bottomLayout.Name = "bottomLayout";
            bottomLayout.RowCount = 1;
            bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.TabIndex = 3;
            // 
            // ValidationButton
            // 
            this.ValidationButton.AutoSize = true;
            this.ValidationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValidationButton.Margin = new System.Windows.Forms.Padding(0);
            this.ValidationButton.MinimumSize = new System.Drawing.Size(120, 28);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ValidationButton.TabIndex = 6;
            this.ValidationButton.Text = "Validation";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ControlButton.MinimumSize = new System.Drawing.Size(90, 28);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ControlButton.TabIndex = 7;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.AutoSize = true;
            this.CancelButtonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButtonControl.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButtonControl.MinimumSize = new System.Drawing.Size(90, 28);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CancelButtonControl.TabIndex = 8;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(860, 660);
            this.Controls.Add(rootLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Process Mode";
            this.Load += new System.EventHandler(this.ModeForm_Load);
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            configTable.ResumeLayout(false);
            configTable.PerformLayout();
            middleLayout.ResumeLayout(false);
            middleLayout.PerformLayout();
            protocolTable.ResumeLayout(false);
            protocolTable.PerformLayout();
            dnsTable.ResumeLayout(false);
            dnsTable.PerformLayout();
            scopeFlow.ResumeLayout(false);
            scopeFlow.PerformLayout();
            rulesLayout.ResumeLayout(false);
            handleGroupTable.ResumeLayout(false);
            handleGroupTable.PerformLayout();
            handleBtnFlow.ResumeLayout(false);
            handleBtnFlow.PerformLayout();
            bypassGroupTable.ResumeLayout(false);
            bypassGroupTable.PerformLayout();
            bypassBtnFlow.ResumeLayout(false);
            bypassBtnFlow.PerformLayout();
            bottomLayout.ResumeLayout(false);
            bottomLayout.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.ProtocolGroupBox.ResumeLayout(false);
            this.ProtocolGroupBox.PerformLayout();
            this.DNSGroupBox.ResumeLayout(false);
            this.DNSGroupBox.PerformLayout();
            this.ScopeGroupBox.ResumeLayout(false);
            this.ScopeGroupBox.PerformLayout();
            this.HandleGroupBox.ResumeLayout(false);
            this.BypassGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.TextBox FilenameTextBox;

        private System.Windows.Forms.GroupBox ProtocolGroupBox;
        private SyncGlobalCheckBox HandleTCPCheckBox;
        private SyncGlobalCheckBox HandleUDPCheckBox;
        private SyncGlobalCheckBox HandleICMPCheckBox;
        private System.Windows.Forms.Label ICMPDelayLabel;
        private System.Windows.Forms.TextBox ICMPDelayTextBox;

        private System.Windows.Forms.GroupBox DNSGroupBox;
        private SyncGlobalCheckBox HandleDNSCheckBox;
        private System.Windows.Forms.Label DNSLabel;
        private System.Windows.Forms.TextBox DNSTextBox;
        private SyncGlobalCheckBox ProxyDNSCheckBox;
        private SyncGlobalCheckBox HandleProcDNSCheckBox;

        private System.Windows.Forms.GroupBox ScopeGroupBox;
        private SyncGlobalCheckBox HandleChildProcCheckBox;
        private System.Windows.Forms.CheckBox HandleLoopbackCheckBox;
        private System.Windows.Forms.CheckBox HandleLANCheckBox;

        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.Button HandleSelectButton;
        private System.Windows.Forms.Button HandleScanButton;
        private System.Windows.Forms.TextBox HandleRuleRichTextBox;

        private System.Windows.Forms.GroupBox BypassGroupBox;
        private System.Windows.Forms.Button BypassSelectButton;
        private System.Windows.Forms.Button BypassScanButton;
        private System.Windows.Forms.TextBox BypassRuleRichTextBox;

        private System.Windows.Forms.Button ValidationButton;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;
    }
}
