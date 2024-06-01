using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace LAB05
{
    public partial class BAI06from3 : Form
    {
        SmtpClient smtpClient = null;
        MailboxAddress from = null;
        MailboxAddress to = null;
        public BAI06from3(SmtpClient client, MailboxAddress from, MailboxAddress to = null)
        {
            InitializeComponent();
            smtpClient = client;
            this.from = from;
            this.to = to;
            if(to != null)
            {
                TextBoxTo.Text = to.Address;
                TextBoxTo.Enabled = false;
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            if(TextBoxTo.Text == "")
            {
                MessageBox.Show("Please enter the receiver email");
                return;
            }
            if(to == null)
            {
                to = new MailboxAddress("",TextBoxTo.Text);
            }
            else
            {
                message.From.Add(from);
                message.To.Add(to);
            }
            message.Subject = TextBoxSubject.Text;
            message.Body = new TextPart("plain") // plain text
            {
                Text = RichTextBoxOutput.Text
            };
            smtpClient.Send(message);
        }
    }
}
