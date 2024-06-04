using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;

namespace LAB05
{
    public partial class BAI01 : Form
    {
        public BAI01()
        {
            InitializeComponent();
        }

        private string pw;
        private string name;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);

                if (string.IsNullOrEmpty(pw))
                {
                    BAI01pw input = new BAI01pw();
                    if (input.ShowDialog() == DialogResult.OK)
                    {
                        pw = input.pw;
                        name = input.name;  
                    }

                }
                client.Authenticate(FromTextbox.Text, pw);

                var message = new MimeMessage();

                message.From.Add(new MailboxAddress(name, FromTextbox.Text));
                message.To.Add(new MailboxAddress("", ToTextbox.Text));

                message.Subject = SubjectTextbox.Text;
                message.Body = new TextPart("plain")
                {
                    Text = BodyInput.Text
                };
                client.Send(message);

                MessageBox.Show("Mail đã gửi thành công...", "Thông báo", MessageBoxButtons.OK);

                BodyInput.Text = "";
                SubjectTextbox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
