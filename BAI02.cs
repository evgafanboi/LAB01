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
        Socket listenerSocket;
        Socket client_socket;
        bool Stopconnection = false;
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
        private async void  StartUnsafeThread()
        {
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int bytes_received = 0;
            byte[] receive_bytes = new byte[1];
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ip);
            listenerSocket.Listen(-1); 
            richTextBox1.Text = "Waiting for connection on port 8080...\n";
            client_socket = listenerSocket.Accept();
            richTextBox1.Text += "Connected to " + client_socket.RemoteEndPoint.ToString() + "\n";
            Stopconnection = false;
            while (client_socket.Connected)
            {
                    string receive_string = "";
                    bytes_received = client_socket.Receive(receive_bytes);
                    receive_string = Encoding.ASCII.GetString(receive_bytes, 0, bytes_received);
                    richTextBox1.Text = richTextBox1.Text + receive_string;
                if (Stopconnection)
                    break;
            }
                listenerSocket.Close();
                client_socket.Close();
                richTextBox1.Text = "";
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Stopconnection = true;
            ButtonReset.Enabled = false;
            ButtonListen.Enabled = true;
        }
    }
}
