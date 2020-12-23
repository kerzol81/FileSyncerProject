using FileSyncer.Boundary;
using FileSyncer.Control;
using System;
using System.Windows.Forms;
using FileSyncer.Entity;

namespace FileSyncer
{
    public partial class UserListFRM : Form
    {
        int selectedUserID;

        public UserListFRM()
        {
            selectedUserID = 0;
            InitializeComponent();
            listView_users.MultiSelect = false;
        }
        private void UpdateUsersLSTV()
        {
            listView_users.View = View.Details;
            listView_users.MultiSelect = false;
            listView_users.Items.Clear();
            DynamicDataStore.LoadUsers();
            if (DynamicDataStore.Users.Count > 0)
            {
                foreach (var item in DynamicDataStore.Users)
                {
                    string[] row = item.ListViewRow();
                    var listviewitem = new ListViewItem(row);
                    listView_users.Tag = item;
                    listView_users.Items.Add(listviewitem);
                }
                Helper.ResizeListViewColumns(listView_users);
            }
        }
        private void UserListFRM_Load(object sender, EventArgs e)
        {
            UpdateUsersLSTV();

        }
        private void button_new_Click(object sender, EventArgs e)
        {
            var frm = new userFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UpdateUsersLSTV();
            }
            DialogResult = DialogResult.None;
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                StandardMessages.ShowMessageBox_ZeroUserSelection();
            }
            else
            {
                DynamicDataStore.LoadUsers();
                User selected = DynamicDataStore.Users.Find(x => x.Id == selectedUserID);
                var frm = new userFRM(selected);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DynamicDataStore.LoadUsers();
                    UpdateUsersLSTV();
                }
            }
            DialogResult = DialogResult.None;  // leaves the form open
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            var selected = DynamicDataStore.Users.Find(x => x.Id == selectedUserID);
            if (selected is null)
            {
                StandardMessages.ShowMessageBox_ZeroSelection();
            }
            else if (StandardMessages.ShowMessageBox_Delete_User(selectedUserID) == DialogResult.OK)
            {
                DBHandler.DeleteUser(selected);
                ApplicationLogger.AddLog($"User: {selected.UserName} deleted.");
                DynamicDataStore.LoadUsers();
                UpdateUsersLSTV();
            }
            DialogResult = DialogResult.None;  // leaves the Form open
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selected = DynamicDataStore.Users.Find(x => x.Id == selectedUserID);
            try
            {
                selectedUserID = Convert.ToInt32(listView_users.SelectedItems[0].Text);
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
