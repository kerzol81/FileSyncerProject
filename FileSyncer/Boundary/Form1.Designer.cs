namespace FileSyncer.Boundary
    
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVExportFolderPairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVExportUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syslogServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPSyncroniseFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_logs = new System.Windows.Forms.ListBox();
            this.label_smb = new System.Windows.Forms.Label();
            this.label_ftp = new System.Windows.Forms.Label();
            this.label_rsync = new System.Windows.Forms.Label();
            this.button_smb_add = new System.Windows.Forms.Button();
            this.button_smb_del = new System.Windows.Forms.Button();
            this.button_smb_mod = new System.Windows.Forms.Button();
            this.LSTV_smb = new System.Windows.Forms.ListView();
            this.smb_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_friendlyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_added = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_startSync = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_stopSync = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_deleteSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smb_enabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ftp_mod = new System.Windows.Forms.Button();
            this.button_ftp_del = new System.Windows.Forms.Button();
            this.button_ftp_add = new System.Windows.Forms.Button();
            this.button_sftp_mod = new System.Windows.Forms.Button();
            this.button_sftp_del = new System.Windows.Forms.Button();
            this.button_sftp_add = new System.Windows.Forms.Button();
            this.LSTV_ftp = new System.Windows.Forms.ListView();
            this.ftp_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_FriendlyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_sharedFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_added = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_startSync = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_stopSync = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_deleteSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ftp_enabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSTV_sftp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_clearLogs = new System.Windows.Forms.Button();
            this.button_saveLogs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_AppLogs = new System.Windows.Forms.Timer(this.components);
            this.label_logged_in_username = new System.Windows.Forms.Label();
            this.LoggedIn_GBX = new System.Windows.Forms.GroupBox();
            this.label_logged_in_userLevel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.LoggedIn_GBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1584, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagmentMenuItem,
            this.cSVExportFolderPairsToolStripMenuItem,
            this.cSVExportUsersToolStripMenuItem,
            this.syslogServerSettingsToolStripMenuItem,
            this.fTPSyncroniseFrequencyToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.usersToolStripMenuItem.Text = "Settings";
            // 
            // userManagmentMenuItem
            // 
            this.userManagmentMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userManagmentMenuItem.Name = "userManagmentMenuItem";
            this.userManagmentMenuItem.Size = new System.Drawing.Size(241, 26);
            this.userManagmentMenuItem.Text = "User Managment";
            this.userManagmentMenuItem.Click += new System.EventHandler(this.userManagmentMenuItem_Click);
            // 
            // cSVExportFolderPairsToolStripMenuItem
            // 
            this.cSVExportFolderPairsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cSVExportFolderPairsToolStripMenuItem.Name = "cSVExportFolderPairsToolStripMenuItem";
            this.cSVExportFolderPairsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.cSVExportFolderPairsToolStripMenuItem.Text = "CSV Export FolderPairs";
            this.cSVExportFolderPairsToolStripMenuItem.Click += new System.EventHandler(this.cSVExportFolderPairsToolStripMenuItem_Click);
            // 
            // cSVExportUsersToolStripMenuItem
            // 
            this.cSVExportUsersToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cSVExportUsersToolStripMenuItem.Name = "cSVExportUsersToolStripMenuItem";
            this.cSVExportUsersToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.cSVExportUsersToolStripMenuItem.Text = "CSV Export Users";
            this.cSVExportUsersToolStripMenuItem.Click += new System.EventHandler(this.cSVExportUsersToolStripMenuItem_Click);
            // 
            // syslogServerSettingsToolStripMenuItem
            // 
            this.syslogServerSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.syslogServerSettingsToolStripMenuItem.Name = "syslogServerSettingsToolStripMenuItem";
            this.syslogServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.syslogServerSettingsToolStripMenuItem.Text = "Syslog Server Settings";
            this.syslogServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.syslogServerSettingsToolStripMenuItem_Click);
            // 
            // fTPSyncroniseFrequencyToolStripMenuItem
            // 
            this.fTPSyncroniseFrequencyToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fTPSyncroniseFrequencyToolStripMenuItem.Name = "fTPSyncroniseFrequencyToolStripMenuItem";
            this.fTPSyncroniseFrequencyToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.fTPSyncroniseFrequencyToolStripMenuItem.Text = "FTP / SFTP HeartBeaths";
            this.fTPSyncroniseFrequencyToolStripMenuItem.Click += new System.EventHandler(this.fTPSyncroniseFrequencyToolStripMenuItem_Click);
            // 
            // listBox_logs
            // 
            this.listBox_logs.BackColor = System.Drawing.Color.White;
            this.listBox_logs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_logs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listBox_logs.FormattingEnabled = true;
            this.listBox_logs.ItemHeight = 17;
            this.listBox_logs.Location = new System.Drawing.Point(985, 100);
            this.listBox_logs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_logs.Name = "listBox_logs";
            this.listBox_logs.Size = new System.Drawing.Size(574, 599);
            this.listBox_logs.TabIndex = 2;
            // 
            // label_smb
            // 
            this.label_smb.AutoSize = true;
            this.label_smb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_smb.Location = new System.Drawing.Point(20, 65);
            this.label_smb.Name = "label_smb";
            this.label_smb.Size = new System.Drawing.Size(127, 21);
            this.label_smb.TabIndex = 4;
            this.label_smb.Text = "SMB Folder Pairs";
            // 
            // label_ftp
            // 
            this.label_ftp.AutoSize = true;
            this.label_ftp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ftp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ftp.Location = new System.Drawing.Point(20, 285);
            this.label_ftp.Name = "label_ftp";
            this.label_ftp.Size = new System.Drawing.Size(120, 21);
            this.label_ftp.TabIndex = 6;
            this.label_ftp.Text = "FTP Folder Pairs";
            // 
            // label_rsync
            // 
            this.label_rsync.AutoSize = true;
            this.label_rsync.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rsync.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_rsync.Location = new System.Drawing.Point(20, 500);
            this.label_rsync.Name = "label_rsync";
            this.label_rsync.Size = new System.Drawing.Size(129, 21);
            this.label_rsync.TabIndex = 8;
            this.label_rsync.Text = "SFTP Folder Pairs";
            // 
            // button_smb_add
            // 
            this.button_smb_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_smb_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smb_add.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_smb_add.Location = new System.Drawing.Point(150, 60);
            this.button_smb_add.Name = "button_smb_add";
            this.button_smb_add.Size = new System.Drawing.Size(54, 30);
            this.button_smb_add.TabIndex = 1;
            this.button_smb_add.Text = "New";
            this.button_smb_add.UseVisualStyleBackColor = false;
            this.button_smb_add.Click += new System.EventHandler(this.button_smb_add_Click);
            // 
            // button_smb_del
            // 
            this.button_smb_del.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_smb_del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smb_del.ForeColor = System.Drawing.Color.Tomato;
            this.button_smb_del.Location = new System.Drawing.Point(275, 60);
            this.button_smb_del.Name = "button_smb_del";
            this.button_smb_del.Size = new System.Drawing.Size(70, 30);
            this.button_smb_del.TabIndex = 3;
            this.button_smb_del.Text = "Delete";
            this.button_smb_del.UseVisualStyleBackColor = false;
            this.button_smb_del.Click += new System.EventHandler(this.button_smb_del_Click);
            // 
            // button_smb_mod
            // 
            this.button_smb_mod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_smb_mod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smb_mod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_smb_mod.Location = new System.Drawing.Point(212, 60);
            this.button_smb_mod.Name = "button_smb_mod";
            this.button_smb_mod.Size = new System.Drawing.Size(57, 30);
            this.button_smb_mod.TabIndex = 2;
            this.button_smb_mod.Text = "Edit";
            this.button_smb_mod.UseVisualStyleBackColor = false;
            this.button_smb_mod.Click += new System.EventHandler(this.button_smb_mod_Click);
            // 
            // LSTV_smb
            // 
            this.LSTV_smb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.smb_id,
            this.smb_friendlyName,
            this.smb_source,
            this.smb_destination,
            this.smb_added,
            this.smb_startSync,
            this.smb_stopSync,
            this.smb_deleteSource,
            this.smb_enabled});
            this.LSTV_smb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTV_smb.FullRowSelect = true;
            this.LSTV_smb.HideSelection = false;
            this.LSTV_smb.Location = new System.Drawing.Point(24, 100);
            this.LSTV_smb.MultiSelect = false;
            this.LSTV_smb.Name = "LSTV_smb";
            this.LSTV_smb.Size = new System.Drawing.Size(940, 170);
            this.LSTV_smb.TabIndex = 10;
            this.LSTV_smb.UseCompatibleStateImageBehavior = false;
            this.LSTV_smb.SelectedIndexChanged += new System.EventHandler(this.LSTV_smb_SelectedIndexChanged);
            // 
            // smb_id
            // 
            this.smb_id.Text = "ID";
            // 
            // smb_friendlyName
            // 
            this.smb_friendlyName.Text = "Friendly Name";
            // 
            // smb_source
            // 
            this.smb_source.Text = "Source Folder";
            // 
            // smb_destination
            // 
            this.smb_destination.Text = "Destination Folder";
            // 
            // smb_added
            // 
            this.smb_added.Text = "Added";
            // 
            // smb_startSync
            // 
            this.smb_startSync.Text = "Start Sync";
            // 
            // smb_stopSync
            // 
            this.smb_stopSync.Text = "Stop Sync";
            // 
            // smb_deleteSource
            // 
            this.smb_deleteSource.Text = "Delete Source Files";
            // 
            // smb_enabled
            // 
            this.smb_enabled.Text = "Enabled";
            // 
            // button_ftp_mod
            // 
            this.button_ftp_mod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ftp_mod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ftp_mod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_ftp_mod.Location = new System.Drawing.Point(212, 281);
            this.button_ftp_mod.Name = "button_ftp_mod";
            this.button_ftp_mod.Size = new System.Drawing.Size(57, 30);
            this.button_ftp_mod.TabIndex = 12;
            this.button_ftp_mod.Text = "Edit";
            this.button_ftp_mod.UseVisualStyleBackColor = false;
            this.button_ftp_mod.Click += new System.EventHandler(this.button_ftp_mod_Click);
            // 
            // button_ftp_del
            // 
            this.button_ftp_del.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ftp_del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ftp_del.ForeColor = System.Drawing.Color.Tomato;
            this.button_ftp_del.Location = new System.Drawing.Point(275, 281);
            this.button_ftp_del.Name = "button_ftp_del";
            this.button_ftp_del.Size = new System.Drawing.Size(70, 30);
            this.button_ftp_del.TabIndex = 13;
            this.button_ftp_del.Text = "Delete";
            this.button_ftp_del.UseVisualStyleBackColor = false;
            this.button_ftp_del.Click += new System.EventHandler(this.button_ftp_del_Click);
            // 
            // button_ftp_add
            // 
            this.button_ftp_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ftp_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ftp_add.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_ftp_add.Location = new System.Drawing.Point(150, 281);
            this.button_ftp_add.Name = "button_ftp_add";
            this.button_ftp_add.Size = new System.Drawing.Size(54, 30);
            this.button_ftp_add.TabIndex = 11;
            this.button_ftp_add.Text = "New";
            this.button_ftp_add.UseVisualStyleBackColor = false;
            this.button_ftp_add.Click += new System.EventHandler(this.button_ftp_add_Click);
            // 
            // button_sftp_mod
            // 
            this.button_sftp_mod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_sftp_mod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sftp_mod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_sftp_mod.Location = new System.Drawing.Point(210, 493);
            this.button_sftp_mod.Name = "button_sftp_mod";
            this.button_sftp_mod.Size = new System.Drawing.Size(57, 30);
            this.button_sftp_mod.TabIndex = 15;
            this.button_sftp_mod.Text = "Edit";
            this.button_sftp_mod.UseVisualStyleBackColor = false;
            this.button_sftp_mod.Click += new System.EventHandler(this.button_sftp_mod_Click);
            // 
            // button_sftp_del
            // 
            this.button_sftp_del.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_sftp_del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sftp_del.ForeColor = System.Drawing.Color.Tomato;
            this.button_sftp_del.Location = new System.Drawing.Point(275, 493);
            this.button_sftp_del.Name = "button_sftp_del";
            this.button_sftp_del.Size = new System.Drawing.Size(70, 30);
            this.button_sftp_del.TabIndex = 16;
            this.button_sftp_del.Text = "Delete";
            this.button_sftp_del.UseVisualStyleBackColor = false;
            this.button_sftp_del.Click += new System.EventHandler(this.button_sftp_del_Click);
            // 
            // button_sftp_add
            // 
            this.button_sftp_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_sftp_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sftp_add.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_sftp_add.Location = new System.Drawing.Point(150, 493);
            this.button_sftp_add.Name = "button_sftp_add";
            this.button_sftp_add.Size = new System.Drawing.Size(54, 30);
            this.button_sftp_add.TabIndex = 14;
            this.button_sftp_add.Text = "New";
            this.button_sftp_add.UseVisualStyleBackColor = false;
            this.button_sftp_add.Click += new System.EventHandler(this.button_sftp_add_Click);
            // 
            // LSTV_ftp
            // 
            this.LSTV_ftp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ftp_id,
            this.ftp_FriendlyName,
            this.ftp_ip,
            this.ftp_Port,
            this.ftp_sharedFolder,
            this.ftp_destination,
            this.ftp_added,
            this.ftp_startSync,
            this.ftp_stopSync,
            this.ftp_deleteSource,
            this.ftp_enabled});
            this.LSTV_ftp.FullRowSelect = true;
            this.LSTV_ftp.HideSelection = false;
            this.LSTV_ftp.Location = new System.Drawing.Point(24, 317);
            this.LSTV_ftp.MultiSelect = false;
            this.LSTV_ftp.Name = "LSTV_ftp";
            this.LSTV_ftp.Size = new System.Drawing.Size(940, 170);
            this.LSTV_ftp.TabIndex = 17;
            this.LSTV_ftp.UseCompatibleStateImageBehavior = false;
            this.LSTV_ftp.SelectedIndexChanged += new System.EventHandler(this.LSTV_ftp_SelectedIndexChanged);
            // 
            // ftp_id
            // 
            this.ftp_id.Text = "ID";
            // 
            // ftp_FriendlyName
            // 
            this.ftp_FriendlyName.Text = "Friendly Name";
            // 
            // ftp_ip
            // 
            this.ftp_ip.Text = "Source IP";
            // 
            // ftp_Port
            // 
            this.ftp_Port.Text = "Port";
            this.ftp_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ftp_sharedFolder
            // 
            this.ftp_sharedFolder.Text = "Shared Folder";
            // 
            // ftp_destination
            // 
            this.ftp_destination.Text = "Destination Folder";
            // 
            // ftp_added
            // 
            this.ftp_added.Text = "Added";
            // 
            // ftp_startSync
            // 
            this.ftp_startSync.Text = "Start Sync";
            // 
            // ftp_stopSync
            // 
            this.ftp_stopSync.Text = "Stop Sync";
            // 
            // ftp_deleteSource
            // 
            this.ftp_deleteSource.Text = "Delete Source";
            // 
            // ftp_enabled
            // 
            this.ftp_enabled.Text = "Enabled";
            // 
            // LSTV_sftp
            // 
            this.LSTV_sftp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.LSTV_sftp.FullRowSelect = true;
            this.LSTV_sftp.HideSelection = false;
            this.LSTV_sftp.Location = new System.Drawing.Point(24, 529);
            this.LSTV_sftp.MultiSelect = false;
            this.LSTV_sftp.Name = "LSTV_sftp";
            this.LSTV_sftp.Size = new System.Drawing.Size(940, 170);
            this.LSTV_sftp.TabIndex = 18;
            this.LSTV_sftp.UseCompatibleStateImageBehavior = false;
            this.LSTV_sftp.SelectedIndexChanged += new System.EventHandler(this.LSTV_sftp_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Friendly Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source IP";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Port";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Source Folder";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Destination Folder";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Added";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Start Sync";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Stop Sync";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Delete Source";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Enabled";
            // 
            // button_clearLogs
            // 
            this.button_clearLogs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_clearLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearLogs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_clearLogs.Location = new System.Drawing.Point(1454, 53);
            this.button_clearLogs.Name = "button_clearLogs";
            this.button_clearLogs.Size = new System.Drawing.Size(100, 30);
            this.button_clearLogs.TabIndex = 19;
            this.button_clearLogs.Text = "Clear Logs";
            this.button_clearLogs.UseVisualStyleBackColor = false;
            this.button_clearLogs.Click += new System.EventHandler(this.button_clearLogs_Click);
            // 
            // button_saveLogs
            // 
            this.button_saveLogs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_saveLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveLogs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_saveLogs.Location = new System.Drawing.Point(1336, 53);
            this.button_saveLogs.Name = "button_saveLogs";
            this.button_saveLogs.Size = new System.Drawing.Size(100, 30);
            this.button_saveLogs.TabIndex = 20;
            this.button_saveLogs.Text = "Save Logs";
            this.button_saveLogs.UseVisualStyleBackColor = false;
            this.button_saveLogs.Click += new System.EventHandler(this.button_saveLogs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(981, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Application Logs :";
            // 
            // timer_AppLogs
            // 
            this.timer_AppLogs.Enabled = true;
            this.timer_AppLogs.Interval = 200;
            this.timer_AppLogs.Tick += new System.EventHandler(this.timer_Logs_Tick);
            // 
            // label_logged_in_username
            // 
            this.label_logged_in_username.AutoSize = true;
            this.label_logged_in_username.Location = new System.Drawing.Point(86, 21);
            this.label_logged_in_username.Name = "label_logged_in_username";
            this.label_logged_in_username.Size = new System.Drawing.Size(71, 19);
            this.label_logged_in_username.TabIndex = 22;
            this.label_logged_in_username.Text = "Username";
            // 
            // LoggedIn_GBX
            // 
            this.LoggedIn_GBX.Controls.Add(this.label_logged_in_userLevel);
            this.LoggedIn_GBX.Controls.Add(this.label_logged_in_username);
            this.LoggedIn_GBX.Location = new System.Drawing.Point(614, 36);
            this.LoggedIn_GBX.Name = "LoggedIn_GBX";
            this.LoggedIn_GBX.Size = new System.Drawing.Size(350, 54);
            this.LoggedIn_GBX.TabIndex = 23;
            this.LoggedIn_GBX.TabStop = false;
            this.LoggedIn_GBX.Text = "Logged In User - Level";
            // 
            // label_logged_in_userLevel
            // 
            this.label_logged_in_userLevel.AutoSize = true;
            this.label_logged_in_userLevel.Location = new System.Drawing.Point(215, 21);
            this.label_logged_in_userLevel.Name = "label_logged_in_userLevel";
            this.label_logged_in_userLevel.Size = new System.Drawing.Size(40, 19);
            this.label_logged_in_userLevel.TabIndex = 24;
            this.label_logged_in_userLevel.Text = "Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 721);
            this.Controls.Add(this.LoggedIn_GBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_saveLogs);
            this.Controls.Add(this.button_clearLogs);
            this.Controls.Add(this.listBox_logs);
            this.Controls.Add(this.LSTV_sftp);
            this.Controls.Add(this.LSTV_ftp);
            this.Controls.Add(this.button_sftp_mod);
            this.Controls.Add(this.button_sftp_del);
            this.Controls.Add(this.button_sftp_add);
            this.Controls.Add(this.button_ftp_mod);
            this.Controls.Add(this.button_ftp_del);
            this.Controls.Add(this.button_ftp_add);
            this.Controls.Add(this.LSTV_smb);
            this.Controls.Add(this.button_smb_mod);
            this.Controls.Add(this.button_smb_del);
            this.Controls.Add(this.button_smb_add);
            this.Controls.Add(this.label_rsync);
            this.Controls.Add(this.label_ftp);
            this.Controls.Add(this.label_smb);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Syncer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LoggedIn_GBX.ResumeLayout(false);
            this.LoggedIn_GBX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_logs;
        private System.Windows.Forms.Label label_smb;
        //private FileSyncerDBDataSet fileSyncerDBDataSet;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVExportFolderPairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVExportUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syslogServerSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label_ftp;
        private System.Windows.Forms.Label label_rsync;
        private System.Windows.Forms.Button button_smb_add;
        private System.Windows.Forms.Button button_smb_del;
        private System.Windows.Forms.Button button_smb_mod;
        private System.Windows.Forms.ListView LSTV_smb;
        private System.Windows.Forms.Button button_ftp_mod;
        private System.Windows.Forms.Button button_ftp_del;
        private System.Windows.Forms.Button button_ftp_add;
        private System.Windows.Forms.Button button_sftp_mod;
        private System.Windows.Forms.Button button_sftp_del;
        private System.Windows.Forms.Button button_sftp_add;
        private System.Windows.Forms.ListView LSTV_ftp;
        private System.Windows.Forms.ListView LSTV_sftp;
        private System.Windows.Forms.Button button_clearLogs;
        private System.Windows.Forms.Button button_saveLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader smb_id;
        private System.Windows.Forms.ColumnHeader smb_friendlyName;
        private System.Windows.Forms.ColumnHeader smb_source;
        private System.Windows.Forms.ColumnHeader smb_destination;
        private System.Windows.Forms.ColumnHeader smb_added;
        private System.Windows.Forms.ColumnHeader smb_startSync;
        private System.Windows.Forms.ColumnHeader smb_stopSync;
        private System.Windows.Forms.ColumnHeader smb_deleteSource;
        private System.Windows.Forms.ColumnHeader smb_enabled;
        private System.Windows.Forms.Timer timer_AppLogs;
        private System.Windows.Forms.ColumnHeader ftp_id;
        private System.Windows.Forms.ColumnHeader ftp_FriendlyName;
        private System.Windows.Forms.ColumnHeader ftp_ip;
        private System.Windows.Forms.ColumnHeader ftp_Port;
        private System.Windows.Forms.ColumnHeader ftp_sharedFolder;
        private System.Windows.Forms.ColumnHeader ftp_destination;
        private System.Windows.Forms.ColumnHeader ftp_added;
        private System.Windows.Forms.ColumnHeader ftp_startSync;
        private System.Windows.Forms.ColumnHeader ftp_stopSync;
        private System.Windows.Forms.ColumnHeader ftp_deleteSource;
        private System.Windows.Forms.ColumnHeader ftp_enabled;
        private System.Windows.Forms.ToolStripMenuItem fTPSyncroniseFrequencyToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label_logged_in_username;
        private System.Windows.Forms.GroupBox LoggedIn_GBX;
        private System.Windows.Forms.Label label_logged_in_userLevel;
    }
}

