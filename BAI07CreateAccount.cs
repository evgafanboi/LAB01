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
    public partial class BAI07CreateAccount : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Lan { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
        public int Sex { get; set; } = 0;
        public DateTime Birthday;
        public DateTime DEFAULTDATETIME = new DateTime(2020, 1, 1); //Ngay hop le la 01/01/2020 tro ve truoc
        public BAI07CreateAccount()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            // Check cac input...
            if (UsernameInput.Text.Length < 3 || PasswordInput.Text.Length < 5)
            {
                MessageBox.Show("Tên tài khoản cần dài hơn 3 ký tự và mật khẩu nên dài ít nhất 5 ký tự!", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            if (EmailInput.Text.Length < 5 || !EmailInput.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            if (FirstNameInput.Text.Length == 0 || LastNameInput.Text.Length == 0)
            {
                MessageBox.Show("Họ, tên không đầy đủ!", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            if (BirthdayInput.Value >= DEFAULTDATETIME)
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Hãy thử lại!", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            if (FirstNameInput.Text == null || LastNameInput.Text == null)
            {
                MessageBox.Show("Tên không hợp lệ", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            if (PhoneNumberInput.Text == null || PhoneNumberInput.Text.Length < 8)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông tin không hợp lệ!", MessageBoxButtons.OK);
                return;
            }
            // Gan cac input

            Username = UsernameInput.Text;
            Password = PasswordInput.Text;
            Email = EmailInput.Text;
            Phone = PhoneNumberInput.Text;
            Lan = LanguageChoice.Text;
            FirstName = FirstNameInput.Text;
            LastName = LastNameInput.Text;
            if (MaleRadbtn.Checked)
            {
                Sex = 0;
            }
            if (FemaleRadbtn.Checked)
            {
                Sex = 1;
            }
            Birthday = BirthdayInput.Value.Date;
            Language = LanguageChoice.Text;
            DialogResult = DialogResult.OK;
            return;
        }

        private void FemaleRadbtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MaleRadbtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            UsernameInput.Clear();
            PasswordInput.Clear();
            EmailInput.Clear();
            PhoneNumberInput.Clear();
            FirstNameInput.Clear();
            LastNameInput.Clear();
            BirthdayInput.Value = DEFAULTDATETIME;
        }
    }
}
