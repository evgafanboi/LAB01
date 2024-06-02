using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;


namespace LAB05
{
    public partial class BAI06form2 : Form
    {
        string HTMLText = null;
        MimeKit.InternetAddressList Receivers = null;
        MimeKit.InternetAddressList Senders = null;
        SmtpClient smtpClient = null;
        string Subject = null;
        MimeMessage message= null;

        public BAI06form2(MimeKit.InternetAddressList sender, MimeKit.InternetAddressList receiver, MimeMessage message , SmtpClient sendclient)
        {
            InitializeComponent();
            Senders = sender;
            Receivers = receiver;
            HTMLText = message.HtmlBody;
            Subject = message.Subject;
            smtpClient = sendclient;
            this.message = message;

            LabelFrom.Text = "From: ";
            foreach (MimeKit.MailboxAddress mailbox in Senders)
            {
                LabelFrom.Text += mailbox.Address + "; ";
            }

            LabelTo.Text = "To: ";
            foreach (MimeKit.MailboxAddress mailbox in Receivers)
            {
                LabelTo.Text += mailbox.Address + "; ";
            }

            LabelTitle.Text = "Subject: " + Subject;
            //display email content html with webview2
            WebView2_Output.EnsureCoreWebView2Async();
        }

        private void WebView2_Output_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                WebView2_Output.CoreWebView2.NavigateToString(HTMLText);
            }
            catch 
            {
                MessageBox.Show("Error when displaying the email content");
                return;
            }
        }

        private void ButtonReply_Click(object sender, EventArgs e)
        {
            //get the first sender and receiver and call the form3
            var _sender = Senders[0];
            var _receiver = Receivers[0];
            BAI06from3 form3 = new BAI06from3(smtpClient, _receiver, _sender, true, message);
            form3.Show();
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            //get the first sender and receiver and call the form3
            var _sender = Senders[0];
            var _receiver = Receivers[0];
            BAI06from3 form3 = new BAI06from3(smtpClient, _receiver, null, false, message, true);
            form3.Show();
        }
    }
}
