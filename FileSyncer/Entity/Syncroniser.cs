using FileSyncer.Control;
using FluentFTP;
using System;
using System.Net;
using WinSCP;

namespace FileSyncer.Entity
{
    static class Syncroniser
    {
        private static int ftp_minute = 1;  // will be adjustable at runtime Bfrom GUI
        private static int sftp_minute = 1;

        internal static int Ftp_minute { get => ftp_minute; set => ftp_minute = value; }
        public static int Sftp_minute { get => sftp_minute; set => sftp_minute = value; }

        static internal async void FTP(FTPFolderPair f)
        {
            bool inBetweenSyncBoundary = f.StartSync < DateTime.Now && f.StopSync > DateTime.Now;
            if (f.Enabled && inBetweenSyncBoundary) { 
                try
                {
                    using (FtpClient ftp = new FtpClient(f.SourceIP, f.Port, new NetworkCredential(f.UserName, f.PassWord)))
                    {
                        await ftp.SetWorkingDirectoryAsync(f.SharedFolder);
                        FtpListItem[] remoteFiles = await ftp.GetListingAsync();
                        ftp.Connect();
                        await ftp.DownloadDirectoryAsync(f.DestinationFolder, f.SharedFolder, FtpFolderSyncMode.Update, FtpLocalExists.Append, FtpVerify.Retry);

                        var permission = ftp.GetFilePermissions(ftp.GetWorkingDirectory());
                        try
                        {
                            if (f.DeleteSourceFiles)
                            {
                                foreach (var item in remoteFiles)
                                {
                                    ftp.DeleteFile(item.FullName);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            ApplicationLogger.AddLog($"Deletion is not allowed in {f.FriendlyName} Remote Folder");
                        }
                    }
                }
                catch (Exception)
                {
                    ApplicationLogger.AddLog($"Error while FTP syncing {f.FriendlyName}");
                }
            }
            else
            {
                ApplicationLogger.AddLog($"{f.FriendlyName} was not synced - Enable it or set Time Boundaries");
            }
        }

        static internal void SFTP(SFTPFolderPair f)
        {
            bool inBetweenSyncBoundary = f.StartSync < DateTime.Now && f.StopSync > DateTime.Now;
            if (f.Enabled &&inBetweenSyncBoundary)
            {
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = f.IP,
                    UserName = f.UserName,
                    Password = f.PassWord,
                    PortNumber = f.Port,
                    GiveUpSecurityAndAcceptAnySshHostKey = true,
                };
                try
                {
                    using (Session session = new Session())
                    {
                        session.Open(sessionOptions);
                        session.GetFiles(f.SharedFolder, f.DestinationFolder, f.DeleteSourceFiles);  // true if src remove after download
                        session.Close();
                    }
                }
                catch (SessionException ex)
                {
                    if (ex.ToString().Contains("Authentication failed"))
                    {
                        ApplicationLogger.AddLog($"{f.FriendlyName} authentication error\n {ex}");
                    }
                    else if (ex.ToString().Contains("timed out"))
                    {
                        ApplicationLogger.AddLog($"{f.FriendlyName} timed out\n {ex}");
                    }
                    else
                    {
                        ApplicationLogger.AddLog($"{f.FriendlyName} session error: {ex}");
                    }
                }
            }
            else
            {
                ApplicationLogger.AddLog($"{f.FriendlyName} was not synced - Enable it or set Time Boundaries");
            }              
        }
    }
}
