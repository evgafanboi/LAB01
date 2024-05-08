using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LAB03
{
    public partial class BAI06Client : Form
    {
        public BAI06Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //set default value for combobox
            ComboBoxReceiver.Text = "*";

        }

        IPEndPoint ipep;
        Socket client;
        List<string> sender_list;
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (TextBoxName.Text == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            }

            try
            {
                client.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Server is not available");
                return;
            }
            //send name to server right after connecting
            string clientName = TextBoxName.Text;
            byte[] nameBytes = Encoding.UTF8.GetBytes(clientName);
            client.Send(nameBytes);

            Thread Listenning_Thread = new Thread(Receive);
            Listenning_Thread.IsBackground = true;
            Listenning_Thread.Start();



            //enable button send and combobox
            ButtonSend.Enabled = true;
            ButtonSendFile.Enabled = true;
            ButtonConnect.Enabled = false;
            ButtonReset.Enabled = true;
            ComboBoxReceiver.Enabled = true;
            TextBoxName.Enabled = false;
            TextBoxMessage.Enabled = true;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            //ignore empty message
            if (TextBoxMessage.Text == "")
                return;
            if(!SocketConnected(client))
            {
                MessageBox.Show("Server has been disconnected");
                ButtonReset_Click(null, null);
                return;
            }

            Message_ message_send = new Message_();
            message_send._sender = TextBoxName.Text;
            message_send._receiver = ComboBoxReceiver.Text;
            //receiver is IPendPoint
            message_send._content = TextBoxMessage.Text;

            client.Send(Serialize(message_send));

            //clear message box
            TextBoxMessage.Text = "";
            // add to listbox
            ListViewItem item = new ListViewItem();
            item.Text = "[ " + message_send._sender + " ]";
            item.SubItems.Add(message_send._content);
            ListViewOutput.Items.Add(item);
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        void Receive()
        {
            try
            {
                while(true)
                {
                    //check if socket is connected
                    
                    if (!SocketConnected(client))
                    {
                        MessageBox.Show("Server has been disconnected");
                        //call reset button
                        ButtonReset_Click(null, null);
                        return;
                    }

                    // set buffer size
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    object obj = Desserialize(data);
                    if (obj is Message_)
                    {
                        Message_ message_recv = (Message_)obj;
                        // after that add to listbox //////////////////////////////////////////////////////////////////////////////////
                        ListViewItem item = new ListViewItem();
                        item.Text = "[ " + message_recv._sender + " ]";
                        item.SubItems.Add(message_recv._content);
                        ListViewOutput.Items.Add(item);
                    }
                    else if (obj is List<string>)
                    {
                        List<string>sender_list_temp = (List<string>)obj;
                        sender_list = sender_list_temp;
                        
                    }
                    else if (obj is FileMessage)
                    {
                        FileMessage fileMessage = (FileMessage)obj;
                        //get current directory
                        string currentDirectory = Directory.GetCurrentDirectory();
                        //save file to [currentpath]\[clientName]\[fileName]
                        //create directory if not exist
                        if (!Directory.Exists(currentDirectory + "\\" + TextBoxName.Text))
                        {
                            Directory.CreateDirectory(currentDirectory + "\\" + TextBoxName.Text);
                        }
                        string savePath = currentDirectory + "\\" + TextBoxName.Text + "\\" + fileMessage.file_name;
                        
                        //check if file already exists
                        while (File.Exists(savePath))
                        {
                            Random rand = new Random();
                            savePath = savePath + rand.Next(1000);
                        }

                        //write file
                        File.WriteAllBytes(savePath, fileMessage.file_bytes);

                        //add to listbox
                        ListViewItem item = new ListViewItem();
                        item.Text = "[ " + fileMessage.sender + " ]";
                        
                        //get file name from savePath
                        item.SubItems.Add("File: " + Path.GetFileName(savePath) + " has been received");
                        ListViewOutput.Items.Add(item);
                        
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Server has been disconnected");
                client.Close();
            }

        }

        object Desserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pick a file
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.Title = "Select a 5000KB file to send";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // check if file is larger than 5KB
            if (new FileInfo(fileDialog.FileName).Length > 1024 * 5000)
            {
                        MessageBox.Show("File is larger than 5KB");
                        return;
            }

                if(fileDialog.CheckFileExists)
                {
                    // add file path to Textbox
                    TextBoxFilePath.Text = fileDialog.FileName;
                    FileStream fileStream = null;
                    try
                    {
                        fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to access file");
                    }

                if(!SocketConnected(client))
                    {
                           MessageBox.Show("Server has been disconnected");
                            ButtonReset_Click(null, null);
                            return;
                    }

                    //read file content into byte array
                    byte[] fileContent = new byte[fileStream.Length];
                    fileStream.Read(fileContent, 0, fileContent.Length);

                    FileMessage fileMessage = new FileMessage();
                    fileMessage.file_bytes = fileContent;
                    fileMessage.receiver = ComboBoxReceiver.Text;
                    fileMessage.sender = TextBoxName.Text;
                    fileMessage.file_name = fileDialog.SafeFileName;

                    //send file to server
                    client.Send(Serialize(fileMessage));
                    
                    //add to listbox
                    ListViewItem item = new ListViewItem();
                    item.Text = "[ " + fileMessage.sender + " ]";
                    item.SubItems.Add("File: " + fileDialog.SafeFileName);
                    ListViewOutput.Items.Add(item);
                }

            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // close connection
            client.Close();
            //disable button send and combobox
            ButtonSend.Enabled = false;
            ButtonSendFile.Enabled = false;
            ButtonConnect.Enabled = true;
            ComboBoxReceiver.Enabled = false;
            TextBoxMessage.Enabled = false;
            TextBoxName.Enabled = true;
            //clear listbox
            ListViewOutput.Items.Clear();
        }

        private void ComboBoxReceiver_Click(object sender, EventArgs e)
        {
            ComboBoxReceiver.Items.Clear();
            ComboBoxReceiver.Items.Add("*");
            if (sender_list == null)
                return;
            foreach (string sender_ in sender_list)
            {
                ComboBoxReceiver.Items.Add(sender_);
            }
            //remove client's own name from combobox
            ComboBoxReceiver.Items.Remove(TextBoxName.Text);
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

        private void BAI06Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            // call reset button
            ButtonReset_Click(null, null);
        }
    }
}
