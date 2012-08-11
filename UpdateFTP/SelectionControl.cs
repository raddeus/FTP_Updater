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

namespace UpdateFTP
{
    public partial class SelectionControl : UserControl
    {

        public SelectionControl()
        {
            InitializeComponent();
        }

        public frmMain ParentWindow { get; set; }
        public Dictionary<string, FileInfo> localFiles { get; set; }
        public Dictionary<string, FTPFile> ftpFiles { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ParentWindow.settingsControl1.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ParentWindow.informationControl1.Visible = true;
            ParentWindow.informationControl1.DownloadList = getDownloadList();
            ParentWindow.informationControl1.runPopulate();
        }

        private Dictionary<String, bool> getDownloadList()
        {
            Dictionary<String, bool> downloadList = new Dictionary<String, bool>();
            foreach (string s in cklistNewFiles.CheckedItems)
            {
                downloadList.Add(s, true);
            }
            foreach (string s in cklistUpdateFiles.CheckedItems)
            {
                downloadList.Add(s, false);
            }
            return downloadList;
        }

        private void SelectionControl_VisibleChanged(object sender, EventArgs e)
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
            cklistNewFiles.Items.Clear();
            cklistUpdateFiles.Items.Clear();

            Thread t = new Thread(Populate);
            t.Start();
        }

        private void Populate()
        {

            this.Invoke((MethodInvoker)delegate
            {
                cklistNewFiles.Enabled = false;
                cklistUpdateFiles.Enabled = false;
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                btnNewSelectAll.Enabled = false;
                btnNewClear.Enabled = false;
                btnUpdateClear.Enabled = false;
                btnUpdateSelectAll.Enabled = false;
            });


            if (ParentWindow.ftpConnection.ftp.IsConnected)
            {
               localFiles = ParentWindow.ftpConnection.GetLocalFiles();
              ftpFiles = ParentWindow.ftpConnection.GetFTPFiles();

                int count = 0;
                int popCount = 0;
                int totalCount = ftpFiles.Count;
                    foreach (FTPFile ftpFile in ftpFiles.Values)
                    {
                        
                        //Update Progress
                        count++;
                        ParentWindow.Invoke((MethodInvoker)delegate
                        {
                            ParentWindow.pBar.Value = count * 100 / totalCount;
                            ParentWindow.lblStatus.Text = "Populating Lists: "+count+"/"+totalCount;
                        });

                        if (localFiles.ContainsKey(ftpFile.Name))
                        {
                            //UPDATE FILE LIST HERE
                            FileInfo localFile = localFiles[ftpFile.Name];

                                if (localFile.LastWriteTime < ftpFile.LastModified)
                                {
                                    popCount++;
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        cklistUpdateFiles.Items.Add(ftpFile.Name);
                                    });

                                }
                            
                        }
                        else
                        {
                            popCount++;
                            this.Invoke((MethodInvoker)delegate
                            {
                                cklistNewFiles.Items.Add(ftpFile.Name);
                            });
                        }


                }
                    ParentWindow.Invoke((MethodInvoker)delegate
                    {
                        ParentWindow.pBar.Value = 0;
                        ParentWindow.lblStatus.Text = popCount + " Items Populated.";
                    });
            }

            this.Invoke((MethodInvoker)delegate
            {
                cklistNewFiles.Enabled = true;
                cklistUpdateFiles.Enabled = true;
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNewSelectAll.Enabled = true;
                btnNewClear.Enabled = true;
                btnUpdateClear.Enabled = true;
                btnUpdateSelectAll.Enabled = true;
            });

        }

        private void btnNewSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cklistNewFiles.Items.Count; i++)
            {
                cklistNewFiles.SetItemChecked(i, true);
            }
        }

        private void btnNewClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cklistNewFiles.Items.Count; i++)
            {
                cklistNewFiles.SetItemChecked(i, false);
            }
        }

        private void btnUpdateSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cklistUpdateFiles.Items.Count; i++)
            {
                cklistUpdateFiles.SetItemChecked(i, true);
            }
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cklistUpdateFiles.Items.Count; i++)
            {
                cklistUpdateFiles.SetItemChecked(i, false);
            }
        }

    }
}
