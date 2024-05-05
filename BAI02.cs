using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace LAB03
{
    public partial class BAI02 : Form
    {
        Socket listenerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        public BAI02()
        {
            InitializeComponent();
        }

        private void ButtonListen_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            // fix InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            ButtonListen.Enabled = false;
            ButtonReset.Enabled = true;
            serverThread.Start();
        }
        private void StartUnsafeThread()
        {
            int bytes_received = 0;
            byte[] receive_bytes = new byte[1];
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ip);
            listenerSocket.Listen(-1); // no limit on the number of connections
            Socket client_socket = listenerSocket.Accept();

            richTextBox1.Text = "Connected to " + client_socket.RemoteEndPoint.ToString() + "\n";
            while (client_socket.Connected)
            {
                //clear RichTextBox
                string receive_string = "";
                do
                {
                    bytes_received = client_socket.Receive(receive_bytes);
                    receive_string = Encoding.ASCII.GetString(receive_bytes, 0, bytes_received);
                    richTextBox1.Text = richTextBox1.Text + receive_string;



                }
                while (receive_string[receive_string.Length - 1] != '\n');

                    richTextBox1.Text = richTextBox1.Text + receive_string;
                //while (true) ;
                
                listenerSocket.Close();

            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            //clear RichTextBox
            richTextBox1.Clear();
            listenerSocket.Close();
            //halt the thread


        }
    }
}
