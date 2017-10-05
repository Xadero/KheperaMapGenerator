namespace KheperaMapGenerator
{
    partial class MainApplication
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
            this.generatedMap = new System.Windows.Forms.PictureBox();
            this.ExportMap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kheperaManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UpArrow = new System.Windows.Forms.Button();
            this.RightArrow = new System.Windows.Forms.Button();
            this.DownArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.connectApButton = new System.Windows.Forms.Button();
            this.connetClientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generatedMap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatedMap
            // 
            this.generatedMap.BackColor = System.Drawing.SystemColors.Control;
            this.generatedMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedMap.Location = new System.Drawing.Point(509, 42);
            this.generatedMap.Name = "generatedMap";
            this.generatedMap.Size = new System.Drawing.Size(481, 591);
            this.generatedMap.TabIndex = 0;
            this.generatedMap.TabStop = false;
            this.generatedMap.Click += new System.EventHandler(this.generatedMap_Click);
            // 
            // ExportMap
            // 
            this.ExportMap.Location = new System.Drawing.Point(808, 648);
            this.ExportMap.Name = "ExportMap";
            this.ExportMap.Size = new System.Drawing.Size(182, 44);
            this.ExportMap.TabIndex = 1;
            this.ExportMap.Text = "Export map";
            this.ExportMap.UseVisualStyleBackColor = true;
            this.ExportMap.Click += new System.EventHandler(this.ExportMap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kheperaManualToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // kheperaManualToolStripMenuItem
            // 
            this.kheperaManualToolStripMenuItem.Name = "kheperaManualToolStripMenuItem";
            this.kheperaManualToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.kheperaManualToolStripMenuItem.Text = "Khepera manual";
            this.kheperaManualToolStripMenuItem.Click += new System.EventHandler(this.OpenKheperaManual);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(509, 648);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(182, 44);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpArrow
            // 
            this.UpArrow.Enabled = false;
            this.UpArrow.Location = new System.Drawing.Point(177, 542);
            this.UpArrow.Name = "UpArrow";
            this.UpArrow.Size = new System.Drawing.Size(80, 80);
            this.UpArrow.TabIndex = 5;
            this.UpArrow.Text = "Up";
            this.UpArrow.UseVisualStyleBackColor = true;
            // 
            // RightArrow
            // 
            this.RightArrow.Enabled = false;
            this.RightArrow.Location = new System.Drawing.Point(263, 628);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(80, 80);
            this.RightArrow.TabIndex = 6;
            this.RightArrow.Text = "Right";
            this.RightArrow.UseVisualStyleBackColor = true;
            // 
            // DownArrow
            // 
            this.DownArrow.Enabled = false;
            this.DownArrow.Location = new System.Drawing.Point(177, 628);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(80, 80);
            this.DownArrow.TabIndex = 7;
            this.DownArrow.Text = "Down";
            this.DownArrow.UseVisualStyleBackColor = true;
            // 
            // LeftArrow
            // 
            this.LeftArrow.Enabled = false;
            this.LeftArrow.Location = new System.Drawing.Point(91, 628);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(80, 80);
            this.LeftArrow.TabIndex = 8;
            this.LeftArrow.Text = "Left";
            this.LeftArrow.UseVisualStyleBackColor = true;
            // 
            // connectApButton
            // 
            this.connectApButton.Location = new System.Drawing.Point(44, 51);
            this.connectApButton.Name = "connectApButton";
            this.connectApButton.Size = new System.Drawing.Size(405, 52);
            this.connectApButton.TabIndex = 9;
            this.connectApButton.Text = "Connect to Access Point";
            this.connectApButton.UseVisualStyleBackColor = true;
            this.connectApButton.Click += new System.EventHandler(this.connectApButton_Click);
            // 
            // connetClientBtn
            // 
            this.connetClientBtn.Enabled = false;
            this.connetClientBtn.Location = new System.Drawing.Point(44, 175);
            this.connetClientBtn.Name = "connetClientBtn";
            this.connetClientBtn.Size = new System.Drawing.Size(405, 52);
            this.connetClientBtn.TabIndex = 10;
            this.connetClientBtn.Text = "Connect to client";
            this.connetClientBtn.UseVisualStyleBackColor = true;
            this.connetClientBtn.Click += new System.EventHandler(this.connetClientBtn_Click);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 717);
            this.Controls.Add(this.connetClientBtn);
            this.Controls.Add(this.connectApButton);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.DownArrow);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.UpArrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ExportMap);
            this.Controls.Add(this.generatedMap);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApplication";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generatedMap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox generatedMap;
        private System.Windows.Forms.Button ExportMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kheperaManualToolStripMenuItem;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectApButton;
        public System.Windows.Forms.Button UpArrow;
        public System.Windows.Forms.Button RightArrow;
        public System.Windows.Forms.Button DownArrow;
        public System.Windows.Forms.Button LeftArrow;
        public System.Windows.Forms.Button connetClientBtn;
    }
}

