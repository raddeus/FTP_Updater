using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnterpriseDT.Net.Ftp;

namespace UpdateFTP
{
    public partial class FTPBrowserForm : Form
    {
        public FTPBrowserForm()
        {
            InitializeComponent();
            
        }

        public frmMain ParentWindow { get; set; }

        public void populate()
        {
            treeviewFTP.Nodes.Clear();
            FTPConnection ftp = ParentWindow.ftpConnection.ftp;
            FTPFile[] files = ftp.GetFileInfos();
            List<FTPFile> directories = new List<FTPFile>();
            foreach (FTPFile f in files)
            {
                if (f.Dir)
                {
                    directories.Add(f);
                }

            }

            TreeNode rootNode = new TreeNode(ftp.ServerAddress);
            GetDirectories(getDirectories(""), rootNode);
            treeviewFTP.Nodes.Add(rootNode);
            treeviewFTP.TopNode = rootNode;
            rootNode.ExpandAll();


        }


        private List<FTPFile> getDirectories(string path)
        {
            FTPConnection ftp = ParentWindow.ftpConnection.ftp;
            FTPFile[] files = ftp.GetFileInfos(path);
            List<FTPFile> directories = new List<FTPFile>();
            foreach (FTPFile f in files)
            {
                if (f.Dir)
                {
                    directories.Add(f);
                }

            }

            return directories;
        }

        private void GetDirectories(List<FTPFile> subDirs,
            TreeNode nodeToAddTo)
        {
            
            

            TreeNode aNode;
            List<FTPFile> subSubDirs;
            foreach (FTPFile subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                

                subSubDirs = getDirectories(subDir.Path);

                if (subSubDirs.Count != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);

            }



        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String path;
            try
            {
                path = ((FTPFile)treeviewFTP.SelectedNode.Tag).Path;
            }
            catch (Exception)
            {

                path = "/";
            }
           ParentWindow.settingsControl1.txtFTPdir.Text = path;
            this.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void treeviewFTP_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                txtPath.Text = ((FTPFile)e.Node.Tag).Path;
            }
            catch (Exception)
            {

                txtPath.Text = "/";
            }
        }


    }
}
