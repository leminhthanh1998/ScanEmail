namespace GetEmail
{
    partial class GuiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiMail));
            this.label1 = new System.Windows.Forms.Label();
            this.txbDinhKem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTieuDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbNoiDung = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.butMoFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbHost = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.cmbDichVu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đính kèm";
            // 
            // txbDinhKem
            // 
            this.txbDinhKem.Location = new System.Drawing.Point(100, 21);
            this.txbDinhKem.Name = "txbDinhKem";
            this.txbDinhKem.ReadOnly = true;
            this.txbDinhKem.Size = new System.Drawing.Size(258, 20);
            this.txbDinhKem.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gửi đến";
            // 
            // txbTieuDe
            // 
            this.txbTieuDe.Location = new System.Drawing.Point(100, 73);
            this.txbTieuDe.Name = "txbTieuDe";
            this.txbTieuDe.Size = new System.Drawing.Size(258, 20);
            this.txbTieuDe.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mật khẩu";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(100, 99);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(258, 20);
            this.txbUsername.TabIndex = 2;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(100, 125);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(258, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // txbNoiDung
            // 
            this.txbNoiDung.Location = new System.Drawing.Point(12, 170);
            this.txbNoiDung.Name = "txbNoiDung";
            this.txbNoiDung.Size = new System.Drawing.Size(585, 197);
            this.txbNoiDung.TabIndex = 4;
            this.txbNoiDung.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nội dung";
            // 
            // butSend
            // 
            this.butSend.Image = ((System.Drawing.Image)(resources.GetObject("butSend.Image")));
            this.butSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSend.Location = new System.Drawing.Point(283, 373);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 5;
            this.butSend.Text = "Gửi";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butMoFile
            // 
            this.butMoFile.Location = new System.Drawing.Point(364, 20);
            this.butMoFile.Name = "butMoFile";
            this.butMoFile.Size = new System.Drawing.Size(17, 21);
            this.butMoFile.TabIndex = 13;
            this.butMoFile.UseVisualStyleBackColor = true;
            this.butMoFile.Click += new System.EventHandler(this.butMoFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dịch vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Host:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Port:";
            // 
            // txbHost
            // 
            this.txbHost.Location = new System.Drawing.Point(44, 53);
            this.txbHost.Name = "txbHost";
            this.txbHost.Size = new System.Drawing.Size(160, 20);
            this.txbHost.TabIndex = 17;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(44, 79);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(68, 20);
            this.txbPort.TabIndex = 18;
            // 
            // cmbDichVu
            // 
            this.cmbDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDichVu.FormattingEnabled = true;
            this.cmbDichVu.Items.AddRange(new object[] {
            "Gmail",
            "Outlook",
            "Tự chọn"});
            this.cmbDichVu.Location = new System.Drawing.Point(60, 26);
            this.cmbDichVu.Name = "cmbDichVu";
            this.cmbDichVu.Size = new System.Drawing.Size(62, 21);
            this.cmbDichVu.TabIndex = 19;
            this.cmbDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbDichVu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDichVu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbPort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbHost);
            this.groupBox1.Location = new System.Drawing.Point(387, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 121);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập smtp";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(81, 413);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(510, 23);
            this.progressBar.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tiến trình:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(97, 50);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(41, 13);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "label11";
            // 
            // GuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 443);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butMoFile);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNoiDung);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTieuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDinhKem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuiMail";
            this.Text = "ScanEmail - Code by Le Minh Thanh";
            this.Load += new System.EventHandler(this.GuiMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDinhKem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTieuDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.RichTextBox txbNoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butMoFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbHost;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.ComboBox cmbDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTo;
    }
}