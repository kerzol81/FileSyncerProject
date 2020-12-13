
namespace FileSyncer.Boundary
{
    partial class LoginFRM
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
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_passWord = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_user.Location = new System.Drawing.Point(30, 30);
            this.label_user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(98, 20);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "UserName ";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_password.Location = new System.Drawing.Point(30, 80);
            this.label_password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(86, 20);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.Location = new System.Drawing.Point(136, 27);
            this.textBox_userName.MaxLength = 16;
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(120, 26);
            this.textBox_userName.TabIndex = 1;
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passWord.Location = new System.Drawing.Point(136, 77);
            this.textBox_passWord.MaxLength = 64;
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.PasswordChar = '*';
            this.textBox_passWord.Size = new System.Drawing.Size(120, 26);
            this.textBox_passWord.TabIndex = 2;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(136, 121);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(120, 45);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 191);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_passWord);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginFRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filesyncer Application Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_passWord;
        private System.Windows.Forms.Button button_login;
    }
}