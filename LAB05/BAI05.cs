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

        private async void Loginbtn_Click(object sender, EventArgs e)   //cilb sxxp wstx bzpy   //sm0kew33d3v3ryd4y@gmail.com
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

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                Loginbtn.Text = "Reload";

                emails = new List<MimeMessage>();
                foreach (var uid in inbox.Search(SearchQuery.NotSeen))
                {
                    var message = inbox.GetMessage(uid);
                    if (message.Subject == "Đóng góp món ăn")
                    {
                        var email = new Email
                        {
                            Subject = message.Subject,
                            Body = message.TextBody,
                            IsRead = true,
                            sender = message.Sender.ToString()
                        };
                        _context.Email.Add(email);
                        await _context.SaveChangesAsync();

                        var lines = message.TextBody.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < lines.Length; i += 2)
                        {
                            var monAn = new MonAn
                            {
                                TenMonAn = lines[i],
                                imageURI = lines[i + 1],
                                Id_Email = email.Id_Email
                            };
                            _context.MonAn.Add(monAn);
                        }

                        _context.SaveChanges();
                        inbox.AddFlags(uid, MessageFlags.Seen, true);
                    }

                client.Disconnect(true);

                }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
