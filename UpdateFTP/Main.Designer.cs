namespace UpdateFTP
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.downloadControl1 = new UpdateFTP.DownloadControl();
            this.settingsControl1 = new UpdateFTP.SettingsControl();
            this.selectionControl1 = new UpdateFTP.SelectionControl();
            this.informationControl1 = new UpdateFTP.InformationControl();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1,
            this.pBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(499, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(327, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBar
            // 
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 16);
            // 
            // downloadControl1
            // 
            this.downloadControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadControl1.DownloadList = null;
            this.downloadControl1.ftpFiles = null;
            this.downloadControl1.localFiles = null;
            this.downloadControl1.Location = new System.Drawing.Point(0, 0);
            this.downloadControl1.Name = "downloadControl1";
            this.downloadControl1.ParentWindow = null;
            this.downloadControl1.Size = new System.Drawing.Size(499, 300);
            this.downloadControl1.TabIndex = 5;
            this.downloadControl1.TotalDownloadSize = ((long)(0));
            // 
            // settingsControl1
            // 
            this.settingsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.ParentWindow = null;
            this.settingsControl1.Size = new System.Drawing.Size(499, 300);
            this.settingsControl1.TabIndex = 2;
            this.settingsControl1.Load += new System.EventHandler(this.settingsControl1_Load);
            // 
            // selectionControl1
            // 
            this.selectionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionControl1.ftpFiles = null;
            this.selectionControl1.localFiles = null;
            this.selectionControl1.Location = new System.Drawing.Point(0, 0);
            this.selectionControl1.Name = "selectionControl1";
            this.selectionControl1.ParentWindow = null;
            this.selectionControl1.Size = new System.Drawing.Size(499, 300);
            this.selectionControl1.TabIndex = 3;
            // 
            // informationControl1
            // 
            this.informationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationControl1.DownloadList = null;
            this.informationControl1.ftp = null;
            this.informationControl1.ftpFiles = null;
            this.informationControl1.localFiles = null;
            this.informationControl1.Location = new System.Drawing.Point(0, 0);
            this.informationControl1.Name = "informationControl1";
            this.informationControl1.ParentWindow = null;
            this.informationControl1.Size = new System.Drawing.Size(499, 300);
            this.informationControl1.sizeBytes = ((long)(0));
            this.informationControl1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 322);
            this.Controls.Add(this.downloadControl1);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.selectionControl1);
            this.Controls.Add(this.informationControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "FTP Auto Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripProgressBar pBar;
        public SettingsControl settingsControl1;
        public SelectionControl selectionControl1;
        public InformationControl informationControl1;
        public DownloadControl downloadControl1;
    }
}

