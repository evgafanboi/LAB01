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
using System.Runtime.Remoting.Messaging;

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

                                while (clientName == "")
                                {
                                    try
                                    {
                                        byte[] nameBytes = new byte[1024];
                                        int nameBytesReceived = client.Receive(nameBytes);
                                        clientName = Encoding.UTF8.GetString(nameBytes, 0, nameBytesReceived);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Client name is not available");
                                    }
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

            ////create a thread to poll client connection status
            //Thread PollClient_Thread = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        foreach (KeyValuePair<string, Socket> client in client_table)
            //        {
            //            if (!SocketConnected(client.Value))
            //            {
            //                client_table.Remove(client.Key);
            //            }
            //        }
            //        Thread.Sleep(500);
            //    }
            //});
            //PollClient_Thread.IsBackground = true;
            //PollClient_Thread.Start();
        }


        

        private void Send(object obj)
        {
            if(obj is Message_)
            {
                Message_ _message = (Message_)obj;
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
            else
            {
                FileMessage fileMessage = (FileMessage)obj;
                if(fileMessage.receiver == "")
                    return;
                if(fileMessage.receiver == "*")
                {
                    foreach (KeyValuePair<string, Socket> client in client_table)
                    {
                        //skip sender
                        if(client.Key == fileMessage.sender)
                            continue;
                        byte[] sendbytes = Serialize(fileMessage);
                        client.Value.Send(sendbytes);
                    }
                }
                else
                {
                    foreach(KeyValuePair<string, Socket> client in client_table)
                    {
                        if (client.Key == fileMessage.receiver)
                        {
                            byte[] sendbytes = Serialize(fileMessage);
                            client.Value.Send(sendbytes);
                            return;
                        }
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

                    //handle case when receive a file
                    // 
                    //
                    ///
                    //
                    object recv_obj = (object)Desserialize(receivebytes);
                    if(recv_obj is Message_)
                    {
                        Message_ _message = (Message_)recv_obj;

                        //add message to listbox
                        ListViewItem item = new ListViewItem();
                        item.Text = "[ " + _message._sender + " -> " + _message._receiver + "]";
                        item.SubItems.Add(_message._content);
                        ListViewOutput.Items.Add(item);

                        Send(_message);
                    }
                    else
                    {
                           //handle case when receive a file
                           FileMessage fileMessage = (FileMessage)recv_obj;
                           //save file to current folder/Server/[file]
                           //get current path
                           string currentPath = Directory.GetCurrentDirectory();
                           currentPath = currentPath + "\\Server";
                           //create folder if not exist
                           if (!Directory.Exists(currentPath))
                           {
                                Directory.CreateDirectory(currentPath);
                           }
                           currentPath = currentPath + "\\" + fileMessage.file_name;
                            // if file exist, add random number to file name
                            while (File.Exists(currentPath))
                            {
                                Random rand = new Random();
                                currentPath = currentPath + rand.Next(1000);
                            }

                           //write file
                           File.WriteAllBytes(currentPath, fileMessage.file_bytes);

                            //send file to receiver
                            Send(fileMessage);

                            //add to listbox
                            ListViewItem item = new ListViewItem();
                            item.Text = "[ " + fileMessage.sender + " -> " + fileMessage.receiver + "]";


                            //get file name from savePath
                            item.SubItems.Add("File: " + Path.GetFileName(currentPath) + " has been received");
                            ListViewOutput.Items.Add(item);
                    }

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

        bool SocketConnected(Socket s)
        {
            //poll the socket to check connection status, wait 1000ms
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            // if there is no data and the socket is not receiving data
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
    }
}
