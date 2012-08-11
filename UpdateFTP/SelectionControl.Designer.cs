namespace UpdateFTP
{
    partial class SelectionControl
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cklistNewFiles = new System.Windows.Forms.CheckedListBox();
            this.cklistUpdateFiles = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSelectAll = new System.Windows.Forms.Button();
            this.btnNewClear = new System.Windows.Forms.Button();
            this.btnUpdateClear = new System.Windows.Forms.Button();
            this.btnUpdateSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(341, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 74);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "View/Edit Downloads ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 74);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "<- Connection Settings";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cklistNewFiles
            // 
            this.cklistNewFiles.FormattingEnabled = true;
            this.cklistNewFiles.Location = new System.Drawing.Point(3, 0);
            this.cklistNewFiles.Name = "cklistNewFiles";
            this.cklistNewFiles.Size = new System.Drawing.Size(245, 184);
            this.cklistNewFiles.TabIndex = 29;
            // 
            // cklistUpdateFiles
            // 
            this.cklistUpdateFiles.FormattingEnabled = true;
            this.cklistUpdateFiles.Location = new System.Drawing.Point(251, 0);
            this.cklistUpdateFiles.Name = "cklistUpdateFiles";
            this.cklistUpdateFiles.Size = new System.Drawing.Size(245, 184);
            this.cklistUpdateFiles.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "New Downloads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Need Updates:";
            // 
            // btnNewSelectAll
            // 
            this.btnNewSelectAll.Location = new System.Drawing.Point(91, 187);
            this.btnNewSelectAll.Name = "btnNewSelectAll";
            this.btnNewSelectAll.Size = new System.Drawing.Size(53, 24);
            this.btnNewSelectAll.TabIndex = 33;
            this.btnNewSelectAll.Text = "All";
            this.btnNewSelectAll.UseVisualStyleBackColor = true;
            this.btnNewSelectAll.Click += new System.EventHandler(this.btnNewSelectAll_Click);
            // 
            // btnNewClear
            // 
            this.btnNewClear.Location = new System.Drawing.Point(150, 187);
            this.btnNewClear.Name = "btnNewClear";
            this.btnNewClear.Size = new System.Drawing.Size(53, 24);
            this.btnNewClear.TabIndex = 34;
            this.btnNewClear.Text = "None";
            this.btnNewClear.UseVisualStyleBackColor = true;
            this.btnNewClear.Click += new System.EventHandler(this.btnNewClear_Click);
            // 
            // btnUpdateClear
            // 
            this.btnUpdateClear.Location = new System.Drawing.Point(387, 187);
            this.btnUpdateClear.Name = "btnUpdateClear";
            this.btnUpdateClear.Size = new System.Drawing.Size(53, 24);
            this.btnUpdateClear.TabIndex = 36;
            this.btnUpdateClear.Text = "None";
            this.btnUpdateClear.UseVisualStyleBackColor = true;
            this.btnUpdateClear.Click += new System.EventHandler(this.btnUpdateClear_Click);
            // 
            // btnUpdateSelectAll
            // 
            this.btnUpdateSelectAll.Location = new System.Drawing.Point(328, 187);
            this.btnUpdateSelectAll.Name = "btnUpdateSelectAll";
            this.btnUpdateSelectAll.Size = new System.Drawing.Size(53, 24);
            this.btnUpdateSelectAll.TabIndex = 35;
            this.btnUpdateSelectAll.Text = "All";
            this.btnUpdateSelectAll.UseVisualStyleBackColor = true;
            this.btnUpdateSelectAll.Click += new System.EventHandler(this.btnUpdateSelectAll_Click);
            // 
            // SelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateClear);
            this.Controls.Add(this.btnUpdateSelectAll);
            this.Controls.Add(this.btnNewClear);
            this.Controls.Add(this.btnNewSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cklistUpdateFiles);
            this.Controls.Add(this.cklistNewFiles);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Name = "SelectionControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.SelectionControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox cklistNewFiles;
        private System.Windows.Forms.CheckedListBox cklistUpdateFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewSelectAll;
        private System.Windows.Forms.Button btnNewClear;
        private System.Windows.Forms.Button btnUpdateClear;
        private System.Windows.Forms.Button btnUpdateSelectAll;
    }
}
