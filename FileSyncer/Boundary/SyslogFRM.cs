using FileSyncer.Control;
using FileSyncer.Entity;
using System;
using System.Windows.Forms;

namespace FileSyncer.Boundary
{
    public partial class SyslogFRM : Form
    {
        SyslogServer server;
        internal SyslogServer Server { get => server; }

        public SyslogFRM()
        {
            InitializeComponent();
            
            
        }

        internal SyslogFRM(SyslogServer mod):this()
        {
            server = mod;
            textBox_ip.Text = server.Ip;
            
        }


        private void SyslogFRM_Load(object sender, EventArgs e)
        {
            if (textBox_ip.Text == "")
            {
                var server = DBHandler.LoadSyslogServer();
                if (server != null)
                {
                    textBox_ip.Text = server.Ip;
                    numericUpDown_port.Value = server.Port;
                    checkBox_enabled.Checked = server.Enabled;
                }           
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!Validator.IP(textBox_ip.Text))
            {
                StandardMessages.ShowMessageBox_InvalidIPAddress();
            }
            if (textBox_ip.Text != "" && 0 < numericUpDown_port.Value && numericUpDown_port.Value < 65536 && Validator.IP(textBox_ip.Text))
            {
                if (server == null)
                {
                    bool enabled = checkBox_enabled.Checked;
                    server = new SyslogServer(textBox_ip.Text, (int)numericUpDown_port.Value, enabled);
                    DBHandler.InsertSyslogServer(server);
                    if (ApplicationLogger.Logging_enabled)
                    {
                        ApplicationLogger.AddLog($"Syslog Server added: {server.Ip}:{server.Port}");
                        ApplicationLogger.AddLog($"Syslog State: {(enabled ? "enabled" : "disabled")}");
                    }
                }        
                else
                {
                    server.Ip = textBox_ip.Text;
                    server.Port = (int)numericUpDown_port.Value;
                    server.Enabled = (bool)checkBox_enabled.Checked;
                    //DBHandler.UpdateSyslogServer(server);
                    DBHandler.InsertSyslogServer(server);
                    if (ApplicationLogger.Logging_enabled)
                    {
                        ApplicationLogger.AddLog($" Syslog Server Update: {server.Ip}:{server.Port}");
                        ApplicationLogger.AddLog($"Syslog Server State: {(Enabled ? "enabled" : "disabled")}");
                    }   
                }          
            }
            else
            {
                StandardMessages.ShowMessageBox_EmptyFieldsOnForm();
                textBox_ip.Focus();
                DialogResult = DialogResult.None;
            }
            
        }
    }
}
