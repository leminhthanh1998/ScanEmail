namespace GetEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonWebsite = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.txbWebsite = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnGuiMail = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txbText = new System.Windows.Forms.RichTextBox();
            this.txbKetQua = new System.Windows.Forms.RichTextBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonWebsite
            // 
            this.radioButtonWebsite.AutoSize = true;
            this.radioButtonWebsite.Checked = true;
            this.radioButtonWebsite.Location = new System.Drawing.Point(13, 13);
            this.radioButtonWebsite.Name = "radioButtonWebsite";
            this.radioButtonWebsite.Size = new System.Drawing.Size(64, 17);
            this.radioButtonWebsite.TabIndex = 1;
            this.radioButtonWebsite.TabStop = true;
            this.radioButtonWebsite.Text = "Website";
            this.radioButtonWebsite.UseVisualStyleBackColor = true;
            this.radioButtonWebsite.CheckedChanged += new System.EventHandler(this.radioButtonWebsite_CheckedChanged);
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(13, 36);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(65, 17);
            this.radioButtonText.TabIndex = 2;
            this.radioButtonText.Text = "Văn bản";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // txbWebsite
            // 
            this.txbWebsite.Location = new System.Drawing.Point(97, 12);
            this.txbWebsite.Name = "txbWebsite";
            this.txbWebsite.Size = new System.Drawing.Size(553, 20);
            this.txbWebsite.TabIndex = 3;
            // 
            // btnScan
            // 
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.Location = new System.Drawing.Point(68, 227);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnGuiMail
            // 
            this.btnGuiMail.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiMail.Image")));
            this.btnGuiMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuiMail.Location = new System.Drawing.Point(288, 227);
            this.btnGuiMail.Name = "btnGuiMail";
            this.btnGuiMail.Size = new System.Drawing.Size(75, 23);
            this.btnGuiMail.TabIndex = 6;
            this.btnGuiMail.Text = "   Gửi mail";
            this.btnGuiMail.UseVisualStyleBackColor = true;
            this.btnGuiMail.Click += new System.EventHandler(this.btnGuiMail_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(515, 227);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 23);
            this.btnXuatFile.TabIndex = 7;
            this.btnXuatFile.Text = "    Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(662, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel.Text = "Trạng thái: ";
            // 
            // txbText
            // 
            this.txbText.Location = new System.Drawing.Point(12, 59);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(638, 150);
            this.txbText.TabIndex = 9;
            this.txbText.Text = "";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(12, 269);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(638, 150);
            this.txbKetQua.TabIndex = 10;
            this.txbKetQua.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 447);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnGuiMail);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txbWebsite);
            this.Controls.Add(this.radioButtonText);
            this.Controls.Add(this.radioButtonWebsite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanEmail - Code by Le Minh Thanh";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonWebsite;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.TextBox txbWebsite;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnGuiMail;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox txbText;
        private System.Windows.Forms.RichTextBox txbKetQua;
    }
}

