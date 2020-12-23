using FileSyncer.Control;
using System;
using System.Windows.Forms;
using FileSyncer.Entity;

namespace FileSyncer.Boundary
{
    public partial class userFRM : Form
    {
        User user;
        public userFRM()
        {
            InitializeComponent();
            textBox_id.Enabled = false;
            textBox_id.Text = "N/A";
        }
        internal userFRM(User mod)
        {
            InitializeComponent();
            user = mod;
            textBox_id.Text = user.Id.ToString();
            textBox_id.Enabled = false;
            textBox_username.Text = user.UserName;
            textBox_password.Text = user.PassWord;
        }
        
        private void userFRM_Load(object sender, EventArgs e)
        {
            //DynamicDataStore.LoadUsers();
            comboBox_userlevel.DataSource = UserLevels.Levels;         
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_username.Text) && !string.IsNullOrEmpty(textBox_password.Text))
            {
                if (user == null) // add new user
                {
                    if (!Validator.Password(textBox_password.Text))
                    {
                        StandardMessages.ShowMessageBox_WeekPassword();
                        DialogResult = DialogResult.None;
                    }
                    else
                    {
                        user = new User(textBox_username.Text, Helper.sha256_hash(textBox_password.Text), comboBox_userlevel.Text);
                        DBHandler.AddUser(user);
                        ApplicationLogger.AddLog($"User: {user.UserName} added - UserLevel: {user.UserLevel}");
                        //DynamicDataStore.LoadUsers();
                    }
                }
                else    // modify existing user
                {
                    user.UserName = textBox_username.Text;
                    user.PassWord = Helper.sha256_hash(textBox_password.Text);
                    user.UserLevel = comboBox_userlevel.SelectedItem.ToString();
                    DBHandler.UpdateUser(user);
                    ApplicationLogger.AddLog($"User: {user.UserName} modified - UserLevel: {user.UserLevel}");
                }
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                DialogResult = DialogResult.None;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
