using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
{
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }

            ImapClient client = new ImapClient();
            SmtpClient smtpClient = new SmtpClient();

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            ButtonLogin.Enabled = false;
            ButtonLogOut.Enabled = true;
            TextBoxEmail.Enabled = false;
            TextBoxPassword.Enabled = false;
            try
            {
                await client.ConnectAsync("imap.gmail.com", 993, true);
                await smtpClient.ConnectAsync("smtp.gmail.com", 465, true);
            }
            catch
            {
                MessageBox.Show("Can't connect to server");
                return;
            }
            //auth
            try
            {
                await client.AuthenticateAsync(TextBoxEmail.Text, TextBoxPassword.Text);
                await smtpClient.AuthenticateAsync(TextBoxEmail.Text, TextBoxPassword.Text);
            }
            catch
            {
                MessageBox.Show("Can't authenticate");
                return;
            }
            try
            {
                await client.Inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);
            }
            catch
            {
                MessageBox.Show("Can't open inbox");
                return;
            }
            //disable the listview until the email is loaded
            listView1.Enabled = false;
            //read the first 10 email or less
            for (int i = 0; i < 10 && i < client.Inbox.Count; i++)
            {
                MimeMessage message = await client.Inbox.GetMessageAsync(i);
                ListViewItem item = new ListViewItem(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                listView1.Items.Add(item);
            }
            listView1.Enabled = true;
            ButtonSend.Enabled = true;
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            client.Dispose();
            client = new ImapClient();
            smtpClient.Dispose();
            smtpClient = new SmtpClient();
            ButtonLogOut.Enabled = false;
            ButtonLogin.Enabled = true;
            TextBoxEmail.Enabled = true;
            TextBoxPassword.Enabled = true;
            //clear listview
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //print the selected item index
            if (listView1.SelectedItems.Count > 0)
            {
                //MessageBox.Show(listView1.SelectedItems[0].Index.ToString());
                //open the selected email
                MimeMessage message = client.Inbox.GetMessage(listView1.SelectedItems[0].Index);
                //MessageBox.Show(message.HtmlBody);
                BAI06form2 form2 = new BAI06form2(message.From, message.To, message,smtpClient);
                form2.Show();
                
            }

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            MailboxAddress from = new MailboxAddress("", TextBoxEmail.Text);
            BAI06from3 form3 = new BAI06from3(smtpClient, from);
            form3.Show();
        }
    }
}
