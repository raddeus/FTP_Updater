namespace UpdateFTP
{
    partial class SettingsControl
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
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.btnFTPBrowse = new System.Windows.Forms.Button();
            this.txtDestDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFTPdir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Location = new System.Drawing.Point(366, 113);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(58, 21);
            this.btnDestinationBrowse.TabIndex = 25;
            this.btnDestinationBrowse.Text = "Browse";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // btnFTPBrowse
            // 
            this.btnFTPBrowse.Location = new System.Drawing.Point(366, 87);
            this.btnFTPBrowse.Name = "btnFTPBrowse";
            this.btnFTPBrowse.Size = new System.Drawing.Size(58, 21);
            this.btnFTPBrowse.TabIndex = 24;
            this.btnFTPBrowse.Text = "Browse";
            this.btnFTPBrowse.UseVisualStyleBackColor = true;
            this.btnFTPBrowse.Click += new System.EventHandler(this.btnFTPBrowse_Click);
            // 
            // txtDestDir
            // 
            this.txtDestDir.Location = new System.Drawing.Point(93, 114);
            this.txtDestDir.Name = "txtDestDir";
            this.txtDestDir.Size = new System.Drawing.Size(267, 20);
            this.txtDestDir.TabIndex = 23;
            this.txtDestDir.Text = "C:\\Users\\Thad\\Desktop\\FTP Update";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Destination Dir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "FTP Root Dir";
            // 
            // txtFTPdir
            // 
            this.txtFTPdir.Location = new System.Drawing.Point(93, 88);
            this.txtFTPdir.Name = "txtFTPdir";
            this.txtFTPdir.Size = new System.Drawing.Size(267, 20);
            this.txtFTPdir.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Address";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(93, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(267, 20);
            this.txtPass.TabIndex = 15;
            this.txtPass.Text = "thad";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(93, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(267, 20);
            this.txtUser.TabIndex = 14;
            this.txtUser.Text = "thad";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 10);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 20);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Text = "127.0.0.1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(341, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 74);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Select Files ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.btnFTPBrowse);
            this.Controls.Add(this.txtDestDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFTPdir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtAddress);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.SettingsControl_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDestinationBrowse;
        private System.Windows.Forms.TextBox txtDestDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Button btnFTPBrowse;
        public System.Windows.Forms.TextBox txtFTPdir;
    }
}
