using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MimeKit;
using MimeKit.Cryptography;

namespace LAB05
{
    public partial class BAI03 : Form
    {
        public BAI03()
        {
            InitializeComponent();
        }

        private List<MimeMessage> emails;

        private async void Loginbtn_Click(object sender, EventArgs e)
        {
            if (modeCB.SelectedItem.ToString() == "IMAP")
            {
                if (listView1.Items.Count > 0)
                    listView1.Items.Clear();
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

                Loginbtn.Text = "Reload";

                emails = new List<MimeMessage>();

                for (int i = 0; i < limitPicker.Value && i < client.Inbox.Count; i++)
                {
                    MimeMessage message = await client.Inbox.GetMessageAsync(client.Inbox.Count - 1 - i);
                    emails.Add(message);
                    ListViewItem item = new ListViewItem(message.Subject);
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    // Also add a tag here to retrieve it later in case user wants to read the email
                    item.Tag = message;
                    listView1.Items.Add(item);
                }
            }
            else if (modeCB.SelectedItem.ToString() == "POP")
            {
                if (listView1.Items.Count > 0)
                    listView1.Items.Clear();
                Pop3Client client = new Pop3Client();
                try
                {
                    await client.ConnectAsync("pop.gmail.com", 995, true);
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

                Loginbtn.Text = "Reload";

                emails = new List<MimeMessage>();

                for (int i = 0; i < limitPicker.Value && i < client.Count; i++)
                {
                    MimeMessage message = await client.GetMessageAsync(i);
                    emails.Add(message);
                    ListViewItem item = new ListViewItem(message.Subject);
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    // Also add a tag here to retrieve it later in case user wants to read the email
                    item.Tag = message;
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reserved
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selected = listView1.SelectedItems[0];
                BAI03View handler = new BAI03View(selected.Tag as MimeMessage);
                if (handler.ShowDialog() == DialogResult.OK)
                    handler.Close();
            }
            else
            {
                MessageBox.Show("Error opening this email.");
            }
        }
    }
}
