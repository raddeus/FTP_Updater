namespace UpdateFTP
{
    partial class DownloadControl
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
            this.pbarCurrent = new System.Windows.Forms.ProgressBar();
            this.pbarTotal = new System.Windows.Forms.ProgressBar();
            this.lblCurrentFileName = new System.Windows.Forms.Label();
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.lblTotalProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 74);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "<- View Downloads";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(341, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 74);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Start Download";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbarCurrent
            // 
            this.pbarCurrent.Location = new System.Drawing.Point(37, 59);
            this.pbarCurrent.MarqueeAnimationSpeed = 20;
            this.pbarCurrent.Name = "pbarCurrent";
            this.pbarCurrent.Size = new System.Drawing.Size(426, 38);
            this.pbarCurrent.Step = 1;
            this.pbarCurrent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarCurrent.TabIndex = 31;
            // 
            // pbarTotal
            // 
            this.pbarTotal.Location = new System.Drawing.Point(37, 131);
            this.pbarTotal.MarqueeAnimationSpeed = 20;
            this.pbarTotal.Name = "pbarTotal";
            this.pbarTotal.Size = new System.Drawing.Size(426, 38);
            this.pbarTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarTotal.TabIndex = 32;
            // 
            // lblCurrentFileName
            // 
            this.lblCurrentFileName.AutoSize = true;
            this.lblCurrentFileName.Location = new System.Drawing.Point(38, 43);
            this.lblCurrentFileName.Name = "lblCurrentFileName";
            this.lblCurrentFileName.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFileName.TabIndex = 33;
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Location = new System.Drawing.Point(38, 100);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentProgress.TabIndex = 34;
            // 
            // lblTotalProgress
            // 
            this.lblTotalProgress.AutoSize = true;
            this.lblTotalProgress.Location = new System.Drawing.Point(38, 172);
            this.lblTotalProgress.Name = "lblTotalProgress";
            this.lblTotalProgress.Size = new System.Drawing.Size(0, 13);
            this.lblTotalProgress.TabIndex = 35;
            // 
            // DownloadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalProgress);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.lblCurrentFileName);
            this.Controls.Add(this.pbarTotal);
            this.Controls.Add(this.pbarCurrent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Name = "DownloadControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.DownloadControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ProgressBar pbarCurrent;
        private System.Windows.Forms.ProgressBar pbarTotal;
        private System.Windows.Forms.Label lblCurrentFileName;
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.Label lblTotalProgress;
    }
}
