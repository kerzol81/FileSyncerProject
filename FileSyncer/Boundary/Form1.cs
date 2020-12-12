using FileSyncer.Control;
using FileSyncer.Entity;
using System;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace FileSyncer.Boundary
{
    public partial class Form1 : Form
    {
        private int selectedSMB_ID;         // these IDs will help to LINQ search in DynamicDataStore's list, when an item is picked form ListViews
        private int selectedFTP_ID;
        private int selectedSFTP_ID;

        public Form1()
        {          
            selectedSMB_ID = 0;
            selectedFTP_ID = 0;
            selectedSFTP_ID = 0;

            InitializeComponent();
            ApplicationLogger.Logging_enabled = false;
            
            // https://www.codeproject.com/Answers/745902/Does-Csharp-timers-start-new-thread#answer2
            BackgroundWorker ftp_worker = new BackgroundWorker();                       
            ftp_worker.DoWork += new DoWorkEventHandler(syncronise_FTP_FolderPairs);
            ftp_worker.RunWorkerAsync();

            BackgroundWorker sftp_worker = new BackgroundWorker();
            sftp_worker.DoWork += new DoWorkEventHandler(syncronise_SFTP_FolderPairs);
            sftp_worker.RunWorkerAsync();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            DBHandler.Connect();
            DynamicDataStore.LoadUsers();
            #region Login
            var login = new LoginFRM();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            SetControlsToUserLevel();
            #endregion  
            UpdateSMBLSTV();
            UpdateFTPLSTV();
            UpdateSFTPLSTV();            
        }

        private void SetControlsToUserLevel()
        {
            /*
                UserLevels.Levels[0] => Admin
                UserLevels.Levels[1] => Operator
                UserLevels.Levels[2] => Viewer
             */
            if (DynamicDataStore.LoggedInUser.UserLevel == UserLevels.Levels[0])
            {
                  // All Controls will be Visible, just for readability
            }
            if (DynamicDataStore.LoggedInUser.UserLevel == UserLevels.Levels[1])
            {
                HideUsermanagmentForOperator();
            }
            if (DynamicDataStore.LoggedInUser.UserLevel == UserLevels.Levels[2])
            {
                HideControlsForViewer();
            }            
        }
        private void HideControlsForViewer()
        {
            button_saveLogs.Visible = false;

            button_smb_add.Visible = false;
            button_smb_mod.Visible = false;
            button_smb_del.Visible = false;

            button_ftp_add.Visible = false;
            button_ftp_mod.Visible = false;
            button_ftp_del.Visible = false;

            button_sftp_add.Visible = false;
            button_sftp_mod.Visible = false;
            button_sftp_del.Visible = false;

            usersToolStripMenuItem.Visible = false;
        }
        private void HideUsermanagmentForOperator()
        {
            userManagmentMenuItem.Visible = false;
        }

        private void syncronise_FTP_FolderPairs(object sender, DoWorkEventArgs e)
        {
            var minute = 1;
            while (true)
            {
                foreach (var item in DynamicDataStore.FtpFolderPairs)
                {
                    Syncroniser.FTP(item);
                    ApplicationLogger.AddLog($"{item.FriendlyName} synced to {item.DestinationFolder}");              
                    System.Threading.Thread.Sleep(minute * 60 * 1000); 
                }
                minute = Syncroniser.Ftp_minute;
            }
        }

        private void syncronise_SFTP_FolderPairs(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            var minute = 1;
            while (true)
            {
                foreach (var item in DynamicDataStore.SftpFolderPairs)
                {
                    Syncroniser.SFTP(item);
                    ApplicationLogger.AddLog($"{item.FriendlyName} synced to {item.DestinationFolder}");
                    System.Threading.Thread.Sleep(minute * 60 * 1000);
                }
                minute = Syncroniser.Sftp_minute;
            }
        }
        #region ListView & Listbox Updates
        private void UpdateSMBLSTV()
        {
            //Logger.AddLog("Updating SMB listview");       
            LSTV_smb.View = View.Details;
            LSTV_smb.MultiSelect = false;
            LSTV_smb.Items.Clear();
            DynamicDataStore.LoadSMBFolderPairs();
            foreach (var item in DynamicDataStore.SmbFolderPairs)
            {
                string[] row = item.ListViewRow();
                var listviewitem = new ListViewItem(row);
                LSTV_smb.Tag = item;
                LSTV_smb.Items.Add(listviewitem);
            }
            Helper.ResizeListViewColumns(LSTV_smb);
        }
        private void UpdateFTPLSTV()
        {
            //Logger.AddLog("Updating FTP listview");       
            LSTV_ftp.View = View.Details;
            LSTV_ftp.MultiSelect = false;
            LSTV_ftp.Items.Clear();
            DynamicDataStore.LoadFTPFolderPairs();
            foreach (var item in DynamicDataStore.FtpFolderPairs)
            {
                string[] row = item.ListViewRow();
                var listviewitem = new ListViewItem(row);
                LSTV_ftp.Tag = item;
                LSTV_ftp.Items.Add(listviewitem);
            }
            Helper.ResizeListViewColumns(LSTV_ftp);
        }
        private void UpdateSFTPLSTV()
        {
            //Logger.AddLog("Updating SFTP listview");
            LSTV_sftp.View = View.Details;
            LSTV_sftp.MultiSelect = false;
            LSTV_sftp.Items.Clear();
            DynamicDataStore.LoadSFTPFolderPairs();
            foreach (var item in DynamicDataStore.SftpFolderPairs)
            {
                string[] row = item.ListViewRow();
                var listviewitem = new ListViewItem(row);
                LSTV_sftp.Tag = item;
                LSTV_sftp.Items.Add(listviewitem);
            }
            Helper.ResizeListViewColumns(LSTV_sftp);
        }
        private void UpdateLogsLSTBX()
        {
            listBox_logs.DataSource = null;
            listBox_logs.DataSource = ApplicationLogger.Logs;
            listBox_logs.SelectedIndex = -1;
            listBox_logs.Enabled = false;
        }
        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StandardMessages.ShowMessageBox_ApplicationClosing() == DialogResult.Yes)
            {
                Close();
            }
        }
        private void cSVExportUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var users = DBHandler.LoadUsers();
            GenericCSVHandler<User>.WriteWithHeaders(users, @"users.csv");
        }

        private void syslogServerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SyslogFRM();
            frm.ShowDialog();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DBHandler.Disconnect();
            }
            catch (Exception ex)
            {
                throw new DBHandlerExeption("Error while disconnecting from local DB ", ex);
            }
        }

        #region SMB section
        private void button_smb_add_Click(object sender, EventArgs e)
        {
            var frm = new SMB_FolderPairFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateSMBLSTV();
            }
        }
        private void button_smb_mod_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.SmbFolderPairs.Find(x => x.Id == selectedSMB_ID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else
            {
                var frm = new SMB_FolderPairFRM(selected);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    UpdateSMBLSTV();
                }
            }  
        }
        private void button_smb_del_Click(object sender, EventArgs e)
        {
            if (selectedSMB_ID == 0)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else if (StandardMessages.ShowMessageBox_Delete_SMBFolderPair(selectedSMB_ID) == DialogResult.OK)
            {
                var selected = DynamicDataStore.SmbFolderPairs.Find(x => x.Id == selectedSMB_ID);
                DBHandler.DeleteSMBFolderPair(selected);
                UpdateSMBLSTV();
            }
        }
        #endregion
        private void LSTV_smb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSMB_ID = Convert.ToInt32(LSTV_smb.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                //throw;
            }         
        }
        private void userManagmentMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserListFRM();
            frm.ShowDialog();
        }

        #region FTP section
        private void button_ftp_add_Click(object sender, EventArgs e)
        {
            var frm = new FTP_FolderPairFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateFTPLSTV();
            }
        }
        private void button_ftp_mod_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.FtpFolderPairs.Find(x => x.Id == selectedFTP_ID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else
            {
                var frm = new FTP_FolderPairFRM(selected);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    UpdateFTPLSTV();
                }
            }          
        }
        private void button_ftp_del_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.FtpFolderPairs.Find(x => x.Id == selectedFTP_ID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }else if (StandardMessages.ShowMessageBox_Delete_FTPFolderPair(selectedFTP_ID) == DialogResult.OK)
            {
                
                DBHandler.DeleteFTPFolderPair(selected);
                UpdateFTPLSTV();
            }
            else
            {
                ApplicationLogger.AddLog("FTP FolderPair Deletion Cancelled");
            }
        }
        private void LSTV_ftp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedFTP_ID = Convert.ToInt32(LSTV_ftp.SelectedItems[0].Text);
            }
            catch (Exception)
            {
                //throw;
            }
        }
        #endregion

        #region SFTP section
        private void button_sftp_add_Click(object sender, EventArgs e)
        {
            var frm = new SFTP_FolderPairFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateSFTPLSTV();
            }
        }

        #endregion

        #region Log Section
        private void button_clearLogs_Click(object sender, EventArgs e)
        {
            ApplicationLogger.Logs.Clear();
            UpdateLogsLSTBX();
        }

        private void button_saveLogs_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.Description = "Save logs to:";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                LogWriter.WriteLogs(Path.Combine(fbd.SelectedPath, $"FileSyncerLog_{DateTime.Now.ToString("yyyy-MM-dd__HH_mm_ss")}.txt"));
            }    
        }
        #endregion

        private void timer_Logs_Tick(object sender, EventArgs e)
        {
            UpdateLogsLSTBX();
        }

        private void fTPSyncroniseFrequencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrequencyFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ApplicationLogger.AddLog($"FTP syncronisation set to: {frm.FTPMinute} min");
            }
        }

        private void button_sftp_del_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.SftpFolderPairs.Find(x => x.Id == selectedSFTP_ID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else if (StandardMessages.ShowMessageBox_Delete_SFTPFolderPair(selectedSFTP_ID) == DialogResult.OK)
            {
                DBHandler.DeleteSFTPFolderPair(selected);
                UpdateSFTPLSTV();
            }
            else
            {
                ApplicationLogger.AddLog("SFTP FolderPair Deletion Cancelled");
            }
        }

        private void LSTV_sftp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSFTP_ID = Convert.ToInt32(LSTV_sftp.SelectedItems[0].Text);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void button_sftp_mod_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.SftpFolderPairs.Find(x => x.Id == selectedSFTP_ID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else
            {
                var frm = new SFTP_FolderPairFRM(selected);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    UpdateSFTPLSTV();
                }
            }
        }
    }
}