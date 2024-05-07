using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class BAI03Server : Form
    {
        Socket clientSocket;
        Socket listenerSocket;
        NetworkStream ns;
        public BAI03Server()
        {
            InitializeComponent();
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            OutputBox.Text += "Server started!\n";
            clientSocket = listenerSocket.Accept();
            OutputBox.Text += "Connection accepted from " + clientSocket.RemoteEndPoint.ToString() + "\n";
            ns = new NetworkStream(clientSocket);

            //-----------Nhan du lieu-------------

            while (clientSocket.Connected)
            {
                StringBuilder receiveStringBuilder = new StringBuilder();
                while (true)
                {
                    bytesReceived = ns.Read(recv, 0, recv.Length);

                    string receivedData = Encoding.ASCII.GetString(recv);
                    receiveStringBuilder.Append(receivedData);
                    OutputBox.Text = receiveStringBuilder.ToString();
                    if (bytesReceived == 0)
                        break;
                    if (receiveStringBuilder.ToString().EndsWith("quit\n"))
                    {
                        Resetbtn.PerformClick();
                        break;
                    }
                }
            }
            //done
            listenerSocket.Close();
        }

        private void Listenbtn_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Listenbtn.Enabled = false;
            Resetbtn.Enabled = true;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            Resetbtn.Enabled = false;
            Listenbtn.Enabled = true;
            OutputBox.Text = "Server has reset and is pending for new connection...\n";
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
