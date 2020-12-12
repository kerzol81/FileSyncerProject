using FileSyncer.Entity;
using System;
using System.Windows.Forms;

namespace FileSyncer.Boundary
{
    public partial class FrequencyFRM : Form
    {
        private int ftp_minute;
        private int tftp_minute;
        internal int FTPMinute { get => ftp_minute; }
        public int TFTP_minute { get => tftp_minute; }

        public FrequencyFRM()
        {
            InitializeComponent();
        }

        private void FrequencyFRM_Load(object sender, EventArgs e)
        {
            numericUpDown_ftp.Value = Syncroniser.Ftp_minute;
            numericUpDown_rsync.Value = Syncroniser.SFTP_minute;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            ftp_minute = (int)numericUpDown_ftp.Value;
            Syncroniser.Ftp_minute = (int)numericUpDown_ftp.Value;

            tftp_minute = (int)numericUpDown_rsync.Value;
            Syncroniser.SFTP_minute = (int)numericUpDown_rsync.Value;
        }        
    }
}
