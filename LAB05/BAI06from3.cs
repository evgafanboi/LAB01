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
using System.Xml.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Utils;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace LAB05
{
    public partial class BAI06from3 : Form
    {
        SmtpClient smtpClient = null;
        InternetAddress from = null;
        InternetAddress to = null;
        MimeMessage original_message = null;
        bool IsAReply = false;
        bool IsAForward = false;
        public BAI06from3(SmtpClient client, InternetAddress from, InternetAddress to = null, bool IsAReply = false, MimeMessage original_message = null, bool IsAForward = false)
        {
            InitializeComponent();
            smtpClient = client;
            this.from = from;
            this.to = to;
            this.original_message = original_message;
            this.IsAForward = IsAForward;

            TextBoxFrom.Text = from.ToString();
            TextBoxFrom.Enabled = false;
            if(to != null)
            {
                TextBoxTo.Text = to.ToString();
                TextBoxTo.Enabled = false;
            }
            this.IsAReply = IsAReply;
            if(this.IsAReply || this.IsAForward)
            {
                TextBoxSubject.Enabled = false;
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if(TextBoxTo.Text == "")
            {
                MessageBox.Show("Please enter the receiver email");
                return;
            }
            if (IsAForward)
            {
                    to = new MailboxAddress("", TextBoxTo.Text);
                   var message_to_send = Forward(original_message,from,to,RichTextBoxOutput.Text);
                    smtpClient.Send(message_to_send);
                    return;
            }
            if(IsAReply)
            {
                    var message_to_send = Reply(original_message, from, false);
                    smtpClient.Send(message_to_send);
                    return;
            }
            var message = new MimeMessage();
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

        public static MimeMessage Forward(MimeMessage original, InternetAddress from, InternetAddress to, string message_text)
        {
            var message = new MimeMessage();
            message.From.Add(from);
            message.To.Add(to);

            // set the forwarded subject
                // add "Fw:" to the beginning of the subject if it doesn't already start with it
            if (!original.Subject.StartsWith("FW:", StringComparison.OrdinalIgnoreCase))
                message.Subject = "FW: " + original.Subject;
            else
                message.Subject = original.Subject;

            // quote the original message text
            StringWriter text = new StringWriter();
            text.WriteLine();
            text.WriteLine("-------- Original Message --------");
            text.WriteLine("Subject: {0}", original.Subject);
            text.WriteLine("Date: {0}", DateUtils.FormatDate(original.Date));
            text.WriteLine("From: {0}", original.From);
            text.WriteLine("To: {0}", original.To);
            text.WriteLine();

                text.Write(original.TextBody);

                message.Body = new TextPart("plain")
                {
                    Text = text.ToString()
                };
            

            // create the message/rfc822 attachment for the original message
            var rfc822 = new MessagePart { Message = original };
            // text part
            var textPart = new TextPart("plain")
            {
                Text = message_text
            };


            // create a multipart/mixed container for the text body and the forwarded message
            var multipart = new Multipart("mixed");
            multipart.Add(textPart);
            multipart.Add(rfc822);

            // set the multipart as the body of the message
            message.Body = multipart;

            return message;
        }


        public static MimeMessage Reply(MimeMessage message, InternetAddress from, bool replyToAll)
        {
            var reply = new MimeMessage();

            reply.From.Add(from);

            // reply to the sender of the message
            if (message.ReplyTo.Count > 0)
            {
                reply.To.AddRange(message.ReplyTo);
            }
            else if (message.From.Count > 0)
            {
                reply.To.AddRange(message.From);
            }
            else if (message.Sender != null)
            {
                reply.To.Add(message.Sender);
            }

            if (replyToAll)
            {
                // include all of the other original recipients
                reply.To.AddRange(message.To);
                reply.Cc.AddRange(message.Cc);
            }

            // set the reply subject
            if (!message.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                reply.Subject = "Re: " + message.Subject;
            else
                reply.Subject = message.Subject;

            // construct the In-Reply-To and References headers
            if (!string.IsNullOrEmpty(message.MessageId))
            {
                reply.InReplyTo = message.MessageId;
                foreach (var id in message.References)
                    reply.References.Add(id);
                reply.References.Add(message.MessageId);
            }

            // quote the original message text
            using (var quoted = new StringWriter())
            {
                var sender = message.Sender ?? message.From.Mailboxes.FirstOrDefault();

                quoted.WriteLine("On {0}, {1} wrote:", message.Date.ToString("f"), !string.IsNullOrEmpty(sender.Name) ? sender.Name : sender.Address);
                using (var reader = new StringReader(message.TextBody))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        quoted.Write("> ");
                        quoted.WriteLine(line);
                    }
                }

                reply.Body = new TextPart("plain")
                {
                    Text = quoted.ToString()
                };
            }

            return reply;
        }
    }
}
