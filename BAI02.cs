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
        private void  StartUnsafeThread()
        {
            try
            {
                listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ip);
                listenerSocket.Listen(-1); 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                int bytes_received = 0;
                byte[] receive_bytes = new byte[1];
            richTextBox1.Text = "Waiting for connection on port 8080...\n";
            client_socket = listenerSocket.Accept();
            richTextBox1.Text += "Connected to " + client_socket.RemoteEndPoint.ToString() + "\n";
            Stopconnection = false;

            while (SocketConnected(client_socket))
            {
                try
                {
                    string receive_string = "";
                    bytes_received = client_socket.Receive(receive_bytes);
                    receive_string = Encoding.ASCII.GetString(receive_bytes, 0, bytes_received);
                    richTextBox1.Text = richTextBox1.Text + receive_string;
                }

                catch
                {
                        break;
                }
                    if (Stopconnection)
                    break;
            }
                listenerSocket.Close();
                richTextBox1.Text = "";
                richTextBox1.Text += "Connection closed\n";
        }


        bool SocketConnected(Socket s)
        {
            //poll the socket to check connection status, wait 1000ms
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Stopconnection = true;
            client_socket.Close();
            ButtonReset.Enabled = false;
            ButtonListen.Enabled = true;
        }
    }
}
