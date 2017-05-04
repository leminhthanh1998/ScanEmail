using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Threading;

namespace GetEmail
{
    public partial class GuiMail : Form
    {
        
        Attachment attach;
        public GuiMail()
        {
            InitializeComponent();
            cmbDichVu.SelectedIndex = 0;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.WorkerReportsProgress = true;
        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            butSend.Enabled = true;
            if(checkSendMail)
                MessageBox.Show("Đã gửi thành công đến "+dsMail.Count+" email!");
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            checkSendMail = true;
            attach = null;
            try
            {
                FileInfo info = new FileInfo(txbDinhKem.Text);
                attach = new Attachment(txbDinhKem.Text);
            }
            catch (Exception)
            {
            }
            from = txbUsername.Text;
            tieude = txbTieuDe.Text;
            txbNoiDung.Invoke((MethodInvoker)delegate
            {
                noidung = txbNoiDung.Text;
            });
            int percentage = 0;
            int phanTram = 1;
            foreach (string item in dsMail)
            {
                to = item;
                try
                {
                    SendMail();
                }
                catch (Exception)
                {
                    checkSendMail = false;
                    MessageBox.Show("Đã có lỗi, hãy kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                percentage = (phanTram ++) * 100 / dsMail.Count;
                worker.ReportProgress(percentage);
            }
            
        }

        private string[] dsSmtp = { "smtp.gmail.com", "smtp-mail.outlook.com" };
        private int smtpPort=587;
        string to;
        string from;
        string noidung;
        string tieude;
        private bool checkSendMail = true;
        private List<string> dsMail = new List<string>();
        BackgroundWorker worker = new BackgroundWorker();
        private void butSend_Click(object sender, EventArgs e)
        {
            butSend.Enabled = false;
            
            worker.RunWorkerAsync();
        }

        

        private void SendMail()
        {
            MailMessage mess = new MailMessage(from, to, tieude, noidung);
            if(attach!=null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient(txbHost.Text, Convert.ToInt32(txbPort.Text));
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(txbUsername.Text, txbPassword.Text);
            
            client.Send(mess);
        }

        private void butMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                txbDinhKem.Text = dialog.FileName;
            }
        }

        private void GuiMail_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            labelTo.Text = form1.DsEmail.Count + " email đã tìm thấy";
            dsMail = form1.DsEmail;
        }

        private void cmbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDichVu.SelectedIndex==0)
            {
                txbHost.Text = dsSmtp[0];
                txbPort.Text = smtpPort.ToString();
            }
            else if(cmbDichVu.SelectedIndex==1)
                    {
                txbHost.Text = dsSmtp[1];
                txbPort.Text = smtpPort.ToString();
            }
            else {
                txbHost.Text = "";
                txbPort.Text = "";
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (txbUsername.Text.Contains("gmail.com"))
            {
                cmbDichVu.SelectedIndex = 0;
            }
            else if (txbUsername.Text.Contains("outlook.com"))
            {
                cmbDichVu.SelectedIndex = 1;
            }
            else cmbDichVu.SelectedIndex = 2;
        }
    }
}
