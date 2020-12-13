namespace FileSyncer
{
    partial class UserListFRM
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
            this.button_new = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.listView_users = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.Color.White;
            this.button_new.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_new.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_new.Location = new System.Drawing.Point(225, 20);
            this.button_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(87, 30);
            this.button_new.TabIndex = 1;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_mod
            // 
            this.button_mod.BackColor = System.Drawing.Color.White;
            this.button_mod.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_mod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_mod.Location = new System.Drawing.Point(225, 58);
            this.button_mod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(87, 30);
            this.button_mod.TabIndex = 2;
            this.button_mod.Text = "Modify";
            this.button_mod.UseVisualStyleBackColor = false;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.White;
            this.button_del.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del.ForeColor = System.Drawing.Color.Tomato;
            this.button_del.Location = new System.Drawing.Point(225, 96);
            this.button_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(87, 30);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Delete";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // listView_users
            // 
            this.listView_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_users.FullRowSelect = true;
            this.listView_users.HideSelection = false;
            this.listView_users.Location = new System.Drawing.Point(20, 20);
            this.listView_users.Name = "listView_users";
            this.listView_users.Size = new System.Drawing.Size(180, 225);
            this.listView_users.TabIndex = 6;
            this.listView_users.UseCompatibleStateImageBehavior = false;
            this.listView_users.SelectedIndexChanged += new System.EventHandler(this.listView_users_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UserName";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            // 
            // UserListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.listView_users);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_new);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserListFRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Managment";
            this.Load += new System.EventHandler(this.UserListFRM_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.ListView listView_users;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}