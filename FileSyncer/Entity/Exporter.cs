using System;
using System.IO;
using System.Windows.Forms;
using FileSyncer.Control;

namespace FileSyncer.Entity
{
    static class Exporter
    {
        public static void Users()
        {
            var frm = new FolderBrowserDialog();
            frm.Description = "Save Users to:";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GenericCSVHandler<User>.WriteWithHeaders(DynamicDataStore.Users, Path.Combine(frm.SelectedPath, "Filesyncer_User_Export.csv"));
            }
        }
        public static void FolderPairs()
        {
            var frm = new FolderBrowserDialog();
            frm.Description = "Save FolderPairs to:";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (DynamicDataStore.SmbFolderPairs.Count > 0)
                {
                    GenericCSVHandler<SMBFolderPair>.WriteWithHeaders(DynamicDataStore.SmbFolderPairs, Path.Combine(frm.SelectedPath, "Filesyncer_SMB_FolderPairs_Export.csv"));
                }
                if (DynamicDataStore.FtpFolderPairs.Count > 0)
                {
                    GenericCSVHandler<FTPFolderPair>.WriteWithHeaders(DynamicDataStore.FtpFolderPairs, Path.Combine(frm.SelectedPath, "Filesyncer_FTP_FolderPairs_Export.csv"));
                }
                if (DynamicDataStore.SftpFolderPairs.Count > 0)
                {
                    GenericCSVHandler<TFTPFolderPair>.WriteWithHeaders(DynamicDataStore.SftpFolderPairs, Path.Combine(frm.SelectedPath, "Filesyncer_SFTP_FolderPairs_Export.csv"));
                }         
            }
        }
        internal static void Logs()
        {
            //throw new NotImplementedException();
            var fbd = new FolderBrowserDialog();
            fbd.Description = "Save logs to:";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                LogWriter.WriteLogs(Path.Combine(fbd.SelectedPath, $"FileSyncerLog_{DateTime.Now.ToString("yyyy-MM-dd__HH_mm_ss")}.txt"));
            }
        }
    }
}
