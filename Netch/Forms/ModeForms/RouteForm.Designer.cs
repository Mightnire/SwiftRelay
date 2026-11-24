using System.ComponentModel;
using Netch.Properties;

namespace Netch.Forms.ModeForms
{
    partial class RouteForm
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
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleRuleRichTextBox = new System.Windows.Forms.TextBox();
            this.BypassGroupBox = new System.Windows.Forms.GroupBox();
            this.BypassRuleRichTextBox = new System.Windows.Forms.TextBox();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.ConfigurationGroupBox.SuspendLayout();
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
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.HandleRuleRichTextBox);
            this.HandleGroupBox.Location = new System.Drawing.Point(12, 102);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(402, 425);
            this.HandleGroupBox.TabIndex = 1;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Proxy Rule IPs";
            // 
            // HandleRuleRichTextBox
            // 
            this.HandleRuleRichTextBox.AcceptsReturn = true;
            this.HandleRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandleRuleRichTextBox.Location = new System.Drawing.Point(12, 25);
            this.HandleRuleRichTextBox.Multiline = true;
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HandleRuleRichTextBox.Size = new System.Drawing.Size(378, 385);
            this.HandleRuleRichTextBox.TabIndex = 0;
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassGroupBox
            // 
            this.BypassGroupBox.Controls.Add(this.BypassRuleRichTextBox);
            this.BypassGroupBox.Location = new System.Drawing.Point(426, 102);
            this.BypassGroupBox.Name = "BypassGroupBox";
            this.BypassGroupBox.Size = new System.Drawing.Size(402, 425);
            this.BypassGroupBox.TabIndex = 2;
            this.BypassGroupBox.TabStop = false;
            this.BypassGroupBox.Text = "Bypass Rule IPs";
            // 
            // BypassRuleRichTextBox
            // 
            this.BypassRuleRichTextBox.AcceptsReturn = true;
            this.BypassRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BypassRuleRichTextBox.Location = new System.Drawing.Point(12, 25);
            this.BypassRuleRichTextBox.Multiline = true;
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BypassRuleRichTextBox.Size = new System.Drawing.Size(378, 385);
            this.BypassRuleRichTextBox.TabIndex = 0;
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(636, 538);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(90, 28);
            this.ControlButton.TabIndex = 3;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Location = new System.Drawing.Point(738, 538);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(90, 28);
            this.CancelButtonControl.TabIndex = 4;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(840, 580);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Controls.Add(this.HandleGroupBox);
            this.Controls.Add(this.BypassGroupBox);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Route Table Rule";
            this.Load += new System.EventHandler(this.Route_Load);
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
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

        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.TextBox HandleRuleRichTextBox;

        private System.Windows.Forms.GroupBox BypassGroupBox;
        private System.Windows.Forms.TextBox BypassRuleRichTextBox;

        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;
    }
}
