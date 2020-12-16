namespace FileSyncer.Boundary
{
    partial class SMB_FolderPairFRM
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_fn = new System.Windows.Forms.Label();
            this.label_sf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_stop = new System.Windows.Forms.Label();
            this.textBox_friendlyName = new System.Windows.Forms.TextBox();
            this.folderBD_source = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBD_destination = new System.Windows.Forms.FolderBrowserDialog();
            this.button_source = new System.Windows.Forms.Button();
            this.button_destination = new System.Windows.Forms.Button();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_stop = new System.Windows.Forms.DateTimePicker();
            this.checkBox_enabled = new System.Windows.Forms.CheckBox();
            this.checkBox_deleteSourceFiles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(160, 288);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 30);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(306, 288);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 30);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_fn
            // 
            this.label_fn.AutoSize = true;
            this.label_fn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_fn.Location = new System.Drawing.Point(20, 20);
            this.label_fn.Name = "label_fn";
            this.label_fn.Size = new System.Drawing.Size(100, 19);
            this.label_fn.TabIndex = 2;
            this.label_fn.Text = "Friendly Name:";
            // 
            // label_sf
            // 
            this.label_sf.AutoSize = true;
            this.label_sf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_sf.Location = new System.Drawing.Point(20, 60);
            this.label_sf.Name = "label_sf";
            this.label_sf.Size = new System.Drawing.Size(53, 19);
            this.label_sf.TabIndex = 3;
            this.label_sf.Text = "Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination:";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_start.Location = new System.Drawing.Point(20, 140);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(41, 19);
            this.label_start.TabIndex = 5;
            this.label_start.Text = "Start:";
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_stop.Location = new System.Drawing.Point(20, 180);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(40, 19);
            this.label_stop.TabIndex = 6;
            this.label_stop.Text = "Stop:";
            // 
            // textBox_friendlyName
            // 
            this.textBox_friendlyName.Location = new System.Drawing.Point(160, 20);
            this.textBox_friendlyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_friendlyName.MaxLength = 32;
            this.textBox_friendlyName.Name = "textBox_friendlyName";
            this.textBox_friendlyName.Size = new System.Drawing.Size(233, 25);
            this.textBox_friendlyName.TabIndex = 1;
            // 
            // folderBD_source
            // 
            this.folderBD_source.Description = "Choose a Source Folder";
            // 
            // folderBD_destination
            // 
            this.folderBD_destination.Description = "Choose a Destination Folder";
            // 
            // button_source
            // 
            this.button_source.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_source.Location = new System.Drawing.Point(108, 56);
            this.button_source.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_source.Name = "button_source";
            this.button_source.Size = new System.Drawing.Size(44, 30);
            this.button_source.TabIndex = 2;
            this.button_source.Text = "...";
            this.button_source.UseVisualStyleBackColor = true;
            this.button_source.Click += new System.EventHandler(this.button_source_Click);
            // 
            // button_destination
            // 
            this.button_destination.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_destination.Location = new System.Drawing.Point(108, 96);
            this.button_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_destination.Name = "button_destination";
            this.button_destination.Size = new System.Drawing.Size(44, 30);
            this.button_destination.TabIndex = 3;
            this.button_destination.Text = "...";
            this.button_destination.UseVisualStyleBackColor = true;
            this.button_destination.Click += new System.EventHandler(this.button_destination_Click);
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(160, 60);
            this.textBox_source.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_source.MaxLength = 32;
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(233, 25);
            this.textBox_source.TabIndex = 12;
            this.textBox_source.TextChanged += new System.EventHandler(this.textBox_source_TextChanged);
            // 
            // textBox_destination
            // 
            this.textBox_destination.Location = new System.Drawing.Point(160, 100);
            this.textBox_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_destination.MaxLength = 32;
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(233, 25);
            this.textBox_destination.TabIndex = 13;
            this.textBox_destination.TextChanged += new System.EventHandler(this.textBox_destination_TextChanged);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(160, 140);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker_start.TabIndex = 4;
            // 
            // dateTimePicker_stop
            // 
            this.dateTimePicker_stop.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dateTimePicker_stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_stop.Location = new System.Drawing.Point(160, 180);
            this.dateTimePicker_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_stop.Name = "dateTimePicker_stop";
            this.dateTimePicker_stop.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker_stop.TabIndex = 5;
            // 
            // checkBox_enabled
            // 
            this.checkBox_enabled.AutoSize = true;
            this.checkBox_enabled.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox_enabled.Location = new System.Drawing.Point(160, 230);
            this.checkBox_enabled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_enabled.Name = "checkBox_enabled";
            this.checkBox_enabled.Size = new System.Drawing.Size(76, 23);
            this.checkBox_enabled.TabIndex = 6;
            this.checkBox_enabled.Text = "Enabled";
            this.checkBox_enabled.UseVisualStyleBackColor = true;
            // 
            // checkBox_deleteSourceFiles
            // 
            this.checkBox_deleteSourceFiles.AutoSize = true;
            this.checkBox_deleteSourceFiles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox_deleteSourceFiles.Location = new System.Drawing.Point(251, 230);
            this.checkBox_deleteSourceFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_deleteSourceFiles.Name = "checkBox_deleteSourceFiles";
            this.checkBox_deleteSourceFiles.Size = new System.Drawing.Size(142, 23);
            this.checkBox_deleteSourceFiles.TabIndex = 7;
            this.checkBox_deleteSourceFiles.Text = "Delete Source Files";
            this.checkBox_deleteSourceFiles.UseVisualStyleBackColor = true;
            // 
            // SMB_FolderPairFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 341);
            this.Controls.Add(this.checkBox_deleteSourceFiles);
            this.Controls.Add(this.checkBox_enabled);
            this.Controls.Add(this.dateTimePicker_stop);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.textBox_destination);
            this.Controls.Add(this.textBox_source);
            this.Controls.Add(this.button_destination);
            this.Controls.Add(this.button_source);
            this.Controls.Add(this.textBox_friendlyName);
            this.Controls.Add(this.label_stop);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_sf);
            this.Controls.Add(this.label_fn);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SMB_FolderPairFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samba FolderPair Edit";
            this.Load += new System.EventHandler(this.folderPairFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_fn;
        private System.Windows.Forms.Label label_sf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.TextBox textBox_friendlyName;
        private System.Windows.Forms.FolderBrowserDialog folderBD_source;
        private System.Windows.Forms.FolderBrowserDialog folderBD_destination;
        private System.Windows.Forms.Button button_source;
        private System.Windows.Forms.Button button_destination;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_stop;
        private System.Windows.Forms.CheckBox checkBox_enabled;
        private System.Windows.Forms.CheckBox checkBox_deleteSourceFiles;
    }
}