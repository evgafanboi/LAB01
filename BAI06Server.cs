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
using System.Collections;

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
        //List<Socket> client_list = new List<Socket>();
        //hash table to store client name and socket
        Dictionary<string,Socket> client_table = new Dictionary<string,Socket>();
        //hash table to client socket to client name

        //List<string> client_names = new List<string>();

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
                                //client_list.Add(client);

                                //hash table to store client id and client socket
                                //Hashtable client_table = new Hashtable();
                                //client_table.Add(client.RemoteEndPoint.ToString(), client);
                                string clientName = "";
                                //receive client name
                                try
                                {
                                    byte[] nameBytes = new byte[1024];
                                    int nameBytesReceived = client.Receive(nameBytes);
                                    clientName = Encoding.UTF8.GetString(nameBytes, 0, nameBytesReceived);
                                }

                                catch
                                {

                                }

                                //add name and client to dictionary
                                client_table.Add(clientName, client);
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

                //create a thread to update combobox client list to all clients
                Thread UpdateClientList_Thread = new Thread(() =>
                {
                        while (true)
                        {
                                //copy client name to list
                                List<string> client_names = new List<string>();
                                foreach (KeyValuePair<string, Socket> client in client_table)
                                {
                                    client_names.Add(client.Key);
                                }

                                foreach (KeyValuePair<string, Socket> client in client_table)
                                { 
                                    try
                                    {
                                        byte[] sendbytes = Serialize(client_names);
                                        client.Value.Send(sendbytes);
                                    }

                                    catch
                                    {
                                            continue;
                                    }
                                
                                }
                            

                            //update less frequently than receive
                            Thread.Sleep(1000);
                        }
                });
                    UpdateClientList_Thread.IsBackground = true;
                    UpdateClientList_Thread.Start();
        }


        

        private void Send(Message_ _message)
        {
            if(_message._content == "")
                return;

            // broadcast message if receiver is *
            if(_message._receiver == "*")
            {
                foreach (KeyValuePair<string, Socket> client in client_table)
                {
                    //skip sender
                    if(client.Key == _message._sender)
                        continue;
                    byte[] sendbytes = Serialize(_message);
                    client.Value.Send(sendbytes);
                }
            }
            // find receiver in client list
            else
            {
                foreach(KeyValuePair<string, Socket> client in client_table)
                {
                    if (client.Key == _message._receiver)
                    {
                        byte[] sendbytes = Serialize(_message);
                        client.Value.Send(sendbytes);
                        return;
                    }
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
                //remove cliet from list by foreach
                foreach(KeyValuePair<string, Socket> client_ in client_table)
                {
                    if(client_.Value == client)
                    {
                        client_table.Remove(client_.Key);
                        break;
                    }
                }

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
