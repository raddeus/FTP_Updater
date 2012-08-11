using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnterpriseDT.Net.Ftp;
using System.Threading;
using System.IO;

namespace UpdateFTP
{
    public partial class InformationControl : UserControl
    {
 
        public FTPConnection ftp { get; set; }
        public Dictionary<String, bool> DownloadList { get; set; }


        public Dictionary<string, FileInfo> localFiles { get; set; }
        public Dictionary<string, FTPFile> ftpFiles { get; set; }


        public InformationControl(){
            InitializeComponent();
        }

        public frmMain ParentWindow { get; set; }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ParentWindow.downloadControl1.Visible = true;
            ParentWindow.downloadControl1.DownloadList = DownloadList;
            ParentWindow.downloadControl1.TotalDownloadSize = sizeBytes;
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ParentWindow.selectionControl1.Visible = true;
            this.Visible = false;
        }

        private void InformationControl_VisibleChanged(object sender, EventArgs e)
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


        public void runPopulate()
        {
            listBoxDownloads.Items.Clear();
            Thread t = new Thread(Populate);
            t.Start();
        }

        private void Populate()
        {

            this.Invoke((MethodInvoker)delegate
            {
                listBoxDownloads.Enabled = false;
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            });


            localFiles = ParentWindow.ftpConnection.GetLocalFiles();
            ftpFiles = ParentWindow.ftpConnection.GetFTPFiles();

            int totalCount = DownloadList.Keys.Count;
            int count = 0;
            sizeBytes = 0L;

            foreach (String s in DownloadList.Keys)
            {
                count++;

                sizeBytes += ftpFiles[s].Size;

                this.Invoke((MethodInvoker)delegate
                {
                    listBoxDownloads.Items.Add(s);
                    lblSize.Text = "Total Download Size: " + FormatBytes(sizeBytes);
                });

                ParentWindow.Invoke((MethodInvoker)delegate
                {
                    ParentWindow.pBar.Value = count * 100 / totalCount;
                    ParentWindow.lblStatus.Text = "Populating Lists: " + count + "/" + totalCount;
                });


            }

            this.Invoke((MethodInvoker)delegate
            {
                listBoxDownloads.Enabled = true;
                btnBack.Enabled = true;
                btnNext.Enabled = true;
            });

        }

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




        public long sizeBytes { get; set; }
    }
}


