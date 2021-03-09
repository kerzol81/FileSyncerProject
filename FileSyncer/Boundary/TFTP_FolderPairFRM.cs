using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FileSyncer.Control;
using FileSyncer.Entity;
using WinSCP;

namespace FileSyncer.Boundary
{
    public partial class TFTP_FolderPairFRM : Form
    {
        TFTPFolderPair tftp;
        internal TFTPFolderPair Sftp { get => tftp; /*set => sftp = value;*/ }

        public TFTP_FolderPairFRM()
        {
            InitializeComponent();
        }

        internal TFTP_FolderPairFRM(TFTPFolderPair mod):this()
        {
            tftp = mod;
            textBox_friendlyName.Text = tftp.FriendlyName;
            textBox_ip.Text = tftp.IP;
            numericUpDown_port.Value = tftp.Port;
            textBox_username.Text = tftp.UserName;
            textBox_password.Text = tftp.PassWord;
            textBox_remotedir.Text = tftp.SharedFolder;
            textBox_destination.Text = tftp.DestinationFolder;
            tftp.Added = DateTime.Now;
            dateTimePicker_start.Value = tftp.StartSync;
            dateTimePicker_stop.Value = tftp.StartSync;
            checkBox_deleteSourceFiles.Checked = tftp.DeleteSourceFiles;
            checkBox_enabled.Checked = tftp.Enabled;
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
            if (!Validator.IP(textBox_ip.Text))
            {
                StandardMessages.ShowMessageBox_InvalidIPAddress();
                textBox_ip.Focus();
                DialogResult = DialogResult.None;
            }
            
            if (label_testing.Text == "OK" && !string.IsNullOrEmpty(textBox_destination.Text))
            {
                if (tftp == null)
                {
                    SourceFolderDuplicationCheck();
                    tftp = new TFTPFolderPair(textBox_friendlyName.Text,
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

                    DBHandler.InsertSFTPFolderPair(tftp);
                }
                else
                {
                    tftp.FriendlyName = textBox_friendlyName.Text;
                    tftp.IP = textBox_ip.Text;
                    tftp.Port = (int)numericUpDown_port.Value;
                    tftp.UserName = textBox_username.Text;
                    tftp.PassWord = Xor.Encrypt(textBox_password.Text);
                    tftp.SharedFolder = textBox_remotedir.Text;
                    tftp.Added = DateTime.Now;
                    tftp.StartSync = dateTimePicker_start.Value;
                    tftp.StopSync = dateTimePicker_stop.Value;
                    tftp.DeleteSourceFiles = checkBox_deleteSourceFiles.Checked;
                    tftp.Enabled = checkBox_enabled.Checked;
                    DBHandler.UpdateTFTPFolderPair(tftp);
                }
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                DialogResult = DialogResult.None;
            }        
        }

        private void SourceFolderDuplicationCheck()
        {
            //throw new NotImplementedException();
            if (DynamicDataStore.SftpFolderPairs.Any(x => x.SharedFolder == textBox_remotedir.Text))
            {
                StandardMessages.ShowMessageBox_SharedFolderIsAlreadyUsed(textBox_remotedir.Text);
                label_testing.Text = "";
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
    }
}
