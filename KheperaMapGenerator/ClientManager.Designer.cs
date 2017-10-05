namespace KheperaMapGenerator
{
    partial class ClientManager
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
            this.connectToClientBtn = new System.Windows.Forms.Button();
            this.clientSearchButton = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.ListView();
            this.hostname_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mac_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // connectToClientBtn
            // 
            this.connectToClientBtn.Enabled = false;
            this.connectToClientBtn.Location = new System.Drawing.Point(534, 91);
            this.connectToClientBtn.Name = "connectToClientBtn";
            this.connectToClientBtn.Size = new System.Drawing.Size(204, 52);
            this.connectToClientBtn.TabIndex = 9;
            this.connectToClientBtn.Text = "Connect";
            this.connectToClientBtn.UseVisualStyleBackColor = true;
            this.connectToClientBtn.Click += new System.EventHandler(this.connectToClientBtn_Click);
            // 
            // clientSearchButton
            // 
            this.clientSearchButton.Location = new System.Drawing.Point(534, 25);
            this.clientSearchButton.Name = "clientSearchButton";
            this.clientSearchButton.Size = new System.Drawing.Size(204, 48);
            this.clientSearchButton.TabIndex = 8;
            this.clientSearchButton.Text = "Search";
            this.clientSearchButton.UseVisualStyleBackColor = true;
            this.clientSearchButton.Click += new System.EventHandler(this.clientSearchButton_Click);
            // 
            // clientList
            // 
            this.clientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hostname_Column,
            this.ip_column,
            this.mac_Column});
            this.clientList.GridLines = true;
            this.clientList.Location = new System.Drawing.Point(12, 12);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(483, 245);
            this.clientList.TabIndex = 7;
            this.clientList.UseCompatibleStateImageBehavior = false;
            this.clientList.View = System.Windows.Forms.View.Details;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // hostname_Column
            // 
            this.hostname_Column.Text = "Hostname";
            this.hostname_Column.Width = 156;
            // 
            // ip_column
            // 
            this.ip_column.Text = "IP";
            this.ip_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ip_column.Width = 137;
            // 
            // mac_Column
            // 
            this.mac_Column.Text = "MAC";
            this.mac_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mac_Column.Width = 185;
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 261);
            this.Controls.Add(this.connectToClientBtn);
            this.Controls.Add(this.clientSearchButton);
            this.Controls.Add(this.clientList);
            this.Name = "ClientManager";
            this.Text = "ClientManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectToClientBtn;
        private System.Windows.Forms.Button clientSearchButton;
        public System.Windows.Forms.ListView clientList;
        private System.Windows.Forms.ColumnHeader hostname_Column;
        private System.Windows.Forms.ColumnHeader ip_column;
        private System.Windows.Forms.ColumnHeader mac_Column;
    }
}