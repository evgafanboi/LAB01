﻿using System;
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
    public partial class BAI01_SERVER : Form
    {
        public BAI01_SERVER()
        {
            InitializeComponent();
        }
        private UdpClient udpClient;
        private bool isListening;

        private void ServerThread()
        {
            //udpClient = new UdpClient(int.Parse(textBox2.Text));
            while (isListening)
            {
                try
                {
                    IPEndPoint RemoteIpEndpoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receivedBytes = udpClient.Receive(ref RemoteIpEndpoint);
                    string returnData = Encoding.UTF8.GetString(receivedBytes);
                    string message = RemoteIpEndpoint.Address.ToString() + ": " + returnData.ToString() + "\n";

                    if (richTextBox1.InvokeRequired)
                    {
                        richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text += message; }));
                    }
                    else
                    {
                        richTextBox1.Text += message;
                    }
                }
                catch (SocketException ex)
                {
                    // Ignore socket exceptions if the server is stopping
                    if (isListening && ex.SocketErrorCode != SocketError.Interrupted)
                    {
                        throw;
                    }
                }
            }
        }

        private void Form1_ServerThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            isListening = false;
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                isListening = true;
                Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
                udpClient = new UdpClient(int.Parse(textBox2.Text));
                thdUDPServer.IsBackground = true;
                thdUDPServer.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ Port!");
            }
            catch (SocketException)
            {

            }
        }
    }
}