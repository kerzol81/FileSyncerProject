using System;
using System.Windows.Forms;
using FileSyncer.Control;

namespace FileSyncer.Boundary
{
    public partial class LoginFRM : Form
    {
        

        public LoginFRM()
        {
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_userName.Text) && !string.IsNullOrEmpty(textBox_userName.Text))
            {
                var user = DynamicDataStore.Users.Find(x => x.UserName == textBox_userName.Text);
                if (user is null)
                {
                    StandardMessages.ShowMessageBox_UserDoesntExist();
                    DialogResult = DialogResult.None;
                }else if (user.PassWord != Helper.sha256_hash(textBox_passWord.Text))
                {
                    StandardMessages.ShowMessageBox_InvalidPassword();
                    DialogResult = DialogResult.None;
                }
                else
                {
                    DynamicDataStore.LoggedInUser = user;
                    DialogResult = DialogResult.OK;   
                }
            }
            else
            {
                StandardMessages.ShowMessageBox_MissingLoginCredentials();
                DialogResult = DialogResult.None;
            }
            
        }
    }
}
