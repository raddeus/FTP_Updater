using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnterpriseDT.Net.Ftp;
using System.IO;

namespace UpdateFTP
{
    public partial class frmMain : Form
    {

        public FTPConnectionWrapper ftpConnection { get; set; }

        public frmMain()
        {
            ftpConnection = new FTPConnectionWrapper();
            InitializeComponent();

            settingsControl1.ParentWindow = this;
            informationControl1.ParentWindow = this;
            selectionControl1.ParentWindow = this;
            downloadControl1.ParentWindow = this;

            settingsControl1.Visible = true;
            informationControl1.Visible = false;
            selectionControl1.Visible = false;
            downloadControl1.Visible = false;

            ftpConnection.ftp.Connecting += new FTPConnectionEventHandler(ftp_Connecting);
            ftpConnection.ftp.Closing += new FTPConnectionEventHandler(ftp_Closing);
            ftpConnection.ftp.Connected += new FTPConnectionEventHandler(ftp_Connected);
            ftpConnection.ftp.Closed += new FTPConnectionEventHandler(ftp_Closed);
        }

        void ftp_Closed(object sender, FTPConnectionEventArgs e)
        {
            lblStatus.Text = "Disconnected";
        }

        void ftp_Connected(object sender, FTPConnectionEventArgs e)
        {
            lblStatus.Text = "Connected";
        }

        void ftp_Closing(object sender, FTPConnectionEventArgs e)
        {
            lblStatus.Text = "Disconnecting...";
        }

        void ftp_Connecting(object sender, FTPConnectionEventArgs e)
        {
            lblStatus.Text = "Connecting...";
        }

 
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the form tries to close in the middle of a download, handle it.
        }

        private void settingsControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
