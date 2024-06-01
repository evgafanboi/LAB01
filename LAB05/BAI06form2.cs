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


namespace LAB05
{
    public partial class BAI06form2 : Form
    {
        string HTMLText = null;
        MimeKit.InternetAddressList Receivers = null;
        MimeKit.InternetAddressList Senders = null;
        SmtpClient smtpClient = null;
        string Subject = null;
        public BAI06form2(MimeKit.InternetAddressList sender, MimeKit.InternetAddressList receiver, string hTMLText,string subject,SmtpClient sendclient)
        {
            InitializeComponent();
            Senders = sender;
            Receivers = receiver;
            HTMLText = hTMLText;
            Subject = subject;
            smtpClient = sendclient;

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
            WebView2_Output.CoreWebView2.NavigateToString(HTMLText);
        }

        private void ButtonReply_Click(object sender, EventArgs e)
        {
            //get the first sender and receiver and call the form3
            //MimeKit.MailboxAddress _sender = Senders.;
            //MimeKit.MailboxAddress _receiver = Receivers[0];
            //BAI06from3 form3 = new BAI06from3(smtpClient, Senders, Receivers);
        }
    }
}
