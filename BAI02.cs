using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace LAB04
{
    public partial class BAI02 : Form
    {
        public BAI02()
        {
            InitializeComponent();
        }
        private WebClient myClient;
        private Stream TemplateStream;
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            if (CheckRequirement(URLBox.Text, DirectoryBox.Text))   //check xem cac thong tin da dien day du va hop le
            {
                using (myClient = new WebClient())
                {
                    TemplateStream = myClient.OpenRead(URLBox.Text);
                    StreamReader sr = new StreamReader(TemplateStream);
                    OutputBox.Text = sr.ReadToEnd();
                }
            }
        }

        private bool CheckRequirement(string url, string dir)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out var result))
            {
                MessageBox.Show("URL không hợp lệ!", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            Browsebtn.PerformClick();
            myClient.DownloadFile(URLBox.Text, DirectoryBox.Text);
            MessageBox.Show("File đã được lưu!", "Thành công", MessageBoxButtons.OK);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
