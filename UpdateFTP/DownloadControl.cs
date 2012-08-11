using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EnterpriseDT.Net.Ftp;
using System.Threading;
using System.Diagnostics;

namespace UpdateFTP
{
    public partial class DownloadControl : UserControl
    {
        private long currentDownloadSize;
        private Stopwatch stopwatch;

        public Dictionary<string, bool> DownloadList { get; set; }


        public DownloadControl()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }
        public frmMain ParentWindow { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ParentWindow.informationControl1.Visible = true;
            this.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            runDownloadFiles();
        }

        public void runDownloadFiles()
        {
            ParentWindow.ftpConnection.ftp.TransferNotifyInterval = 1024;
            ParentWindow.ftpConnection.ftp.Downloading += new FTPFileTransferEventHandler(ftp_Downloading);
            ParentWindow.ftpConnection.ftp.Downloaded += new FTPFileTransferEventHandler(ftp_Downloaded);
            ParentWindow.ftpConnection.ftp.BytesTransferred += new BytesTransferredHandler(ftp_BytesTransferred);
            Thread t = new Thread(downloadFiles);
            t.Start();
        }

        void ftp_BytesTransferred(object sender, BytesTransferredEventArgs e)
        {
            int currentPercent = (int)(e.ByteCount * 100 / currentDownloadSize);
           pbarCurrent.Value = currentPercent;
           lblCurrentProgress.Text = currentPercent + "%";
           lblCurrentFileName.Text = e.RemoteFile;
           ParentWindow.lblStatus.Text = FormatBytes(e.ByteCount) + "/" + FormatBytes(currentDownloadSize);
        }

        void ftp_Downloaded(object sender, FTPFileTransferEventArgs e)
        {
            pbarCurrent.Value = 100;
            //e.RemoteFileSize
            int totalProgress = (int)(e.RemoteFileSize * 100 / TotalDownloadSize);
            pbarTotal.Value += totalProgress;
            lblTotalProgress.Text = "Total Percent Completed: " + pbarTotal.Value + "%";
            //pbarTotal.Value++;
        }

        void ftp_Downloading(object sender, FTPFileTransferEventArgs e)
        {

        }


        private void downloadFiles()
        {
            int fileCount = DownloadList.Count;

            this.Invoke((MethodInvoker)delegate
            {
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                pbarTotal.Value = 0;
            });


            localFiles = ParentWindow.ftpConnection.GetLocalFiles();
            ftpFiles = ParentWindow.ftpConnection.GetFTPFiles();

            foreach (string filename in DownloadList.Keys)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pbarCurrent.Value = 0;
                    
                    //pbarCurrent.Maximum = 100; //Need to check for maxvalue of int before casting.

                });


                FTPFile ftpFile = ftpFiles[filename];

                if (DownloadList[filename])
                {//Download

                    currentDownloadSize = ftpFile.Size;
                    ParentWindow.ftpConnection.ftp.DownloadFile(ParentWindow.ftpConnection.localRootDir, ftpFile.Name);

                }
                else
                {
                    FileInfo localFile = localFiles[filename];
                    //UPDATE
                    //Create Hold Directory
                    //Copy file to hold directory
                    //Download File
                    //Delete File from hold directory

                    ParentWindow.ftpConnection.ftp.DownloadFile(ParentWindow.ftpConnection.localRootDir, ftpFile.Name);
                   
                }
                this.Invoke((MethodInvoker)delegate
                {
                    pbarCurrent.Value = 100;
                });
                
                
            }

            this.Invoke((MethodInvoker)delegate
            {
                pbarTotal.Value = 100;
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                lblTotalProgress.Text = "Successful File Transfer - Total Size: " + FormatBytes(TotalDownloadSize);
                btnNext.Visible = false;
            });

            ParentWindow.Invoke((MethodInvoker)delegate
            {
                ParentWindow.lblStatus.Text = "Download Complete";
            });
        }

        private void DownloadControl_VisibleChanged(object sender, EventArgs e)
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




        public Dictionary<string, System.IO.FileInfo> localFiles { get; set; }

        public Dictionary<string, EnterpriseDT.Net.Ftp.FTPFile> ftpFiles { get; set; }


        public string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 Bytes";
        }


        public long TotalDownloadSize { get; set; }
    }
}
