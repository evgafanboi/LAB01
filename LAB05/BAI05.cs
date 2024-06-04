using MailKit;
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
    public partial class BAI05 : Form
    {
        private readonly BAI05DBContext _context;

        private List<MimeMessage> emails;
        public BAI05(BAI05DBContext context)
        {
            InitializeComponent();
            // Ensure the database is created if not create one
            _context = context;
        }

        private async void Loginbtn_Click(object sender, EventArgs e)   //vtmk ktps hnlo cuki   //sm0kew33d3v3ryd4y@gmail.com
        {
                if (listView1.Items.Count > 0)
                    listView1.Items.Clear();
                ImapClient client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                //  auth
                client.Authenticate(TextBoxEmail.Text, TextBoxPassword.Text);

                client.Inbox.Open(MailKit.FolderAccess.ReadOnly);

                Loginbtn.Text = "Reload";

                emails = new List<MimeMessage>();
                for (int i = 0; i < 10 && i < client.Inbox.Count; i++)
                {
                    var message = client.Inbox.GetMessage(i);
                var senderName = message.From.Mailboxes.FirstOrDefault()?.Name;
                if (string.IsNullOrWhiteSpace(senderName))
                    senderName = "Người ẩn danh";

                    if (message.Subject == "Đóng góp món ăn")
                    {
                        var email = new Email
                        {
                            Subject = message.Subject,
                            Body = message.TextBody,
                            IsRead = true,
                            sender = senderName
                        };
                        _context.Email.Add(email);
                        await _context.SaveChangesAsync();

                        var lines = message.TextBody.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < lines.Length; j++)
                    {
                        var parts = lines[j].Split(new[] { ';' }, 2, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 2)
                        {
                            //items.Add(parts[0].Trim());
                            //items.Add(parts[1].Trim());
                            ListViewItem item = new ListViewItem(message.Subject);
                            item.SubItems.Add(message.From.ToString());
                            item.SubItems.Add(message.Date.ToString());
                            var monAn = new MonAn
                            {
                                TenMonAn = parts[0],
                                imageURI = parts[1],
                                Id_Email = email.Id_Email
                            };
                            _context.MonAn.Add(monAn);
                        }
                    }

                        _context.SaveChanges();
                        client.Inbox.AddFlags(i, MessageFlags.Seen, true);
                    }


                }
                client.Disconnect(true);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
