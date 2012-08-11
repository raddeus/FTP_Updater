using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdateFTP
{
    public partial class SettingsControl : UserControl
    {
        public frmMain ParentWindow { get; set; }
       
        public SettingsControl()
        {
            InitializeComponent();
            ftpBrowse = new FTPBrowserForm();
            
        }

        private void btnFTPBrowse_Click(object sender, EventArgs e)
        {
            ftpBrowse.ParentWindow = this.ParentWindow;
            connectFTP();
            ftpBrowse.populate();
            ftpBrowse.Show();

        }

        private void btnDestinationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
               txtDestDir.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


      public void  connectFTP(){
                     try
            {

               if (ParentWindow.ftpConnection.IsConnected())
                {
                    ParentWindow.ftpConnection.DisConnect();
                }
    
                ParentWindow.ftpConnection.ApplySettings(getSettings());
                ParentWindow.ftpConnection.Connect();

            }
            catch (Exception)
            {       
                throw;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            connectFTP();

            this.Visible = false;
            ParentWindow.selectionControl1.Visible = true;
            ParentWindow.selectionControl1.runPopulate();
        }

        private Settings getSettings()
        {
            Settings s = new Settings();
            s.address = txtAddress.Text;
            s.user = txtUser.Text;
            s.pass = txtPass.Text;
            s.destinationPath = txtDestDir.Text;
            s.ftpPath = txtFTPdir.Text;
            return s;
        }

        private void SettingsControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.BringToFront();
            }
            else
            {
                this.SendToBack();
            }
        }






        public FTPBrowserForm ftpBrowse { get; set; }
    }
}
