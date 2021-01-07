namespace FileSyncer.Boundary
{
    partial class TFTP_FolderPairFRM
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
            this.checkBox_deleteSourceFiles = new System.Windows.Forms.CheckBox();
            this.checkBox_enabled = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label_stop = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.numericUpDown_port = new System.Windows.Forms.NumericUpDown();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.button_destination = new System.Windows.Forms.Button();
            this.label_destination = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_tftp_server_ip = new System.Windows.Forms.Label();
            this.textBox_friendlyName = new System.Windows.Forms.TextBox();
            this.label_fn = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_remotedir = new System.Windows.Forms.TextBox();
            this.label_remotedir = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.label_testing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_deleteSourceFiles
            // 
            this.checkBox_deleteSourceFiles.AutoSize = true;
            this.checkBox_deleteSourceFiles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox_deleteSourceFiles.Location = new System.Drawing.Point(250, 410);
            this.checkBox_deleteSourceFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_deleteSourceFiles.Name = "checkBox_deleteSourceFiles";
            this.checkBox_deleteSourceFiles.Size = new System.Drawing.Size(142, 23);
            this.checkBox_deleteSourceFiles.TabIndex = 13;
            this.checkBox_deleteSourceFiles.Text = "Delete Source Files";
            this.checkBox_deleteSourceFiles.UseVisualStyleBackColor = true;
            // 
            // checkBox_enabled
            // 
            this.checkBox_enabled.AutoSize = true;
            this.checkBox_enabled.Checked = true;
            this.checkBox_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_enabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox_enabled.Location = new System.Drawing.Point(160, 410);
            this.checkBox_enabled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_enabled.Name = "checkBox_enabled";
            this.checkBox_enabled.Size = new System.Drawing.Size(76, 23);
            this.checkBox_enabled.TabIndex = 12;
            this.checkBox_enabled.Text = "Enabled";
            this.checkBox_enabled.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dateTimePicker_stop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(160, 360);
            this.dateTimePicker_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker_stop.TabIndex = 11;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dateTimePicker_start.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(160, 320);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker_start.TabIndex = 10;
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_stop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_stop.Location = new System.Drawing.Point(20, 360);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(72, 19);
            this.label_stop.TabIndex = 39;
            this.label_stop.Text = "Stop Sync:";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_start.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_start.Location = new System.Drawing.Point(20, 320);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(73, 19);
            this.label_start.TabIndex = 38;
            this.label_start.Text = "Start Sync:";
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_ok.Location = new System.Drawing.Point(306, 465);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 30);
            this.button_ok.TabIndex = 14;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_cancel.Location = new System.Drawing.Point(160, 465);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 30);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // numericUpDown_port
            // 
            this.numericUpDown_port.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDown_port.Location = new System.Drawing.Point(160, 100);
            this.numericUpDown_port.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDown_port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_port.Name = "numericUpDown_port";
            this.numericUpDown_port.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_port.TabIndex = 3;
            this.numericUpDown_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_port.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_port.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_port.Location = new System.Drawing.Point(20, 100);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(37, 19);
            this.label_port.TabIndex = 34;
            this.label_port.Text = "Port:";
            // 
            // textBox_destination
            // 
            this.textBox_destination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_destination.Location = new System.Drawing.Point(218, 280);
            this.textBox_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_destination.MaxLength = 32;
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(175, 25);
            this.textBox_destination.TabIndex = 9;
            // 
            // button_destination
            // 
            this.button_destination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_destination.Location = new System.Drawing.Point(160, 276);
            this.button_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_destination.Name = "button_destination";
            this.button_destination.Size = new System.Drawing.Size(44, 30);
            this.button_destination.TabIndex = 8;
            this.button_destination.Text = "...";
            this.button_destination.UseVisualStyleBackColor = true;
            this.button_destination.Click += new System.EventHandler(this.button_destination_Click);
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_destination.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_destination.Location = new System.Drawing.Point(20, 280);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(82, 19);
            this.label_destination.TabIndex = 31;
            this.label_destination.Text = "Destination:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_ip.Location = new System.Drawing.Point(160, 60);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ip.MaxLength = 15;
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(233, 25);
            this.textBox_ip.TabIndex = 2;
            // 
            // label_tftp_server_ip
            // 
            this.label_tftp_server_ip.AutoSize = true;
            this.label_tftp_server_ip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_tftp_server_ip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_tftp_server_ip.Location = new System.Drawing.Point(20, 60);
            this.label_tftp_server_ip.Name = "label_tftp_server_ip";
            this.label_tftp_server_ip.Size = new System.Drawing.Size(99, 19);
            this.label_tftp_server_ip.TabIndex = 29;
            this.label_tftp_server_ip.Text = "TFTP Server IP:";
            // 
            // textBox_friendlyName
            // 
            this.textBox_friendlyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_friendlyName.Location = new System.Drawing.Point(160, 20);
            this.textBox_friendlyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_friendlyName.MaxLength = 32;
            this.textBox_friendlyName.Name = "textBox_friendlyName";
            this.textBox_friendlyName.Size = new System.Drawing.Size(233, 25);
            this.textBox_friendlyName.TabIndex = 1;
            // 
            // label_fn
            // 
            this.label_fn.AutoSize = true;
            this.label_fn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_fn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_fn.Location = new System.Drawing.Point(20, 20);
            this.label_fn.Name = "label_fn";
            this.label_fn.Size = new System.Drawing.Size(100, 19);
            this.label_fn.TabIndex = 27;
            this.label_fn.Text = "Friendly Name:";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_password.Location = new System.Drawing.Point(160, 180);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_password.MaxLength = 32;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(120, 25);
            this.textBox_password.TabIndex = 5;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_password.Location = new System.Drawing.Point(20, 180);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 19);
            this.label_password.TabIndex = 46;
            this.label_password.Text = "Password:";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_username.Location = new System.Drawing.Point(160, 140);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_username.MaxLength = 32;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(120, 25);
            this.textBox_username.TabIndex = 4;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_username.Location = new System.Drawing.Point(20, 140);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(74, 19);
            this.label_username.TabIndex = 44;
            this.label_username.Text = "Username:";
            // 
            // textBox_remotedir
            // 
            this.textBox_remotedir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_remotedir.Location = new System.Drawing.Point(160, 220);
            this.textBox_remotedir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_remotedir.MaxLength = 64;
            this.textBox_remotedir.Name = "textBox_remotedir";
            this.textBox_remotedir.Size = new System.Drawing.Size(120, 25);
            this.textBox_remotedir.TabIndex = 6;
            // 
            // label_remotedir
            // 
            this.label_remotedir.AutoSize = true;
            this.label_remotedir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_remotedir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_remotedir.Location = new System.Drawing.Point(20, 220);
            this.label_remotedir.Name = "label_remotedir";
            this.label_remotedir.Size = new System.Drawing.Size(101, 19);
            this.label_remotedir.TabIndex = 48;
            this.label_remotedir.Text = "Remote Folder:";
            // 
            // button_test
            // 
            this.button_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_test.Location = new System.Drawing.Point(306, 218);
            this.button_test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(87, 30);
            this.button_test.TabIndex = 7;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label_testing
            // 
            this.label_testing.AutoSize = true;
            this.label_testing.Location = new System.Drawing.Point(303, 183);
            this.label_testing.Name = "label_testing";
            this.label_testing.Size = new System.Drawing.Size(0, 17);
            this.label_testing.TabIndex = 52;
            // 
            // TFTP_FolderPairFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 514);
            this.Controls.Add(this.label_testing);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.textBox_remotedir);
            this.Controls.Add(this.label_remotedir);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.checkBox_deleteSourceFiles);
            this.Controls.Add(this.checkBox_enabled);
            this.Controls.Add(this.dateTimePicker_stop);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label_stop);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.numericUpDown_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_destination);
            this.Controls.Add(this.button_destination);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_tftp_server_ip);
            this.Controls.Add(this.textBox_friendlyName);
            this.Controls.Add(this.label_fn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TFTP_FolderPairFRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFTP FolderPair";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_deleteSourceFiles;
        private System.Windows.Forms.CheckBox checkBox_enabled;
        private System.Windows.Forms.DateTimePicker dateTimePicker_stop;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.NumericUpDown numericUpDown_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.Button button_destination;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_tftp_server_ip;
        private System.Windows.Forms.TextBox textBox_friendlyName;
        private System.Windows.Forms.Label label_fn;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_remotedir;
        private System.Windows.Forms.Label label_remotedir;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Label label_testing;
    }
}