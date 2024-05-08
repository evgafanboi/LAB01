using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using System.Net.Sockets;

namespace LAB03
{
    public partial class BAI05Client : Form
    {
        public BAI05Client()
        {
            InitializeComponent();
        }

        TcpClient client;
        NetworkStream ns;
        bool LoggedIn = false;
        bool Switch = false;

        private async void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length > 0)
            {
                //connect to server
                client = new TcpClient("localhost", 8080);
                ns = client.GetStream();

                SendRequest(ns, UsernameTextBox.Text);
            }
            await Listen();

            if (LoggedIn)
            {
                Loginbtn.Enabled = false;
                Logoutbtn.Enabled = true;
                Randombtn.Enabled = true;
                UsernameTextBox.ReadOnly = true;
                Editbtn.Enabled = true;
            }
            else
                UsernameTextBox.Text = string.Empty;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (client.Connected)
                SendRequest(ns, "disconnect " + UsernameTextBox.Text);
            Close();
        }

        public void SendRequest(NetworkStream ns, string cmd)
        {
            byte[] requestData = Encoding.ASCII.GetBytes(cmd);
            ns.Write(requestData, 0, requestData.Length);
            Array.Clear(requestData, 0, requestData.Length);
        }

        private void BAI05Client_Load(object sender, EventArgs e)
        {
            //reserved...
        }

        private async Task Listen()
        {
            ns = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            while (true)
            {
                bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (message.StartsWith("Hello"))
                    {
                        MessageBox.Show("Server: " + message);
                        LoggedIn = true;
                    }
                    else if (message.StartsWith("Who"))
                    {
                        MessageBox.Show("Server: " + message);
                    }
                    else if (message.StartsWith("Somebody"))
                    {
                        MessageBox.Show("Somebody is using your name! Contact 22521115@gm.uit.edu.vn to resolve this issue!\n");
                    }
                    else//neu khong phai xac nhan dang nhap thi se la ten mon an
                    {
                        FoodName.Text = message; 
                    }
                    Array.Clear(buffer, 0, bytesRead);
                    return;
                }
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            SendRequest(ns, "disconnect " + UsernameTextBox.Text);
            Logoutbtn.Enabled = false;
            Loginbtn.Enabled = true;
            Randombtn.Enabled = false;
            Editbtn.Enabled = false;
            UsernameTextBox.ReadOnly = false;
        }

        private async void Randombtn_Click(object sender, EventArgs e)
        {
            if (Switch)
                SendRequest(ns, "randomizeSelf " + UsernameTextBox.Text);
            else
                SendRequest(ns, "randomize " + UsernameTextBox.Text);

            await Listen(); //nghe lan dau -> ten mon an
            await GetImage(); //nghe lan hai -> hinh anh
        }

        private async Task GetImage()
        {
            ns = client.GetStream();
            byte[] buffer = new byte[2000000];
            int bytesRead;
            bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);

            using (MemoryStream ms = new MemoryStream(buffer))  //gan hinh anh vao picture box
            {
                ms.Seek(0, SeekOrigin.Begin);
                Image img = Image.FromStream(ms);
                PictureBox.Image = new Bitmap(img);
            }
        }

        private async void Viewbtn_Click(object sender, EventArgs e)
        {
            SendRequest(ns, "view " + UsernameTextBox.Text);
            string[] Community;
            string[] Personal;
            Community = await Untangler();
            Personal = await Untangler();
            BAI05View view = new BAI05View(Community, Personal);
            view.Show();
        }

        private async Task<string[]> Untangler()
        {
            string[] Untangled = new string[0];
            ns = client.GetStream();
            byte[] buffer = new byte[10000];
            int bytesRead;
            bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
            string plain = Encoding.ASCII.GetString(buffer);
            Untangled = plain.Split('+');
            return Untangled;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Switch)
                Switch = true;
            else
                Switch = false;
        }

        private async void Editbtn_Click(object sender, EventArgs e)
        {
            BAI05Input input = new BAI05Input();
            if (input.ShowDialog() == DialogResult.OK)
            {
                SendRequest(ns, "add " + UsernameTextBox.Text);
                //Gui Id mon an
                byte[] requestData = Encoding.ASCII.GetBytes(input.IdMonAn);
                await ns.WriteAsync(requestData, 0, requestData.Length);
                Array.Clear(requestData, 0, requestData.Length);
                //Gui ten mon an
                requestData = Encoding.ASCII.GetBytes(input.Ten);
                await ns.WriteAsync(requestData, 0, requestData.Length);
                Array.Clear(requestData, 0, requestData.Length);
                //Gui anh
                await ns.WriteAsync(input.imageData, 0, input.imageData.Length);
                input.Close();
            }
        }
    }

}
