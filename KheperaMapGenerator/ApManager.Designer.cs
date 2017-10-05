namespace KheperaMapGenerator
{
    partial class ApManager
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
            this.apList = new System.Windows.Forms.ListView();
            this.AP_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignalStr_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apSearchButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SsidLabel = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // apList
            // 
            this.apList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AP_Column,
            this.SignalStr_Column});
            this.apList.GridLines = true;
            this.apList.Location = new System.Drawing.Point(12, 12);
            this.apList.Name = "apList";
            this.apList.Size = new System.Drawing.Size(312, 245);
            this.apList.TabIndex = 0;
            this.apList.UseCompatibleStateImageBehavior = false;
            this.apList.View = System.Windows.Forms.View.Details;
            this.apList.SelectedIndexChanged += new System.EventHandler(this.apList_SelectedIndexChanged);
            // 
            // AP_Column
            // 
            this.AP_Column.Text = "Access Point";
            this.AP_Column.Width = 144;
            // 
            // SignalStr_Column
            // 
            this.SignalStr_Column.Text = "Signal Strenght";
            this.SignalStr_Column.Width = 104;
            // 
            // apSearchButton
            // 
            this.apSearchButton.Location = new System.Drawing.Point(347, 20);
            this.apSearchButton.Name = "apSearchButton";
            this.apSearchButton.Size = new System.Drawing.Size(204, 48);
            this.apSearchButton.TabIndex = 2;
            this.apSearchButton.Text = "Search";
            this.apSearchButton.UseVisualStyleBackColor = true;
            this.apSearchButton.Click += new System.EventHandler(this.apSearchButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(342, 219);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(105, 23);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.conenctToAp_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(453, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "SSID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // SsidLabel
            // 
            this.SsidLabel.AutoSize = true;
            this.SsidLabel.Enabled = false;
            this.SsidLabel.Location = new System.Drawing.Point(424, 147);
            this.SsidLabel.Name = "SsidLabel";
            this.SsidLabel.Size = new System.Drawing.Size(0, 17);
            this.SsidLabel.TabIndex = 10;
            // 
            // passwordTb
            // 
            this.passwordTb.Enabled = false;
            this.passwordTb.Location = new System.Drawing.Point(427, 181);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(100, 22);
            this.passwordTb.TabIndex = 11;
            // 
            // ApManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.SsidLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.apSearchButton);
            this.Controls.Add(this.apList);
            this.Name = "ApManager";
            this.Text = "Access Point";
            this.Load += new System.EventHandler(this.ApManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader AP_Column;
        private System.Windows.Forms.ColumnHeader SignalStr_Column;
        private System.Windows.Forms.Button apSearchButton;
        public System.Windows.Forms.ListView apList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label SsidLabel;
        private System.Windows.Forms.TextBox passwordTb;
    }
}