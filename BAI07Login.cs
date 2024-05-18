using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI07Login : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RequestNewAccount { get; private set; } = false;
        public BAI07Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RequestNewAccount = true; // Xac nhan nguoi dung tao tai khoan thay vi dang nhap
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text.Length <3 || PasswordInput.Text.Length <5)   //Neu input khong hop le thi tu choi xu ly va yeu cau nhap lai
            {
                MessageBox.Show("Vui lòng nhập lại! Tài khoản phải dài ít nhất 3 ký tự và mật khẩu dài ít nhất 5 ký tự!", "Lỗi", MessageBoxButtons.OK);
            }
            Username = UsernameInput.Text;
            Password = PasswordInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
