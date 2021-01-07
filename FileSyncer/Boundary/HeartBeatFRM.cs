using FileSyncer.Entity;
using System;
using System.Windows.Forms;

namespace FileSyncer.Boundary
{
    public partial class HeartBeatFRM : Form
    {
        private int ftp_minute;
        private int sftp_minute;
        internal int FTPMinute { get => ftp_minute; }
        public int SFTP_minute { get => sftp_minute; }

        public HeartBeatFRM()
        {
            InitializeComponent();
        }
        private void FrequencyFRM_Load(object sender, EventArgs e)
        {
            numericUpDown_ftp.Value = Syncroniser.Ftp_minute;
            numericUpDown_rsync.Value = Syncroniser.Tftp_minute;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            ftp_minute = (int)numericUpDown_ftp.Value;
            Syncroniser.Ftp_minute = (int)numericUpDown_ftp.Value;

            sftp_minute = (int)numericUpDown_rsync.Value;
            Syncroniser.Tftp_minute = (int)numericUpDown_rsync.Value;
        }        
    }
}
