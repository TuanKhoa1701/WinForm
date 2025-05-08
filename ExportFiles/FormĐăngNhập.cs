using Barcodescanner;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExportExcel
{
    public partial class FormĐăngNhập : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public FormĐăngNhập()
        {
            InitializeComponent();
        }

        private void FormĐăngNhập_Load(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\tuank\Pictures\Saved Pictures\qr_code1.jpg"; // Thay thế bằng đường dẫn của hình ảnh bạn muốn tải

            
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void ĐăngNhập_Click(object sender, EventArgs e)
        {
            string user = textĐăngNhập.Text;
            if (KiemTraDangNhap(textĐăngNhập.Text, textMậtKhẩu.Text))
            {
                Form1 f = new Form1(user);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi");
                textĐăngNhập.Focus();
            }
            textĐăngNhập.Clear();
            textMậtKhẩu.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textMậtKhẩu_TextChanged(object sender, EventArgs e)
        {
          
            textMậtKhẩu.UseSystemPasswordChar = true;
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0;i < listTaiKhoan.Count; i++)
            {
                if(tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau1)
                    return true;
            }
            return false;
        }

        private void textMậtKhẩu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
            ĐăngNhập_Click(sender, e);
            }
        }


        private void FormĐăngNhập_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
