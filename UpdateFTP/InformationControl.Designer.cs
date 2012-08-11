namespace UpdateFTP
{
    partial class InformationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.listBoxDownloads = new System.Windows.Forms.ListBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 74);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "<- Select Files";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(341, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 74);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Download ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listBoxDownloads
            // 
            this.listBoxDownloads.FormattingEnabled = true;
            this.listBoxDownloads.Location = new System.Drawing.Point(16, 13);
            this.listBoxDownloads.Name = "listBoxDownloads";
            this.listBoxDownloads.Size = new System.Drawing.Size(470, 173);
            this.listBoxDownloads.TabIndex = 32;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(18, 200);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(22, 13);
            this.lblSize.TabIndex = 33;
            this.lblSize.Text = "-----";
            // 
            // InformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.listBoxDownloads);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Name = "InformationControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.InformationControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox listBoxDownloads;
        private System.Windows.Forms.Label lblSize;
    }
}
