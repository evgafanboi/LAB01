using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI01 : Form
    {
        public BAI01()
        {
            InitializeComponent();

            richTextBox1.ReadOnly = true;
        }
        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "Dang xu ly vui long cho..";
                richTextBox1.Text = getHTML(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("KIỂM TRA LẠI ĐƯỜNG LINK!!");
            }
        }
    }
}
