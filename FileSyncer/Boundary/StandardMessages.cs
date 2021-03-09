using System;
using System.Windows.Forms;

namespace FileSyncer.Boundary
{
    class StandardMessages
    {
        #region Login Related Messages
        internal static void ShowMessageBox_MissingLoginCredentials()
        {
            MessageBox.Show("Missing Credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        internal static void ShowMessageBox_UserDoesntExist()
        {
            MessageBox.Show("User Doesn't Exist.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal static void ShowMessageBox_InvalidPassword()
        {
            MessageBox.Show("Password Error.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
        public static void ShowMessageBox_ZeroSelection()
        {
            MessageBox.Show("Nothing has been selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMessageBox_EmptyFieldsOnForm()
        {
            MessageBox.Show("Fields cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void ShowMessageBox_InvalidIPAddress()
        {
            MessageBox.Show("Invalid IPv4 Address!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void ShowMessageBox_MissedFTPServerTest()
        {
            MessageBox.Show("Test Remote FTP Server!", "Missing Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal static void ShowMessageBox_MissedSFTPServerTest()
        {
            MessageBox.Show("Test Remote SFTP Server!", "Missing Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal static DialogResult ShowMessageBox_ApplicationClosing()
        {
            return MessageBox.Show("Closing the Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        internal static void ShowMessageBox_UserExists(string userName)
        {
            MessageBox.Show($"{userName} is an existing user!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #region Folder Pair
        internal static DialogResult ShowMessageBox_Delete_SMBFolderPair(int id)
        {
            return MessageBox.Show($"Deleting Entry,  are you sure?\nSMB Folder Pair ID: {id}", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        internal static DialogResult ShowMessageBox_Delete_FTPFolderPair(int id)
        {
            return MessageBox.Show($"Deleting Entry,  are you sure?\nFTP Folder Pair ID: {id}", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        

        internal static DialogResult ShowMessageBox_Delete_SFTPFolderPair(int id)
        {
            //throw new NotImplementedException();
            return MessageBox.Show($"Deleting Entry,  are you sure?\nSFTP Folder Pair ID: {id}", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        #endregion

        #region User CRUDs
        internal static DialogResult ShowMessageBox_Delete_User(int selectedUserID)
        {
            return MessageBox.Show($"Deleting User,  are you sure?\nUser ID: {selectedUserID}", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        internal static DialogResult ShowMessageBox_WeekPassword()
        {
            return MessageBox.Show("Week password, it should be: at least 8 characters, lower-upper case characters and a number!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static DialogResult ShowMessageBox_ZeroUserSelection()
        {
            return MessageBox.Show($"Select a User!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal static void ShowMessageBox_SharedFolderIsAlreadyUsed(string shared)
        {
            //throw new NotImplementedException();
            MessageBox.Show($"The Shared Folder: {shared} has been set in sync job already, select another one!", "Source Folder Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ShowMessageBox_SourceFolderIsAlreadyUsed(string id)
        {
            //throw new NotImplementedException();
            MessageBox.Show($"The Source Folder is already used in \nID:{id}", "Source Folder Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ShowMessageBox_DestinationFolderIsAlreadyUsed(string id)
        {
            //throw new NotImplementedException();
            MessageBox.Show($"The Destination Folder is already used in \nID:{id}", "Destination Folder Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ShowMessageBox_SourceSharedFolderIsAlreadyUsed(string id)
        {
            //throw new NotImplementedException();
            MessageBox.Show($"The Source Shared Folder is already used in \nID:{id}", "Source Shared Folder Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

    }
}
