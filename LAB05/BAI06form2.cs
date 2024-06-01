using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
{
    public partial class BAI06form2 : Form
    {
        string HTMLText = null;
        MimeKit.InternetAddressList Receivers = null;
        MimeKit.InternetAddressList Senders = null;
        string Subject = null;
        public BAI06form2(MimeKit.InternetAddressList sender, MimeKit.InternetAddressList receiver, string hTMLText,string subject)
        {
            InitializeComponent();
            Senders = sender;
            Receivers = receiver;
            HTMLText = hTMLText;
            Subject = subject;

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
    }
}
