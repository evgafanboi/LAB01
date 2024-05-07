using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LAB03
{
    public partial class BAI06Server : Form
    {
        public BAI06Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        IPEndPoint ipep;
        Socket server;
        List<Socket> client_list = new List<Socket>();

        private void ButtonListen_Click(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Any, 9090);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Bind(ipep);
            }
            catch
            {
                MessageBox.Show("Port 9090 is not available");
                return;
            }
            
            
                    Thread Listen_Thread = new Thread(() =>{    

                        try
                        {
                            while (true)
                            {
                                //listen to client
                                server.Listen(100);
                                Socket client = server.Accept();
                                //add client to list
                                client_list.Add(client);
                                try
                                {
                                    Thread Receive_Thread = new Thread(Receive);
                                    Receive_Thread.IsBackground = true;
                                    Receive_Thread.Start(client);
                                }
                                catch
                                {
                                    return;
                                }
                            }
                        }

                        catch
                        {
                            ipep = new IPEndPoint(IPAddress.Any, 9090);
                            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        }

                    });
                    Listen_Thread.IsBackground = true;
                    Listen_Thread.Start();
        }


        

        private void Send(Message_ _message)
        {
            if(_message._content == "")
                return;

            // broadcast message if receiver is *
            if(_message._receiver == "*")
            {
                foreach(Socket client in client_list)
                {
                    //Send(_message, client);
                    byte[] sendbytes = Serialize(_message);
                    client.Send(sendbytes);
                }
            }
            // find receiver in client list
            else
            {
                foreach(Socket client in client_list)
                {
                    //if(client.RemoteEndPoint.ToString() == _message._receiver)
                    //{
                    //    //Send(_message, client);
                    //    return;
                    //}
                }
            }
            
        }

        private void Receive(object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                while(true)
                {
                    byte[] receivebytes = new byte[1024 * 5000];
                    //check bytes received ammount first
                    if(client.Receive(receivebytes) == 0)
                    {
                        continue;
                    }

                    Message_ _message = (Message_)Desserialize(receivebytes);

                    //add message to listbox
                    ListViewItem item = new ListViewItem();
                    item.Text = "[ " + _message._sender + " ]";
                    item.SubItems.Add(_message._content);
                    ListViewOutput.Items.Add(item);

                    Send(_message);
                }
            }

            catch
            {
                //remove cliet from list
                client_list.Remove(client);
                return;
            }
            //handle case when receive a file
        }


        object Desserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
    }
}
