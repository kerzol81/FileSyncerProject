using System;
using System.Drawing;
using System.Windows.Forms;
using FileSyncer.Control;
using FileSyncer.Entity;
using WinSCP;

namespace FileSyncer.Boundary
{
    public partial class SFTP_FolderPairFRM : Form
    {
        SFTPFolderPair sftp;
        internal SFTPFolderPair Sftp { get => sftp; /*set => sftp = value;*/ }

        public SFTP_FolderPairFRM()
        {
            InitializeComponent();
        }

        internal SFTP_FolderPairFRM(SFTPFolderPair mod):this()
        {
            sftp = mod;
            textBox_friendlyName.Text = sftp.FriendlyName;
            textBox_ip.Text = sftp.IP;
            numericUpDown_port.Value = sftp.Port;
            textBox_username.Text = sftp.UserName;
            textBox_password.Text = sftp.PassWord;
            textBox_remotedir.Text = sftp.SharedFolder;
            textBox_destination.Text = sftp.DestinationFolder;
            sftp.Added = DateTime.Now;
            dateTimePicker_start.Value = sftp.StartSync;
            dateTimePicker_stop.Value = sftp.StartSync;
            checkBox_deleteSourceFiles.Checked = sftp.DeleteSourceFiles;
            checkBox_enabled.Checked = sftp.Enabled;
        }

        private void textBox_ip_MouseLeave(object sender, EventArgs e)
        {
            if (!Validator.IP(textBox_ip.Text))
            {
                StandardMessages.ShowMessageBox_InvalidIPAddress();
                textBox_ip.Focus();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (label_testing.Text != "OK")
            {
                StandardMessages.ShowMessageBox_MissedSFTPServerTest();
            }

            if (label_testing.Text == "OK" && !string.IsNullOrEmpty(textBox_destination.Text))
            {
                if (sftp == null)
                {
                    sftp = new SFTPFolderPair(textBox_friendlyName.Text,
                        textBox_ip.Text,
                        (int)numericUpDown_port.Value,
                        textBox_username.Text,
                        Xor.Encrypt(textBox_password.Text),
                        textBox_remotedir.Text,
                        textBox_destination.Text,
                        DateTime.Now,
                        dateTimePicker_start.Value,
                        dateTimePicker_stop.Value,
                        checkBox_deleteSourceFiles.Checked,
                        checkBox_enabled.Checked);

                    DBHandler.InsertSFTPFolderPair(sftp);
                }
                else
                {
                    sftp.FriendlyName = textBox_friendlyName.Text;
                    sftp.IP = textBox_ip.Text;
                    sftp.Port = (int)numericUpDown_port.Value;
                    sftp.UserName = textBox_username.Text;
                    sftp.PassWord = Xor.Encrypt(textBox_password.Text);
                    sftp.SharedFolder = textBox_remotedir.Text;
                    sftp.Added = DateTime.Now;
                    sftp.StartSync = dateTimePicker_start.Value;
                    sftp.StopSync = dateTimePicker_stop.Value;
                    sftp.DeleteSourceFiles = checkBox_deleteSourceFiles.Checked;
                    sftp.Enabled = checkBox_enabled.Checked;

                    DBHandler.UpdateSFTPFolderPair(sftp);
                }
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                DialogResult = DialogResult.None;
            }        
        }

        private void button_destination_Click(object sender, EventArgs e)
        {
            var fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox_destination.Text = fdb.SelectedPath;
            }         
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_friendlyName.Text) && 
                !string.IsNullOrEmpty(textBox_ip.Text) &&
                !string.IsNullOrEmpty(textBox_username.Text) &&
                !string.IsNullOrEmpty(textBox_password.Text) &&
                !string.IsNullOrEmpty(textBox_remotedir.Text))
            {
                label_testing.Text = "";
                label_testing.ForeColor = Color.Green;
                label_testing.Text = "Testing...";
                label_testing.ForeColor = Color.Green;

                textBox_ip.Enabled = false;
                numericUpDown_port.Enabled = false;
                textBox_username.Enabled = false;
                textBox_password.Enabled = false;
                button_test.Enabled = false;
                if (SFTPLoginOK())
                {
                    label_testing.Text = "OK";
                    label_testing.ForeColor = Color.Green;
                }
                else
                {
                    label_testing.Text = "Error";
                    label_testing.ForeColor = Color.Red;
                }

                textBox_ip.Enabled = true;
                numericUpDown_port.Enabled = true;
                textBox_username.Enabled = true;
                textBox_password.Enabled = true;
                button_test.Enabled = true;

                DialogResult = DialogResult.None;
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                DialogResult = DialogResult.None;
                textBox_friendlyName.Focus();
            }          
        }

        private bool SFTPLoginOK()
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = textBox_ip.Text,
                UserName = textBox_username.Text,
                Password = textBox_password.Text,
                PortNumber = (int)numericUpDown_port.Value,
                GiveUpSecurityAndAcceptAnySshHostKey = true,
            };
            try
            {
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);
                    session.GetFileInfo(textBox_remotedir.Text.ToString());
                    session.Close();
                    label_testing.ForeColor = Color.Green;
                    label_testing.Text = "OK";
                }
                return true;
            }
            catch (SessionException ex)
            {
                //throw;
                if (ex.ToString().Contains("Authentication failed"))
                {
                    ApplicationLogger.AddLog($"{textBox_friendlyName.Text} authentication error\n {ex}");
                    label_testing.ForeColor = Color.Red;
                    label_testing.Text = "Authentication error";
                }
                else if (ex.ToString().Contains("Timed out"))
                {
                    ApplicationLogger.AddLog($"{textBox_friendlyName.Text} timed out\n {ex}");
                    label_testing.ForeColor = Color.Red;
                    label_testing.Text = "Timed out, check IP";
                }
                else if (ex.ToString().Contains("Can't get"))
                {
                    ApplicationLogger.AddLog($"{textBox_friendlyName.Text} no {textBox_remotedir.Text} folder on server \n {ex}");
                    label_testing.ForeColor = Color.Red;
                    label_testing.Text = "Folder error";
                }

                else
                {
                    ApplicationLogger.AddLog($"{textBox_friendlyName.Text} session error: {ex}");
                    label_testing.ForeColor = Color.Red;
                    label_testing.Text = "Error";
                }
                return false;
            }
        }
        private void SFTP_FolderPairFRM_Load(object sender, EventArgs e)
        {
            textBox_friendlyName.Focus();
            checkBox_enabled.Checked = true;
        }

        private void textBox_remotedir_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in DynamicDataStore.SftpFolderPairs)
            {
                if (item.DestinationFolder == textBox_destination.Text)
                {
                    StandardMessages.ShowMessageBox_SourceFolderIsAlreadyUsed(item.Id.ToString());
                    textBox_remotedir.Clear();
                    DialogResult = DialogResult.None;
                }
            }
        }
        private void textBox_destination_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in DynamicDataStore.SftpFolderPairs)
            {
                if (item.DestinationFolder == textBox_destination.Text)
                {
                    StandardMessages.ShowMessageBox_DestinationFolderIsAlreadyUsed(item.Id.ToString());
                    textBox_destination.Clear();
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
