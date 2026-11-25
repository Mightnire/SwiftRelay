namespace Netch.Forms
{
    partial class GlobalBypassIPForm
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
            var groupLayout = new System.Windows.Forms.TableLayoutPanel();
            var inputLayout = new System.Windows.Forms.TableLayoutPanel();
            var bottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IPGroupBox = new System.Windows.Forms.GroupBox();
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            rootLayout.SuspendLayout();
            groupLayout.SuspendLayout();
            inputLayout.SuspendLayout();
            bottomLayout.SuspendLayout();
            this.IPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.Controls.Add(this.IPGroupBox, 0, 0);
            rootLayout.Controls.Add(bottomLayout, 0, 1);
            rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            rootLayout.Location = new System.Drawing.Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new System.Windows.Forms.Padding(12);
            rootLayout.RowCount = 2;
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            rootLayout.Size = new System.Drawing.Size(380, 390);
            rootLayout.TabIndex = 0;
            // 
            // IPGroupBox
            // 
            this.IPGroupBox.Controls.Add(groupLayout);
            this.IPGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.IPGroupBox.Name = "IPGroupBox";
            this.IPGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.IPGroupBox.TabIndex = 0;
            this.IPGroupBox.TabStop = false;
            this.IPGroupBox.Text = "IPs";
            // 
            // groupLayout
            // 
            groupLayout.ColumnCount = 1;
            groupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            groupLayout.Controls.Add(this.IPListBox, 0, 0);
            groupLayout.Controls.Add(inputLayout, 0, 1);
            groupLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            groupLayout.Margin = new System.Windows.Forms.Padding(0);
            groupLayout.Name = "groupLayout";
            groupLayout.RowCount = 2;
            groupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            groupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            groupLayout.TabIndex = 0;
            // 
            // IPListBox
            // 
            this.IPListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.IntegralHeight = false;
            this.IPListBox.ItemHeight = 17;
            this.IPListBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.TabIndex = 0;
            // 
            // inputLayout
            // 
            inputLayout.AutoSize = true;
            inputLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            inputLayout.ColumnCount = 3;
            inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            inputLayout.Controls.Add(this.IPTextBox, 0, 0);
            inputLayout.Controls.Add(this.PrefixComboBox, 1, 0);
            inputLayout.Controls.Add(this.AddButton, 2, 0);
            inputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            inputLayout.Margin = new System.Windows.Forms.Padding(0);
            inputLayout.Name = "inputLayout";
            inputLayout.RowCount = 1;
            inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            inputLayout.TabIndex = 1;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.TabIndex = 1;
            // 
            // PrefixComboBox
            // 
            this.PrefixComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefixComboBox.FormattingEnabled = true;
            this.PrefixComboBox.IntegralHeight = false;
            this.PrefixComboBox.Margin = new System.Windows.Forms.Padding(0, 1, 6, 1);
            this.PrefixComboBox.MaxDropDownItems = 8;
            this.PrefixComboBox.Name = "PrefixComboBox";
            this.PrefixComboBox.Size = new System.Drawing.Size(58, 25);
            this.PrefixComboBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.MinimumSize = new System.Drawing.Size(70, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            bottomLayout.Controls.Add(this.DeleteButton, 0, 0);
            bottomLayout.Controls.Add(this.ControlButton, 2, 0);
            bottomLayout.Controls.Add(this.CancelButtonControl, 3, 0);
            bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomLayout.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            bottomLayout.Name = "bottomLayout";
            bottomLayout.RowCount = 1;
            bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            bottomLayout.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(80, 28);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ControlButton.MinimumSize = new System.Drawing.Size(80, 28);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "Save";
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
            this.CancelButtonControl.TabIndex = 3;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GlobalBypassIPForm
            // 
            this.AcceptButton = this.ControlButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(380, 390);
            this.Controls.Add(rootLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "GlobalBypassIPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Bypass IPs";
            this.Load += new System.EventHandler(this.GlobalBypassIPForm_Load);
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            groupLayout.ResumeLayout(false);
            groupLayout.PerformLayout();
            inputLayout.ResumeLayout(false);
            inputLayout.PerformLayout();
            bottomLayout.ResumeLayout(false);
            bottomLayout.PerformLayout();
            this.IPGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IPGroupBox;
        private System.Windows.Forms.ListBox IPListBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.ComboBox PrefixComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button CancelButtonControl;
    }
}
