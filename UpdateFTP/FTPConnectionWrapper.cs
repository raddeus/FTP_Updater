using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnterpriseDT.Net.Ftp;
using System.Windows.Forms;
using System.IO;

namespace UpdateFTP
{
    public class FTPConnectionWrapper
    {
        public FTPConnection ftp{ get; set; }

        public string hostRootDir { get; set; }
        public string localRootDir { get; set; }
        public Settings settings { get; set; }

        public FTPConnectionWrapper(FTPConnection ftp)
        {
            if (ftp != null)
            {
                this.ftp = ftp;
            }
            else
            {
                this.ftp = new FTPConnection();
            }
        }

        public FTPConnectionWrapper() : this(new FTPConnection()) { }


        public void ApplySettings(Settings settings)
        {
            this.settings = settings;
            ftp.ServerAddress = settings.address;
            ftp.UserName = settings.user;
            ftp.Password = settings.pass;
            this.hostRootDir = settings.ftpPath;
            this.localRootDir = settings.destinationPath;
        }

        public bool IsConnected()
        {
            return ftp.IsConnected;
            
        }

        public void Connect()
        {

            if (!ftp.IsConnected)
            {
                try
                {

                    ftp.Connect();

                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }

        internal void DisConnect()
        {
            ftp.Close();
        }


                public Dictionary<string, FTPFile> GetFTPFiles()
        {
            
            try
            {
                FTPFile[] filesDirectories = ftp.GetFileInfos();
                Dictionary<string, FTPFile> files = new Dictionary<string, FTPFile>();

                foreach (FTPFile f in filesDirectories)
                {
                    if (!f.Dir)
                        files.Add(f.Name, f);
                }

                return files;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        //public List<FTPFile> GetFTPFiles()
        //{
            
        //    try
        //    {
        //        FTPFile[] filesDirectories = ftp.GetFileInfos();
        //        List<FTPFile> files = new List<FTPFile>();

        //        foreach (FTPFile f in filesDirectories)
        //        {
        //            if (!f.Dir)
        //                files.Add(f);
        //        }

        //        return files;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}


                public Dictionary<string, FileInfo> GetLocalFiles()
                {
                    string[] filePaths = Directory.GetFiles(localRootDir);
                    Dictionary<string, FileInfo> fileList = new Dictionary<string, FileInfo>();
                    foreach (string filePath in filePaths)
                    {
                        LocalFile file = new LocalFile();
                        FileInfo fileInfo = new FileInfo(filePath);
                        fileList.Add(fileInfo.Name, fileInfo);
                    }
                    return fileList;
                }

        //public List<FileInfo> GetLocalFiles()
        //{
        //    string[] filePaths = Directory.GetFiles(localRootDir);
        //    List<FileInfo> fileList = new List<FileInfo>();           
        //    foreach (string filePath in filePaths)
        //    {
        //        LocalFile file = new LocalFile();
        //        FileInfo fileInfo = new FileInfo(filePath);
        //        fileList.Add(fileInfo);
        //    }
        //    return fileList;
        //}

        public bool compareTimes(FTPFile ftpFile, FileInfo localFile)
        {
            DateTime localTime = localFile.LastWriteTime;
            DateTime ftpTime = ftpFile.LastModified;
            return (localTime < ftpTime);
        }





    }
}
