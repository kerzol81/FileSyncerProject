namespace FileSyncer.Boundary
{
    partial class SyslogFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.numericUpDown_port = new System.Windows.Forms.NumericUpDown();
            this.checkBox_enabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_ok.Location = new System.Drawing.Point(133, 160);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 30);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_cancel.Location = new System.Drawing.Point(30, 160);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 30);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ip.Location = new System.Drawing.Point(30, 30);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(24, 19);
            this.label_ip.TabIndex = 9;
            this.label_ip.Text = "IP:";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_port.Location = new System.Drawing.Point(30, 70);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(37, 19);
            this.label_port.TabIndex = 10;
            this.label_port.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(120, 30);
            this.textBox_ip.MaxLength = 15;
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.ShortcutsEnabled = false;
            this.textBox_ip.Size = new System.Drawing.Size(100, 25);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_port
            // 
            this.numericUpDown_port.Location = new System.Drawing.Point(120, 70);
            this.numericUpDown_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port.Name = "numericUpDown_port";
            this.numericUpDown_port.Size = new System.Drawing.Size(100, 25);
            this.numericUpDown_port.TabIndex = 2;
            this.numericUpDown_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_port.Value = new decimal(new int[] {
            514,
            0,
            0,
            0});
            // 
            // checkBox_enabled
            // 
            this.checkBox_enabled.AutoSize = true;
            this.checkBox_enabled.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox_enabled.Location = new System.Drawing.Point(144, 110);
            this.checkBox_enabled.Name = "checkBox_enabled";
            this.checkBox_enabled.Size = new System.Drawing.Size(76, 23);
            this.checkBox_enabled.TabIndex = 3;
            this.checkBox_enabled.Text = "Enabled";
            this.checkBox_enabled.UseVisualStyleBackColor = true;
            // 
            // SyslogFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(244, 211);
            this.Controls.Add(this.checkBox_enabled);
            this.Controls.Add(this.numericUpDown_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SyslogFRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syslog Server Settings";
            this.Load += new System.EventHandler(this.SyslogFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.NumericUpDown numericUpDown_port;
        private System.Windows.Forms.CheckBox checkBox_enabled;
    }
}