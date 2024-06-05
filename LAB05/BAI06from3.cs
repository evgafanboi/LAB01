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
        string AttachPath = null;
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
                if(message_to_send == null)
                {
                    return;
                }
                try
                {
                    smtpClient.Send(message_to_send);
                }
                catch
                {
                    MessageBox.Show("Mail failed to be sent");
                    return;
                }
                    MessageBox.Show("Mail sent");
                return;
            }
            if(IsAReply)
            {
                    var message_to_send = Reply(original_message, from, false,RichTextBoxOutput.Text);
                if (message_to_send == null)
                {
                    return;
                }
                try
                {
                    smtpClient.Send(message_to_send);
                }
                catch
                {
                    MessageBox.Show("Mail failed to be sent");
                    return;
                }
                MessageBox.Show("Mail sent");
                    return;
            }
            var message = new MimeMessage();
            if(to == null)
            {
                to = new MailboxAddress("",TextBoxTo.Text);
            }

            TextPart text = new TextPart("plain") // plain text
            {
                Text = RichTextBoxOutput.Text
            };

            MimePart attachment = null;
            if (CheckBoxAttachment.Checked)
            {
                try
                {
                    attachment = new MimePart("image", "gif")
                    {

                        Content = new MimeContent(File.OpenRead(AttachPath), ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(AttachPath)
                    };
                }
                catch
                {
                    MessageBox.Show("Attachment inaccessible");
                    return;
                }

            }

            var multipart = new Multipart("mixed");
            multipart.Add(text);
            if (CheckBoxAttachment.Checked)
            {
                multipart.Add(attachment);
            }

            message.From.Add(from);
            message.To.Add(to);
            message.Subject = TextBoxSubject.Text;
            message.Body = multipart; 

            try
            {
                smtpClient.Send(message);
            }
            catch
            {
                MessageBox.Show("Mail failed to be sent");
                return;
            }
            MessageBox.Show("Mail sent");
        }

        private MimeMessage Forward(MimeMessage original, InternetAddress from, InternetAddress to, string message_text)
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

            // create an image attachment
                MimePart attachment = null;
            if(CheckBoxAttachment.Checked)
            {
                try
                {
                    attachment = new MimePart("image", "gif")
                    {

                        Content = new MimeContent(File.OpenRead(AttachPath), ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(AttachPath)
                    };
                }
                catch
                {
                    MessageBox.Show("Attachment inaccessible");
                     return null;
                }

            }

            // create a multipart/mixed container for the text body and the forwarded message
            var multipart = new Multipart("mixed");
            multipart.Add(textPart);
            multipart.Add(rfc822);
            if(CheckBoxAttachment.Checked)
            {
                multipart.Add(attachment);
            }

            // set the multipart as the body of the message
            message.Body = multipart;

            return message;
        }


        private MimeMessage Reply(MimeMessage message, InternetAddress from, bool replyToAll, string content_to_send)
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
            StringWriter quoted = new StringWriter();
            // Add the additional content
            quoted.WriteLine(content_to_send);
            quoted.WriteLine(); // Add an empty line before appending the qouted content
            
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


                TextPart textPart = new TextPart("plain")
                {
                    Text = quoted.ToString()
                };

                var multipart = new Multipart("mixed");
                multipart.Add(textPart);
                if(CheckBoxAttachment.Checked)
                {
                    try
                    {
                        MimePart attachment = new MimePart("image", "gif")
                        {
                            Content = new MimeContent(File.OpenRead(AttachPath), ContentEncoding.Default),
                            ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                            ContentTransferEncoding = ContentEncoding.Base64,
                            FileName = Path.GetFileName(AttachPath)
                        };
                        multipart.Add(attachment);
                    }
                    catch
                    {
                        MessageBox.Show("Attachment inaccessible");
                        return null;
                    }
                }
            
            reply.Body = multipart;

            return reply;
        }

        private void CheckBoxAttachment_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxAttachment.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|gif files (*.gif)|*.gif";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path 
                    AttachPath = openFileDialog.FileName;
                    CheckBoxAttachment.Checked = true;
                }
                else
                {
                    CheckBoxAttachment.Checked = false;
                }

            }
        }
    }
}
