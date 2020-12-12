
namespace FileSyncer.Boundary
{
    partial class FrequencyFRM
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
            this.label_ftp = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_tftp = new System.Windows.Forms.Label();
            this.numericUpDown_ftp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rsync = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ftp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rsync)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ftp
            // 
            this.label_ftp.AutoSize = true;
            this.label_ftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ftp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ftp.Location = new System.Drawing.Point(20, 20);
            this.label_ftp.Name = "label_ftp";
            this.label_ftp.Size = new System.Drawing.Size(131, 20);
            this.label_ftp.TabIndex = 10;
            this.label_ftp.Text = "FTP sync in every";
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_ok.Location = new System.Drawing.Point(168, 122);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 30);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_cancel.Location = new System.Drawing.Point(51, 122);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 30);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_tftp
            // 
            this.label_tftp.AutoSize = true;
            this.label_tftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tftp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_tftp.Location = new System.Drawing.Point(20, 70);
            this.label_tftp.Name = "label_tftp";
            this.label_tftp.Size = new System.Drawing.Size(140, 20);
            this.label_tftp.TabIndex = 13;
            this.label_tftp.Text = "TFTP sync in every";
            // 
            // numericUpDown_ftp
            // 
            this.numericUpDown_ftp.Location = new System.Drawing.Point(168, 20);
            this.numericUpDown_ftp.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown_ftp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ftp.Name = "numericUpDown_ftp";
            this.numericUpDown_ftp.Size = new System.Drawing.Size(51, 25);
            this.numericUpDown_ftp.TabIndex = 14;
            this.numericUpDown_ftp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_ftp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_rsync
            // 
            this.numericUpDown_rsync.Location = new System.Drawing.Point(168, 70);
            this.numericUpDown_rsync.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown_rsync.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_rsync.Name = "numericUpDown_rsync";
            this.numericUpDown_rsync.Size = new System.Drawing.Size(51, 25);
            this.numericUpDown_rsync.TabIndex = 15;
            this.numericUpDown_rsync.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_rsync.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "minute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(223, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "minute";
            // 
            // FrequencyFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_rsync);
            this.Controls.Add(this.numericUpDown_ftp);
            this.Controls.Add(this.label_tftp);
            this.Controls.Add(this.label_ftp);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrequencyFRM";
            this.ShowIcon = false;
            this.Text = "Frequency Settings";
            this.Load += new System.EventHandler(this.FrequencyFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ftp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rsync)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ftp;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_tftp;
        private System.Windows.Forms.NumericUpDown numericUpDown_ftp;
        private System.Windows.Forms.NumericUpDown numericUpDown_rsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}