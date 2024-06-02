using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using Org.BouncyCastle.Asn1.Crmf;

namespace LAB05
{
    public partial class BAI03View : Form
    {
        private readonly MimeMessage message;
        public BAI03View(MimeMessage msg)
        {
            InitializeComponent();
            message = msg;
        }

        private void BAI03View_Load(object sender, EventArgs e)
        {
            Output.Text += "SUBJECT\n";
            Output.Text += message.Subject + "\n\n===============\n\n";
            Output.Text += "CONTENT\n";
            Output.Text += message.TextBody;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
