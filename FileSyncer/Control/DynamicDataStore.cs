using System.Collections.Generic;

namespace FileSyncer.Control
{
    static class DynamicDataStore
    {
        #region Properties
        internal static List<User> Users { get; private set; }
        internal static List<SMBFolderPair> SmbFolderPairs { get; private set; }
        internal static List<FTPFolderPair> FtpFolderPairs { get; private set; }
        internal static List<SFTPFolderPair> SftpFolderPairs { get; private set; }
        internal static User LoggedInUser { get; set; }
        #endregion

        static DynamicDataStore()
        {
            Users = new List<User>();
            SmbFolderPairs = new List<SMBFolderPair>();
            FtpFolderPairs = new List<FTPFolderPair>();
            SftpFolderPairs = new List<SFTPFolderPair>();
            LoggedInUser = null;
        }  
        internal static void LoadSMBFolderPairs()
        {
            if (SmbFolderPairs.Count > 0)
            {
                SmbFolderPairs.Clear();
            }
            SmbFolderPairs = DBHandler.LoadSMBFolderPairs();
            //ApplicationLogger.AddLog("SMB FolderPairs loaded to DynamicDataStore");
        }
        internal static void LoadFTPFolderPairs()
        {
            if (FtpFolderPairs.Count > 0)
            {
                FtpFolderPairs.Clear();
            }
            FtpFolderPairs = DBHandler.LoadFTPFolderPairs();
            //ApplicationLogger.AddLog("FTP FolderPairs loaded to DynamicDataStore");
        }
        internal static void LoadSFTPFolderPairs()
        {
            //throw new NotImplementedException();
            SftpFolderPairs = DBHandler.LoadSFTPFolderPairs();
            //ApplicationLogger.AddLog("SFTP FolderPairs loaded to DynamicDataStore");
        }
        internal static void LoadUsers()
        {
            if (Users.Count > 0)
            {
                Users.Clear();
            }
            Users = DBHandler.LoadUsers();
            //ApplicationLogger.AddLog("UserList loaded to DynamicDataStore");
        }
    }
}
