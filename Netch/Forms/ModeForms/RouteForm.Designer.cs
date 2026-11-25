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
            var rootLayout = new System.Windows.Forms.TableLayoutPanel();
            var configTable = new System.Windows.Forms.TableLayoutPanel();
            var rulesLayout = new System.Windows.Forms.TableLayoutPanel();
            var bottomLayout = new System.Windows.Forms.TableLayoutPanel();

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

            rootLayout.SuspendLayout();
            configTable.SuspendLayout();
            rulesLayout.SuspendLayout();
            bottomLayout.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.BypassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.Controls.Add(this.ConfigurationGroupBox, 0, 0);
            rootLayout.Controls.Add(rulesLayout, 0, 1);
            rootLayout.Controls.Add(bottomLayout, 0, 2);
            rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rootLayout.Location = new System.Drawing.Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new System.Windows.Forms.Padding(12);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.Size = new System.Drawing.Size(840, 580);
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
            rulesLayout.TabIndex = 1;
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.HandleRuleRichTextBox);
            this.HandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.HandleGroupBox.TabIndex = 1;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Proxy Rule IPs";
            // 
            // HandleRuleRichTextBox
            // 
            this.HandleRuleRichTextBox.AcceptsReturn = true;
            this.HandleRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandleRuleRichTextBox.Multiline = true;
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HandleRuleRichTextBox.TabIndex = 0;
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassGroupBox
            // 
            this.BypassGroupBox.Controls.Add(this.BypassRuleRichTextBox);
            this.BypassGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassGroupBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BypassGroupBox.Name = "BypassGroupBox";
            this.BypassGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.BypassGroupBox.TabIndex = 2;
            this.BypassGroupBox.TabStop = false;
            this.BypassGroupBox.Text = "Bypass Rule IPs";
            // 
            // BypassRuleRichTextBox
            // 
            this.BypassRuleRichTextBox.AcceptsReturn = true;
            this.BypassRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassRuleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BypassRuleRichTextBox.Multiline = true;
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BypassRuleRichTextBox.TabIndex = 0;
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // bottomLayout
            // 
            bottomLayout.AutoSize = true;
            bottomLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            bottomLayout.ColumnCount = 3;
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.Controls.Add(this.ControlButton, 1, 0);
            bottomLayout.Controls.Add(this.CancelButtonControl, 2, 0);
            bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomLayout.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            bottomLayout.Name = "bottomLayout";
            bottomLayout.RowCount = 1;
            bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.TabIndex = 2;
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ControlButton.MinimumSize = new System.Drawing.Size(90, 28);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ControlButton.TabIndex = 3;
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
            this.Controls.Add(rootLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Route Table Rule";
            this.Load += new System.EventHandler(this.Route_Load);
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            configTable.ResumeLayout(false);
            configTable.PerformLayout();
            rulesLayout.ResumeLayout(false);
            bottomLayout.ResumeLayout(false);
            bottomLayout.PerformLayout();
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
