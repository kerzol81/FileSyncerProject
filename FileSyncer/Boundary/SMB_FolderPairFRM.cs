using System;
using System.Windows.Forms;
using FileSyncer.Control;

namespace FileSyncer.Boundary
{
    public partial class SMB_FolderPairFRM : Form
    {
        SMBFolderPair smbFolderPair;
        internal SMBFolderPair SmbFolderPair { get => smbFolderPair; set => smbFolderPair = value; }
        public SMB_FolderPairFRM()
        {
            InitializeComponent();
        }
        internal SMB_FolderPairFRM(SMBFolderPair mod) : this()
        {
            smbFolderPair = mod;
            textBox_friendlyName.Text = smbFolderPair.FriendlyName;
            textBox_source.Text = smbFolderPair.SourceFolder;
            textBox_destination.Text = smbFolderPair.DestinationFolder;
            dateTimePicker_start.Value = smbFolderPair.StartSync;
            dateTimePicker_stop.Value = smbFolderPair.StopSync;
            checkBox_enabled.Checked = smbFolderPair.Enabled;
            checkBox_deleteSourceFiles.Checked = smbFolderPair.DeleteSourceFiles;
        }
        private void folderPairFRM_Load(object sender, EventArgs e)
        {
            checkBox_enabled.Checked = true;
            checkBox_deleteSourceFiles.Checked = true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(textBox_friendlyName.Text) && 
                !string.IsNullOrEmpty(textBox_source.Text) && 
                !string.IsNullOrEmpty(textBox_destination.Text) && 
                !string.IsNullOrEmpty(textBox_source.Text) && 
                !string.IsNullOrEmpty(textBox_destination.Text))
            {
                if (smbFolderPair == null)
                {
                    smbFolderPair = new SMBFolderPair(
                        textBox_friendlyName.Text,
                        folderBD_source.SelectedPath,
                        folderBD_destination.SelectedPath,
                        DateTime.Now,
                        dateTimePicker_start.Value,
                        dateTimePicker_stop.Value,
                        checkBox_deleteSourceFiles.Checked,
                        checkBox_enabled.Checked
                    );
                    DBHandler.InsertSMBFolderPair(smbFolderPair);
                }
                else // mod
                {
                    smbFolderPair.FriendlyName = textBox_friendlyName.Text;
                    smbFolderPair.SourceFolder = textBox_source.Text;
                    smbFolderPair.DestinationFolder = textBox_destination.Text;
                    smbFolderPair.StartSync = dateTimePicker_start.Value;
                    smbFolderPair.StopSync = dateTimePicker_stop.Value;
                    smbFolderPair.DeleteSourceFiles = checkBox_deleteSourceFiles.Checked;
                    smbFolderPair.Enabled = checkBox_enabled.Checked;
                    DBHandler.UpdateSMBFolderPair(smbFolderPair);
                }
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                textBox_friendlyName.Focus();
                DialogResult = DialogResult.None;
            }           
        }
        private void button_source_Click(object sender, EventArgs e)
        {
            if (folderBD_source.ShowDialog() == DialogResult.OK)
            {
                textBox_source.Text = folderBD_source.SelectedPath;
            }
        }
        private void button_destination_Click(object sender, EventArgs e)
        {
            if (folderBD_destination.ShowDialog() == DialogResult.OK)
            {
                textBox_destination.Text = folderBD_destination.SelectedPath;
            }
        }
        private void textBox_source_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in DynamicDataStore.SmbFolderPairs)
            {
                if (item.SourceFolder == textBox_source.Text)
                {
                    StandardMessages.ShowMessageBox_SourceFolderIsAlreadyUsed(item.Id.ToString());
                    textBox_source.Clear();
                    DialogResult = DialogResult.None;
                }     
            }
        }

        private void textBox_destination_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in DynamicDataStore.SmbFolderPairs)
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
