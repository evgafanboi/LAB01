using MailKit.Net.Imap;
using MimeKit;
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
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }

            ImapClient client;
        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            ImapClient client = new ImapClient();
            try
            {
                await client.ConnectAsync("imap.gmail.com", 993, true);
            }
            catch
            {
                MessageBox.Show("Can't connect to server");
            }
            //auth
            try
            {
                await client.AuthenticateAsync(TextBoxEmail.Text, TextBoxPassword.Text);
            }
            catch
            {
                MessageBox.Show("Can't authenticate");
            }
            try
            {
                await client.Inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);
            }
            catch
            {
                MessageBox.Show("Can't open inbox");
            }
            //read the first 10 email or less
            for (int i = 0; i < 10 && i < client.Inbox.Count; i++)
            {
                MimeMessage message = await client.Inbox.GetMessageAsync(i);
                ListViewItem item = new ListViewItem(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                listView1.Items.Add(item);
            }
            ButtonLogin.Enabled = false;
            ButtonLogOut.Enabled = true;
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            client.Dispose();
            client = null;
            ButtonLogOut.Enabled = false;
            ButtonLogin.Enabled = true;
        }
    }
}
