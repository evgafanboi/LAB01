using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class BAI03Client : Form
    {
        //cac doi tuong se duoc su dung
        TcpClient tcpClient;
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint ipEndPoint;
        NetworkStream ns;
        Byte[] data;
        public BAI03Client()
        {
            InitializeComponent();
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);
                ns = tcpClient.GetStream();
                Sendbtn.Enabled = true;
                Disconnectbtn.Enabled = true;
                Connectbtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong happened! Try again...");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Disconnectbtn_Click(object sender, EventArgs e)
        {
            data = System.Text.Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
            Connectbtn.Enabled = true;
            Disconnectbtn.Enabled = false;
            Sendbtn.Enabled = false;
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            data = System.Text.Encoding.ASCII.GetBytes(InputBox.Text);
            ns.Write(data, 0, data.Length);
        }
    }
}
