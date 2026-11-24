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
            this.IPGroupBox = new System.Windows.Forms.GroupBox();
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.IPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPGroupBox
            // 
            this.IPGroupBox.Controls.Add(this.IPListBox);
            this.IPGroupBox.Controls.Add(this.IPTextBox);
            this.IPGroupBox.Controls.Add(this.PrefixComboBox);
            this.IPGroupBox.Controls.Add(this.AddButton);
            this.IPGroupBox.Location = new System.Drawing.Point(12, 10);
            this.IPGroupBox.Name = "IPGroupBox";
            this.IPGroupBox.Size = new System.Drawing.Size(336, 315);
            this.IPGroupBox.TabIndex = 0;
            this.IPGroupBox.TabStop = false;
            this.IPGroupBox.Text = "IPs";
            // 
            // IPListBox
            // 
            this.IPListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.ItemHeight = 17;
            this.IPListBox.Location = new System.Drawing.Point(12, 24);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(312, 223);
            this.IPListBox.TabIndex = 0;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(12, 268);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(185, 23);
            this.IPTextBox.TabIndex = 1;
            // 
            // PrefixComboBox
            // 
            this.PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefixComboBox.FormattingEnabled = true;
            this.PrefixComboBox.IntegralHeight = false;
            this.PrefixComboBox.Location = new System.Drawing.Point(203, 267);
            this.PrefixComboBox.MaxDropDownItems = 8;
            this.PrefixComboBox.Name = "PrefixComboBox";
            this.PrefixComboBox.Size = new System.Drawing.Size(48, 25);
            this.PrefixComboBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(257, 266);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(67, 26);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 335);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 28);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(186, 335);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(78, 28);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.Location = new System.Drawing.Point(270, 335);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(78, 28);
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
            this.ClientSize = new System.Drawing.Size(360, 375);
            this.Controls.Add(this.IPGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.CancelButtonControl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalBypassIPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Bypass IPs";
            this.Load += new System.EventHandler(this.GlobalBypassIPForm_Load);
            this.IPGroupBox.ResumeLayout(false);
            this.IPGroupBox.PerformLayout();
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
