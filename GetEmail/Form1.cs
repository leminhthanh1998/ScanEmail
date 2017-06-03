using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace GetEmail
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txbText.Enabled = txbKetQua.Enabled= false;
        }
        private List<string> dsEmail = new List<string>();
        private string noiDungWebSite = "";
        private int emailBanDau = 0;

        public List<string> DsEmail { get => dsEmail; set => dsEmail = value; }


        


        #region thay doi giao dien
        private void radioButtonWebsite_CheckedChanged(object sender, EventArgs e)
        {
            txbText.Enabled = !txbText.Enabled;
        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            txbWebsite.Enabled = !txbWebsite.Enabled;
        }
        #endregion

        /// <summary>
        /// Lấy nội dung của website
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private string GetNoiDungWebSite(string link)
        {
            string text="";
            try
            {
                WebClient wc = new WebClient();
                text = wc.DownloadString(link);
            }
            catch (Exception)
            {
                MessageBox.Show("Không có kết nối Internet!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return text;
        }

        /// <summary>
        /// Lấy email từ text
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private List<string> GetEmail(string data)
        {
            Regex regex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(data);
            List<string> list = new List<string>();
            foreach (Match match in matchCollection)
            {
                list.Add(match.Value.ToLower());
            }
            emailBanDau = list.Count;
            return Form1.XoaDuplicates(list);
        }

        private static List<string> XoaDuplicates(List<string> inputList)
        {
            List<string> list = new List<string>();
            foreach (string current in inputList)
            {
                if (!Form1.Contains(list, current))
                {
                    list.Add(current);
                }
            }
            return list;
        }

        private static bool Contains(List<string> list, string comparedValue)
        {
            bool result;
            foreach (string current in list)
            {
                if (current == comparedValue)
                {
                    result = true;
                    return result;
                }
            }
            result = false;
            return result;
        }

        /// <summary>
        /// Scan email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            if (radioButtonWebsite.Checked && txbWebsite.Text.StartsWith("http://"))
            {
                txbKetQua.Enabled = true;
                noiDungWebSite = GetNoiDungWebSite(txbWebsite.Text);
                DsEmail = GetEmail(noiDungWebSite);
                txbKetQua.Text = string.Join(Environment.NewLine, DsEmail);
                toolStripStatusLabel.Text = "Đã tìm thấy " + DsEmail.Count + " email. Đã loại bỏ " + (emailBanDau - DsEmail.Count) + " email trùng lập.";
            }
            else if (radioButtonText.Checked && txbText.Text != "")
            {
                txbKetQua.Enabled = true;
                DsEmail = GetEmail(txbText.Text);
                txbKetQua.Text = string.Join(Environment.NewLine, DsEmail);
                toolStripStatusLabel.Text = "Đã tìm thấy " + DsEmail.Count + " email. Đã loại bỏ " + (emailBanDau - DsEmail.Count) + " email trùng lập.";
            }
            else MessageBox.Show("Bạn chưa nhập nội dung !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Xuất file danh sách email
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt|Microsoft Excel|*.xls|Microsoft Word |*.doc";
            saveFileDialog.Title = "Lưu Email ra File Excel hoặc Word";
            if (txbKetQua.Text == "")
            {
                MessageBox.Show("Chưa có dứ liệu để lưu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllLines(saveFileDialog.FileName, DsEmail);
                    MessageBox.Show("Thành công!");
                }
            }
        }

        //Mở form gửi mail lên
        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            if (dsEmail.Count > 0)
            {
                GuiMail send = new GuiMail();
                send.Show(this);
            }
            else MessageBox.Show("Không có dữ liệu để tiến hành gửi mail !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
