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
        }

        IPEndPoint ipep;
        Socket client;

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Server is not available");
                return;
            }

            Thread Listenning_Thread = new Thread(Receive);
            Listenning_Thread.IsBackground = true;
            Listenning_Thread.Start();

            //enable button send and combobox
            ButtonSend.Enabled = true;
            ButtonSendFile.Enabled = true;
            ButtonConnect.Enabled = false;
            ComboBoxReceiver.Enabled = true;
            TextBoxMessage.Enabled = true;
            TextBoxName.Enabled = true;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            //ignore empty message
            if (TextBoxMessage.Text == "")
                return;

            Message_ message_send = new Message_();
            message_send._sender = TextBoxName.Text;
            message_send._receiver = ComboBoxReceiver.Text;
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
                    // set buffer size
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    Message_ message_recv = (Message_)Desserialize(data);
                    // after that add to listbox //////////////////////////////////////////////////////////////////////////////////
                    //ListViewItem item = new ListViewItem();
                    //item.Text = "[ " + message_recv._sender + " ]";
                    //item.SubItems.Add(message_recv._content);
                    //ListViewOutput.Items.Add(item);
                    //dont need to anymore because server will send back to client
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

        }
    }
}
