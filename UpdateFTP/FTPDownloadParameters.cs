using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnterpriseDT.Net.Ftp;

namespace UpdateFTP
{
    public class FTPDownloadParameters
    {
        public string ftpPath { get; set; }
        public string ftpName { get; set; }
        public string localPath { get; set; }
        public string localName { get; set; }
        public FTPConnection ftp { get; set; }
        public FTPDownloadParameters(FTPConnection ftp, string ftpPath, string localPath)
        {
            this.ftp = ftp;
            this.ftpPath = ftpPath;
            this.localPath = localPath;

            if (ftp.IsConnected)
            {

            }

        }
    }
}
