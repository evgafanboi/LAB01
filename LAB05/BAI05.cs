using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MimeKit;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;
using System.Linq;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;
using static System.Windows.Forms.LinkLabel;

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

        private async void Loginbtn_Click(object sender, EventArgs e)
        {
                if (OutputListview.Items.Count > 0)
                    OutputListview.Items.Clear();
                ImapClient client = new ImapClient();
                await client.ConnectAsync("imap.gmail.com", 993, true);
                //  auth
                await client.AuthenticateAsync(TextBoxEmail.Text, TextBoxPassword.Text);

                await client.Inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);

                Loginbtn.Text = "Reload";

                emails = new List<MimeMessage>();
                for (int i = 0; i < 3 && i < client.Inbox.Count; i++)
                {
                    var message = client.Inbox.GetMessage(client.Inbox.Count - i - 1);
                var senderName = message.From.Mailboxes.FirstOrDefault()?.Name;
                if (string.IsNullOrWhiteSpace(senderName))
                    senderName = "Người ẩn danh";

                    if (message.Subject.Contains(""))
                    {
                        var email = new Email
                        {
                            Subject = message.Subject,
                            Body = message.TextBody,
                            IsRead = true,
                            sender = senderName
                        };
                    emails.Add(message);
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
                            OutputListview.Items.Add(item);
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

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
