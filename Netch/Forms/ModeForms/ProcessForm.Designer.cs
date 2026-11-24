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
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleTCPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleUDPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleICMPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.ICMPDelayLabel = new System.Windows.Forms.Label();
            this.ICMPDelayTextBox = new System.Windows.Forms.TextBox();
            this.HandleChildProcCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.DNSLabel = new System.Windows.Forms.Label();
            this.DNSTextBox = new System.Windows.Forms.TextBox();
            this.ProxyDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleProcDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleLoopbackCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleLANCheckBox = new System.Windows.Forms.CheckBox();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleSelectButton = new System.Windows.Forms.Button();
            this.HandleScanButton = new System.Windows.Forms.Button();
            this.HandleRuleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BypassGroupBox = new System.Windows.Forms.GroupBox();
            this.BypassSelectButton = new System.Windows.Forms.Button();
            this.BypassScanButton = new System.Windows.Forms.Button();
            this.BypassRuleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.ConfigurationGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
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
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.HandleTCPCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleUDPCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleICMPCheckBox);
            this.OptionsGroupBox.Controls.Add(this.ICMPDelayLabel);
            this.OptionsGroupBox.Controls.Add(this.ICMPDelayTextBox);
            this.OptionsGroupBox.Controls.Add(this.HandleChildProcCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleDNSCheckBox);
            this.OptionsGroupBox.Controls.Add(this.DNSLabel);
            this.OptionsGroupBox.Controls.Add(this.DNSTextBox);
            this.OptionsGroupBox.Controls.Add(this.ProxyDNSCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleProcDNSCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleLoopbackCheckBox);
            this.OptionsGroupBox.Controls.Add(this.HandleLANCheckBox);
            this.OptionsGroupBox.Controls.Add(this.ValidationButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 102);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(816, 125);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Mode specific options";
            // 
            // HandleTCPCheckBox
            // 
            this.HandleTCPCheckBox.AutoCheck = false;
            this.HandleTCPCheckBox.AutoSize = true;
            this.HandleTCPCheckBox.Location = new System.Drawing.Point(16, 25);
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
            this.HandleUDPCheckBox.Location = new System.Drawing.Point(125, 25);
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
            this.HandleICMPCheckBox.Location = new System.Drawing.Point(235, 25);
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
            this.ICMPDelayLabel.Location = new System.Drawing.Point(350, 27);
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.Size = new System.Drawing.Size(97, 17);
            this.ICMPDelayLabel.TabIndex = 3;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.Location = new System.Drawing.Point(455, 23);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(55, 23);
            this.ICMPDelayTextBox.TabIndex = 4;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HandleChildProcCheckBox
            // 
            this.HandleChildProcCheckBox.AutoCheck = false;
            this.HandleChildProcCheckBox.AutoSize = true;
            this.HandleChildProcCheckBox.Location = new System.Drawing.Point(540, 25);
            this.HandleChildProcCheckBox.Name = "HandleChildProcCheckBox";
            this.HandleChildProcCheckBox.Size = new System.Drawing.Size(147, 21);
            this.HandleChildProcCheckBox.TabIndex = 5;
            this.HandleChildProcCheckBox.Text = "Handle child process";
            this.HandleChildProcCheckBox.ThreeState = true;
            this.HandleChildProcCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleDNSCheckBox
            // 
            this.HandleDNSCheckBox.AutoCheck = false;
            this.HandleDNSCheckBox.AutoSize = true;
            this.HandleDNSCheckBox.Location = new System.Drawing.Point(16, 57);
            this.HandleDNSCheckBox.Name = "HandleDNSCheckBox";
            this.HandleDNSCheckBox.Size = new System.Drawing.Size(189, 21);
            this.HandleDNSCheckBox.TabIndex = 6;
            this.HandleDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.HandleDNSCheckBox.ThreeState = true;
            this.HandleDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSLabel
            // 
            this.DNSLabel.AutoSize = true;
            this.DNSLabel.Location = new System.Drawing.Point(220, 59);
            this.DNSLabel.Name = "DNSLabel";
            this.DNSLabel.Size = new System.Drawing.Size(34, 17);
            this.DNSLabel.TabIndex = 7;
            this.DNSLabel.Text = "DNS";
            // 
            // DNSTextBox
            // 
            this.DNSTextBox.Location = new System.Drawing.Point(260, 54);
            this.DNSTextBox.Name = "DNSTextBox";
            this.DNSTextBox.Size = new System.Drawing.Size(120, 23);
            this.DNSTextBox.TabIndex = 8;
            this.DNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoCheck = false;
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(400, 57);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(180, 21);
            this.ProxyDNSCheckBox.TabIndex = 9;
            this.ProxyDNSCheckBox.Text = "Handle DNS through proxy";
            this.ProxyDNSCheckBox.ThreeState = true;
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.AutoCheck = false;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.Location = new System.Drawing.Point(585, 57);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.Size = new System.Drawing.Size(206, 21);
            this.HandleProcDNSCheckBox.TabIndex = 10;
            this.HandleProcDNSCheckBox.Text = "Handle handled process\'s DNS";
            this.HandleProcDNSCheckBox.ThreeState = true;
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLoopbackCheckBox
            // 
            this.HandleLoopbackCheckBox.AutoSize = true;
            this.HandleLoopbackCheckBox.Location = new System.Drawing.Point(16, 89);
            this.HandleLoopbackCheckBox.Name = "HandleLoopbackCheckBox";
            this.HandleLoopbackCheckBox.Size = new System.Drawing.Size(155, 21);
            this.HandleLoopbackCheckBox.TabIndex = 11;
            this.HandleLoopbackCheckBox.Text = "Handle local loopback";
            this.HandleLoopbackCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLANCheckBox
            // 
            this.HandleLANCheckBox.AutoSize = true;
            this.HandleLANCheckBox.Location = new System.Drawing.Point(185, 89);
            this.HandleLANCheckBox.Name = "HandleLANCheckBox";
            this.HandleLANCheckBox.Size = new System.Drawing.Size(95, 21);
            this.HandleLANCheckBox.TabIndex = 12;
            this.HandleLANCheckBox.Text = "Handle LAN";
            this.HandleLANCheckBox.UseVisualStyleBackColor = true;
            // 
            // ValidationButton
            // 
            this.ValidationButton.Location = new System.Drawing.Point(685, 85);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(115, 26);
            this.ValidationButton.TabIndex = 13;
            this.ValidationButton.Text = "Validation";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.HandleSelectButton);
            this.HandleGroupBox.Controls.Add(this.HandleScanButton);
            this.HandleGroupBox.Controls.Add(this.HandleRuleRichTextBox);
            this.HandleGroupBox.Location = new System.Drawing.Point(12, 234);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(402, 350);
            this.HandleGroupBox.TabIndex = 2;
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
            this.HandleRuleRichTextBox.DetectUrls = false;
            this.HandleRuleRichTextBox.Location = new System.Drawing.Point(12, 48);
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.Size = new System.Drawing.Size(378, 290);
            this.HandleRuleRichTextBox.TabIndex = 2;
            this.HandleRuleRichTextBox.Text = "";
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassGroupBox
            // 
            this.BypassGroupBox.Controls.Add(this.BypassSelectButton);
            this.BypassGroupBox.Controls.Add(this.BypassScanButton);
            this.BypassGroupBox.Controls.Add(this.BypassRuleRichTextBox);
            this.BypassGroupBox.Location = new System.Drawing.Point(426, 234);
            this.BypassGroupBox.Name = "BypassGroupBox";
            this.BypassGroupBox.Size = new System.Drawing.Size(402, 350);
            this.BypassGroupBox.TabIndex = 3;
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
            this.BypassRuleRichTextBox.DetectUrls = false;
            this.BypassRuleRichTextBox.Location = new System.Drawing.Point(12, 48);
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.Size = new System.Drawing.Size(378, 290);
            this.BypassRuleRichTextBox.TabIndex = 2;
            this.BypassRuleRichTextBox.Text = "";
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(636, 596);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(90, 28);
            this.ControlButton.TabIndex = 4;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Location = new System.Drawing.Point(738, 596);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(90, 28);
            this.CancelButtonControl.TabIndex = 5;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessForm
            // 
            this.AcceptButton = this.ControlButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(840, 636);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.HandleGroupBox);
            this.Controls.Add(this.BypassGroupBox);
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
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
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

        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private SyncGlobalCheckBox HandleTCPCheckBox;
        private SyncGlobalCheckBox HandleUDPCheckBox;
        private SyncGlobalCheckBox HandleICMPCheckBox;
        private System.Windows.Forms.Label ICMPDelayLabel;
        private System.Windows.Forms.TextBox ICMPDelayTextBox;
        private SyncGlobalCheckBox HandleChildProcCheckBox;
        private SyncGlobalCheckBox HandleDNSCheckBox;
        private System.Windows.Forms.Label DNSLabel;
        private System.Windows.Forms.TextBox DNSTextBox;
        private SyncGlobalCheckBox ProxyDNSCheckBox;
        private SyncGlobalCheckBox HandleProcDNSCheckBox;
        private System.Windows.Forms.CheckBox HandleLoopbackCheckBox;
        private System.Windows.Forms.CheckBox HandleLANCheckBox;
        private System.Windows.Forms.Button ValidationButton;

        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.Button HandleSelectButton;
        private System.Windows.Forms.Button HandleScanButton;
        private System.Windows.Forms.RichTextBox HandleRuleRichTextBox;

        private System.Windows.Forms.GroupBox BypassGroupBox;
        private System.Windows.Forms.Button BypassSelectButton;
        private System.Windows.Forms.Button BypassScanButton;
        private System.Windows.Forms.RichTextBox BypassRuleRichTextBox;

        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;
    }
}
