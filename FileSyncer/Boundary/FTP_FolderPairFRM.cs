using System;
using System.Net;
using System.Windows.Forms;
using FileSyncer.Control;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace FileSyncer.Boundary
{
    public partial class FTP_FolderPairFRM : Form
    {
        FTPFolderPair ftpFolderPair;
        internal FTPFolderPair F { get => ftpFolderPair; /*set => f = value;*/ }

        public FTP_FolderPairFRM()
        {
            InitializeComponent();
        }
        internal FTP_FolderPairFRM(FTPFolderPair mod) : this()
        {
            ftpFolderPair = mod;
            textBox_friendlyName.Text = ftpFolderPair.FriendlyName;
            textBox_ip.Text = ftpFolderPair.SourceIP;
            numericUpDown_port.Value = ftpFolderPair.Port;
            checkBox_passive.Checked = ftpFolderPair.Passive;
            textBox_shared.Text = ftpFolderPair.SharedFolder;
            textBox_username.Text = ftpFolderPair.UserName;
            textBox_password.Text = ftpFolderPair.PassWord;
            textBox_destination.Text = ftpFolderPair.DestinationFolder;
            dateTimePicker_start.Value = ftpFolderPair.StartSync;
            dateTimePicker_stop.Value = ftpFolderPair.StopSync;
            checkBox_deleteSourceFiles.Checked = ftpFolderPair.DeleteSourceFiles;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (label_testing.Text != "OK")
            {
                StandardMessages.ShowMessageBox_MissedFTPServerTest();
                DialogResult = DialogResult.None;
            }
            if (ftpFolderPair == null) // new insert, "added" as creation time is set now
            {
                ftpFolderPair = new FTPFolderPair(
                            textBox_friendlyName.Text,
                            textBox_ip.Text,
                            (int)numericUpDown_port.Value,
                            checkBox_passive.Checked,
                            textBox_shared.Text,
                            textBox_username.Text,
                            Xor.Encrypt(textBox_password.Text),
                            textBox_destination.Text,
                            DateTime.Now,
                            dateTimePicker_start.Value,
                            dateTimePicker_stop.Value,
                            checkBox_deleteSourceFiles.Checked,
                            checkBox_enabled.Checked);
                DBHandler.InsertFTPFolderPair(ftpFolderPair);
            }
            else // mod
            {
                ftpFolderPair.FriendlyName = textBox_friendlyName.Text;
                ftpFolderPair.SourceIP = textBox_ip.Text;
                ftpFolderPair.Port = (int)numericUpDown_port.Value;
                ftpFolderPair.Passive = checkBox_passive.Checked;
                ftpFolderPair.SharedFolder = textBox_shared.Text;
                ftpFolderPair.UserName = textBox_username.Text;
                ftpFolderPair.PassWord = Xor.Encrypt(textBox_password.Text);
                ftpFolderPair.DestinationFolder = textBox_destination.Text;
                ftpFolderPair.StartSync = dateTimePicker_start.Value;
                ftpFolderPair.StopSync = dateTimePicker_stop.Value;
                ftpFolderPair.Enabled = checkBox_enabled.Checked;
                ftpFolderPair.DeleteSourceFiles = checkBox_deleteSourceFiles.Checked;
                DBHandler.UpdateFTPFolderPair(ftpFolderPair);
            }
        }

        private void button_destination_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_destination.Text = fbd.SelectedPath;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }
        private void button_test_Click(object sender, EventArgs e)
        {
            label_testing.Text = "";
            label_testing.ForeColor = Color.Green;
            label_testing.Text = "Testing";
            label_testing.ForeColor = Color.Green;

            textBox_ip.Enabled = false;
            numericUpDown_port.Enabled = false;
            textBox_username.Enabled = false;
            textBox_password.Enabled = false;
            button_test.Enabled = false;
            if (LoginOK())
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

        bool LoginOK()
        {
            try
            {
                string uri = $"ftp://{textBox_ip.Text}:{numericUpDown_port.Value}/{textBox_shared.Text}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.Credentials = new NetworkCredential(textBox_username.Text, textBox_password.Text);
                request.KeepAlive = false;
                request.UseBinary = true;
                request.UsePassive = checkBox_passive.Checked;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                var code = (int)response.StatusCode;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                reader.Close();
                response.Close();
                return code == 150 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void textBox_ip_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_ip.Clear();
            textBox_ip.ForeColor = Color.Black;
        }

        private void textBox_shared_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_shared.Clear();
            textBox_shared.ForeColor = Color.Black;
        }

        private void textBox_ip_MouseLeave(object sender, EventArgs e)
        {
            if (!Validator.IP(textBox_ip.Text))
            {
                StandardMessages.ShowMessageBox_InvalidIPAddress();
                textBox_ip.Focus();
            }
        }
        private void FTP_FolderPairFRM_Load(object sender, EventArgs e)
        {
            checkBox_enabled.Checked = true;
        }
    }
}
