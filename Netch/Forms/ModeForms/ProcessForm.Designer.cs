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
            this.ConfigurationGroupBox.SuspendLayout();
            this.ProtocolGroupBox.SuspendLayout();
            this.DNSGroupBox.SuspendLayout();
            this.ScopeGroupBox.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.BypassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.RemarkLabel);
            this.ConfigurationGroupBox.Controls.Add(this.RemarkTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.FilenameLabel);
            this.ConfigurationGroupBox.Controls.Add(this.FilenameTextBox);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 10);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(816, 85);
            this.ConfigurationGroupBox.TabIndex = 0;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(16, 25);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(53, 17);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "Remark";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(75, 22);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(725, 23);
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.TextChanged += new System.EventHandler(this.RemarkTextBox_TextChanged);
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(16, 54);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(59, 17);
            this.FilenameLabel.TabIndex = 2;
            this.FilenameLabel.Text = "Filename";
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Location = new System.Drawing.Point(75, 51);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.ReadOnly = true;
            this.FilenameTextBox.Size = new System.Drawing.Size(725, 23);
            this.FilenameTextBox.TabIndex = 3;
            // 
            // ProtocolGroupBox
            // 
            this.ProtocolGroupBox.Controls.Add(this.HandleTCPCheckBox);
            this.ProtocolGroupBox.Controls.Add(this.HandleUDPCheckBox);
            this.ProtocolGroupBox.Controls.Add(this.HandleICMPCheckBox);
            this.ProtocolGroupBox.Controls.Add(this.ICMPDelayLabel);
            this.ProtocolGroupBox.Controls.Add(this.ICMPDelayTextBox);
            this.ProtocolGroupBox.Location = new System.Drawing.Point(12, 100);
            this.ProtocolGroupBox.Name = "ProtocolGroupBox";
            this.ProtocolGroupBox.Size = new System.Drawing.Size(240, 145);
            this.ProtocolGroupBox.TabIndex = 1;
            this.ProtocolGroupBox.TabStop = false;
            this.ProtocolGroupBox.Text = "Protocol Filtering";
            // 
            // HandleTCPCheckBox
            // 
            this.HandleTCPCheckBox.AutoCheck = false;
            this.HandleTCPCheckBox.AutoSize = true;
            this.HandleTCPCheckBox.Location = new System.Drawing.Point(16, 24);
            this.HandleTCPCheckBox.Name = "HandleTCPCheckBox";
            this.HandleTCPCheckBox.Size = new System.Drawing.Size(95, 21);
            this.HandleTCPCheckBox.TabIndex = 0;
            this.HandleTCPCheckBox.Text = "Handle TCP";
            this.HandleTCPCheckBox.ThreeState = true;
            this.HandleTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleUDPCheckBox
            // 
            this.HandleUDPCheckBox.AutoCheck = false;
            this.HandleUDPCheckBox.AutoSize = true;
            this.HandleUDPCheckBox.Location = new System.Drawing.Point(16, 52);
            this.HandleUDPCheckBox.Name = "HandleUDPCheckBox";
            this.HandleUDPCheckBox.Size = new System.Drawing.Size(98, 21);
            this.HandleUDPCheckBox.TabIndex = 1;
            this.HandleUDPCheckBox.Text = "Handle UDP";
            this.HandleUDPCheckBox.ThreeState = true;
            this.HandleUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleICMPCheckBox
            // 
            this.HandleICMPCheckBox.AutoCheck = false;
            this.HandleICMPCheckBox.AutoSize = true;
            this.HandleICMPCheckBox.Location = new System.Drawing.Point(16, 80);
            this.HandleICMPCheckBox.Name = "HandleICMPCheckBox";
            this.HandleICMPCheckBox.Size = new System.Drawing.Size(102, 21);
            this.HandleICMPCheckBox.TabIndex = 2;
            this.HandleICMPCheckBox.Text = "Handle ICMP";
            this.HandleICMPCheckBox.ThreeState = true;
            this.HandleICMPCheckBox.UseVisualStyleBackColor = true;
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
            this.ICMPDelayTextBox.Location = new System.Drawing.Point(145, 107);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(55, 23);
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DNSGroupBox
            // 
            this.DNSGroupBox.Controls.Add(this.HandleDNSCheckBox);
            this.DNSGroupBox.Controls.Add(this.DNSLabel);
            this.DNSGroupBox.Controls.Add(this.DNSTextBox);
            this.DNSGroupBox.Controls.Add(this.ProxyDNSCheckBox);
            this.DNSGroupBox.Controls.Add(this.HandleProcDNSCheckBox);
            this.DNSGroupBox.Location = new System.Drawing.Point(264, 100);
            this.DNSGroupBox.Name = "DNSGroupBox";
            this.DNSGroupBox.Size = new System.Drawing.Size(310, 145);
            this.DNSGroupBox.TabIndex = 2;
            this.DNSGroupBox.TabStop = false;
            this.DNSGroupBox.Text = "DNS Settings";
            // 
            // HandleDNSCheckBox
            // 
            this.HandleDNSCheckBox.AutoCheck = false;
            this.HandleDNSCheckBox.AutoSize = true;
            this.HandleDNSCheckBox.Location = new System.Drawing.Point(16, 24);
            this.HandleDNSCheckBox.Name = "HandleDNSCheckBox";
            this.HandleDNSCheckBox.Size = new System.Drawing.Size(189, 21);
            this.HandleDNSCheckBox.TabIndex = 0;
            this.HandleDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.HandleDNSCheckBox.ThreeState = true;
            this.HandleDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSLabel
            // 
            this.DNSLabel.AutoSize = true;
            this.DNSLabel.Location = new System.Drawing.Point(34, 54);
            this.DNSLabel.Name = "DNSLabel";
            this.DNSLabel.Size = new System.Drawing.Size(34, 17);
            this.DNSLabel.TabIndex = 1;
            this.DNSLabel.Text = "DNS";
            // 
            // DNSTextBox
            // 
            this.DNSTextBox.Location = new System.Drawing.Point(80, 51);
            this.DNSTextBox.Name = "DNSTextBox";
            this.DNSTextBox.Size = new System.Drawing.Size(210, 23);
            this.DNSTextBox.TabIndex = 2;
            this.DNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoCheck = false;
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(16, 82);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(180, 21);
            this.ProxyDNSCheckBox.TabIndex = 3;
            this.ProxyDNSCheckBox.Text = "Handle DNS through proxy";
            this.ProxyDNSCheckBox.ThreeState = true;
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.AutoCheck = false;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.Location = new System.Drawing.Point(16, 110);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.Size = new System.Drawing.Size(206, 21);
            this.HandleProcDNSCheckBox.TabIndex = 4;
            this.HandleProcDNSCheckBox.Text = "Handle handled process\'s DNS";
            this.HandleProcDNSCheckBox.ThreeState = true;
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScopeGroupBox
            // 
            this.ScopeGroupBox.Controls.Add(this.HandleChildProcCheckBox);
            this.ScopeGroupBox.Controls.Add(this.HandleLoopbackCheckBox);
            this.ScopeGroupBox.Controls.Add(this.HandleLANCheckBox);
            this.ScopeGroupBox.Location = new System.Drawing.Point(586, 100);
            this.ScopeGroupBox.Name = "ScopeGroupBox";
            this.ScopeGroupBox.Size = new System.Drawing.Size(242, 145);
            this.ScopeGroupBox.TabIndex = 3;
            this.ScopeGroupBox.TabStop = false;
            this.ScopeGroupBox.Text = "Scope & Process";
            // 
            // HandleChildProcCheckBox
            // 
            this.HandleChildProcCheckBox.AutoCheck = false;
            this.HandleChildProcCheckBox.AutoSize = true;
            this.HandleChildProcCheckBox.Location = new System.Drawing.Point(16, 24);
            this.HandleChildProcCheckBox.Name = "HandleChildProcCheckBox";
            this.HandleChildProcCheckBox.Size = new System.Drawing.Size(147, 21);
            this.HandleChildProcCheckBox.TabIndex = 0;
            this.HandleChildProcCheckBox.Text = "Handle child process";
            this.HandleChildProcCheckBox.ThreeState = true;
            this.HandleChildProcCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLoopbackCheckBox
            // 
            this.HandleLoopbackCheckBox.AutoSize = true;
            this.HandleLoopbackCheckBox.Location = new System.Drawing.Point(16, 52);
            this.HandleLoopbackCheckBox.Name = "HandleLoopbackCheckBox";
            this.HandleLoopbackCheckBox.Size = new System.Drawing.Size(155, 21);
            this.HandleLoopbackCheckBox.TabIndex = 1;
            this.HandleLoopbackCheckBox.Text = "Handle local loopback";
            this.HandleLoopbackCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLANCheckBox
            // 
            this.HandleLANCheckBox.AutoSize = true;
            this.HandleLANCheckBox.Location = new System.Drawing.Point(16, 80);
            this.HandleLANCheckBox.Name = "HandleLANCheckBox";
            this.HandleLANCheckBox.Size = new System.Drawing.Size(95, 21);
            this.HandleLANCheckBox.TabIndex = 2;
            this.HandleLANCheckBox.Text = "Handle LAN";
            this.HandleLANCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.HandleSelectButton);
            this.HandleGroupBox.Controls.Add(this.HandleScanButton);
            this.HandleGroupBox.Controls.Add(this.HandleRuleRichTextBox);
            this.HandleGroupBox.Location = new System.Drawing.Point(12, 255);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(402, 330);
            this.HandleGroupBox.TabIndex = 4;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Handle rules";
            // 
            // HandleSelectButton
            // 
            this.HandleSelectButton.Location = new System.Drawing.Point(230, 18);
            this.HandleSelectButton.Name = "HandleSelectButton";
            this.HandleSelectButton.Size = new System.Drawing.Size(75, 24);
            this.HandleSelectButton.TabIndex = 0;
            this.HandleSelectButton.Text = "Select";
            this.HandleSelectButton.UseVisualStyleBackColor = true;
            this.HandleSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // HandleScanButton
            // 
            this.HandleScanButton.Location = new System.Drawing.Point(313, 18);
            this.HandleScanButton.Name = "HandleScanButton";
            this.HandleScanButton.Size = new System.Drawing.Size(75, 24);
            this.HandleScanButton.TabIndex = 1;
            this.HandleScanButton.Text = "Scan";
            this.HandleScanButton.UseVisualStyleBackColor = true;
            this.HandleScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // HandleRuleRichTextBox
            // 
            this.HandleRuleRichTextBox.AcceptsReturn = true;
            this.HandleRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandleRuleRichTextBox.Location = new System.Drawing.Point(12, 48);
            this.HandleRuleRichTextBox.Multiline = true;
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HandleRuleRichTextBox.Size = new System.Drawing.Size(378, 270);
            this.HandleRuleRichTextBox.TabIndex = 2;
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassGroupBox
            // 
            this.BypassGroupBox.Controls.Add(this.BypassSelectButton);
            this.BypassGroupBox.Controls.Add(this.BypassScanButton);
            this.BypassGroupBox.Controls.Add(this.BypassRuleRichTextBox);
            this.BypassGroupBox.Location = new System.Drawing.Point(426, 255);
            this.BypassGroupBox.Name = "BypassGroupBox";
            this.BypassGroupBox.Size = new System.Drawing.Size(402, 330);
            this.BypassGroupBox.TabIndex = 5;
            this.BypassGroupBox.TabStop = false;
            this.BypassGroupBox.Text = "Bypass rules";
            // 
            // BypassSelectButton
            // 
            this.BypassSelectButton.Location = new System.Drawing.Point(230, 18);
            this.BypassSelectButton.Name = "BypassSelectButton";
            this.BypassSelectButton.Size = new System.Drawing.Size(75, 24);
            this.BypassSelectButton.TabIndex = 0;
            this.BypassSelectButton.Text = "Select";
            this.BypassSelectButton.UseVisualStyleBackColor = true;
            this.BypassSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BypassScanButton
            // 
            this.BypassScanButton.Location = new System.Drawing.Point(313, 18);
            this.BypassScanButton.Name = "BypassScanButton";
            this.BypassScanButton.Size = new System.Drawing.Size(75, 24);
            this.BypassScanButton.TabIndex = 1;
            this.BypassScanButton.Text = "Scan";
            this.BypassScanButton.UseVisualStyleBackColor = true;
            this.BypassScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // BypassRuleRichTextBox
            // 
            this.BypassRuleRichTextBox.AcceptsReturn = true;
            this.BypassRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BypassRuleRichTextBox.Location = new System.Drawing.Point(12, 48);
            this.BypassRuleRichTextBox.Multiline = true;
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BypassRuleRichTextBox.Size = new System.Drawing.Size(378, 270);
            this.BypassRuleRichTextBox.TabIndex = 2;
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // ValidationButton
            // 
            this.ValidationButton.Location = new System.Drawing.Point(12, 598);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(120, 28);
            this.ValidationButton.TabIndex = 6;
            this.ValidationButton.Text = "Validation";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(636, 598);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(90, 28);
            this.ControlButton.TabIndex = 7;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Location = new System.Drawing.Point(738, 598);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(90, 28);
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
            this.ClientSize = new System.Drawing.Size(840, 638);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.ProtocolGroupBox);
            this.Controls.Add(this.DNSGroupBox);
            this.Controls.Add(this.ScopeGroupBox);
            this.Controls.Add(this.HandleGroupBox);
            this.Controls.Add(this.BypassGroupBox);
            this.Controls.Add(this.ValidationButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Process Mode";
            this.Load += new System.EventHandler(this.ModeForm_Load);
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
