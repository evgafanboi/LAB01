using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.Mime.MediaTypeNames;

namespace LAB03
{
    public partial class BAI05Server : Form
    {
        public BAI05Server()
        {
            InitializeComponent();
        }

        private static string databasePath = "BAI05.sqlite3";
        private string connectionString = $"Data Source = {databasePath}; Version=3;";
        private TcpListener server;
        private static List<TcpClient> clients = new List<TcpClient>();

        private void BAI05Server_Load(object sender, EventArgs e)
        {
            //Reserved....
        }

        private async void Listenbtn_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            server.Start();
            StatusBox.Text = "Server started. Pending for connections...\n";

            Resetbtn.Enabled = true;
            Listenbtn.Enabled = false;
            try
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    _ = HostClient(client);
                }
            }
            catch (Exception ex)
            {
                //do nothing...
            }
        }

        private async Task HostClient(TcpClient client)
        {
            StatusBox.Text += "A new client connected to the server!\n";    //-------Throw notification: new connection---------
            string username = "unknown";
            try
            {
                NetworkStream ns = client.GetStream();
                byte[] buffer = new byte[2048];
                int bytesRead;

                bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
                username = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Array.Clear(buffer, 0, bytesRead);
                StatusBox.Text += $"{username} connecting... Authenticating user....\n";
                if (AuthenticateUser(username)==0) {             //--------------Neu user khong ton tai trong db----------------

                    byte[] response = Encoding.ASCII.GetBytes("Who are you?\n");
                    await ns.WriteAsync(response, 0, response.Length);
                    StatusBox.Text += $"{username} is sus! Disconnecting this user...\n";
                    return;
                }
                else if (AuthenticateUser(username) == 2)
                {
                    byte[] response = Encoding.ASCII.GetBytes("Somebody with the same name is logging in\n");
                    await ns.WriteAsync(response, 0, response.Length);
                    StatusBox.Text += $"{username} is already here! Disconnecting this user...\n";
                    return;
                }
                else
                {
                    byte[] response = Encoding.ASCII.GetBytes($"Hello, {username}\n");
                    await ns.WriteAsync(response, 0, response.Length);
                    UserList.Items.Add(username);
                    StatusBox.Text += $"{username} has successfully connected!\n";
                }
                Array.Clear(buffer, 0, bytesRead);
                //---------------------process client requests---------------------------
                while ((bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string request = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    string[] segments = request.Split(' ');
                    StatusBox.Text += $"Receiving {segments[0]} request from user {username}...\n";
                    if (segments.Length >= 1) {
                        string command = segments[0].Trim();
                        command = command.ToLower();
                        switch (command)
                        {
                            case "randomize":
                                RandomMonAn(ns);
                                break;
                            case "randomizeself":
                                RandomMonAnSelf(ns, username);
                                break;
                            case "disconnect":
                                return;
                            case "add":
                                AddMonAn(ns, username);
                                break;
                            case "view":
                                ViewMonAn(ns, username);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }

            finally
            {
                StatusBox.Text += $"User named {username} leaving...\n";
                UserList.Items.Remove(username);
                client.Close();
            }
        }

        private int AuthenticateUser(string username)
        {
            if (UserList.Items.Contains(username)){ //neu dang co user nay thi khong cho dang nhap nua
                return 2;
            }
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = " SELECT COUNT(*) FROM NguoiDung WHERE HoVaTen = @username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count;
                }
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (clients.Count > 0)
            {
                foreach (TcpClient client in clients)
                { client.Close(); }
                server.Stop();
                Listenbtn.Enabled = true;
                Resetbtn.Enabled = false;
                StatusBox.Text = "Server has reset! Either start listening or exit...\n";
            }
            else
            {
                StatusBox.Text = "Cant reset when nothing really happened...Just wait for a connection or exit\n";
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (!Listenbtn.Enabled)
                Resetbtn.PerformClick();
            Close();
        }
        //--------------------------Random mon an--------------------------------
        private async void RandomMonAn(NetworkStream ns)
        {
            string databasePath = "BAI05.sqlite3";
            string connectionString = $"Data Source = {databasePath}; Version=3;";
            List<string> dsMonAn = new List<string>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TenMonAn FROM MonAn";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())   //nap tat ca cac mon an tren query result vao danh sach mon an
                        {
                            string data = reader.GetString(0); // lay ten cac mon an o cot [0]
                            dsMonAn.Add(data);
                        }
                    }
                }
            }

            Random random = new Random();
            string MonAn = dsMonAn[random.Next(0, dsMonAn.Count)];  //random vi tri danh sach mon an va gan ten co vi tri tuong ung vao MonAn
            byte[] HinhMonAn;    //mang byte chua hinh anh cua 
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT HinhAnh FROM MonAn WHERE TenMonAn = '{MonAn}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())   //load hinh anh vao hinh mon an duoi dang mang byte
                    {
                        const int buffersize = 4000000;
                        byte[] buffer = new byte[buffersize];
                        long bytesRead;
                        long dataIndex = 0;
                        long bufferSizeIndex = 0;
                        using (MemoryStream stream = new MemoryStream())
                        {
                            while (reader.Read())
                            {
                                bytesRead = reader.GetBytes(0, dataIndex, buffer, 0, buffersize);
                                if (bytesRead <= 0) break; //No more data to read, exit loop
                                stream.Write(buffer, 0, (int)bytesRead);
                                dataIndex += bytesRead;
                                bufferSizeIndex += buffersize;
                            }
                            HinhMonAn = stream.ToArray();
                        }
                    }
                }
            }
            byte[] response = Encoding.ASCII.GetBytes(MonAn);
            await ns.WriteAsync(response, 0, response.Length);//---------Tra ten mon an----------

            await ns.WriteAsync(HinhMonAn, 0, HinhMonAn.Length);//----------Tra hinh anh mon an-----------
        }

        private async void RandomMonAnSelf(NetworkStream ns, string username)
        {
            string databasePath = "BAI05.sqlite3";
            string connectionString = $"Data Source = {databasePath}; Version=3;";
            List<string> dsMonAn = new List<string>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT TenMonAn FROM MonAn, NguoiDung WHERE MonAn.IDNCC = NguoiDung.IDNCC AND HoVaTen = '{username}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())   //nap tat ca cac mon an tren query result vao danh sach mon an
                        {
                            string data = reader.GetString(0); // lay ten cac mon an o cot [0]
                            dsMonAn.Add(data);
                        }
                    }
                }
            }

            Random random = new Random();
            string MonAn = dsMonAn[random.Next(0, dsMonAn.Count)];  //random vi tri danh sach mon an va gan ten co vi tri tuong ung vao MonAn
            byte[] HinhMonAn;    //mang byte chua hinh anh cua 
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT HinhAnh FROM MonAn WHERE TenMonAn = '{MonAn}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())   //load hinh anh vao hinh mon an duoi dang mang byte
                    {
                        const int buffersize = 4000000;
                        byte[] buffer = new byte[buffersize];
                        long bytesRead;
                        long dataIndex = 0;
                        long bufferSizeIndex = 0;
                        using (MemoryStream stream = new MemoryStream())
                        {
                            while (reader.Read())
                            {
                                bytesRead = reader.GetBytes(0, dataIndex, buffer, 0, buffersize);
                                if (bytesRead <= 0) break; //No more data to read, exit loop
                                stream.Write(buffer, 0, (int)bytesRead);
                                dataIndex += bytesRead;
                                bufferSizeIndex += buffersize;
                            }
                            HinhMonAn = stream.ToArray();
                        }
                    }
                }
            }
            byte[] response = Encoding.ASCII.GetBytes(MonAn);
            await ns.WriteAsync(response, 0, response.Length);//---------Tra ten mon an----------

            await ns.WriteAsync(HinhMonAn, 0, HinhMonAn.Length);//----------Tra hinh anh mon an-----------
        }
        private async void ViewMonAn(NetworkStream ns, string username)
        {
            List<string> dsMonAn = new List<string>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TenMonAn FROM MonAn";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())   //nap tat ca cac mon an tren query result vao danh sach mon an
                        {
                            string data = reader.GetString(0); // lay ten cac mon an o cot [0]
                            dsMonAn.Add(data);
                        }
                    }
                }
            }
            byte[] dataMonAn = new byte[10000];
            string stringMonAn = "";
            foreach (string MonAn in dsMonAn)
            {
                stringMonAn += MonAn + "+"; //lay '+' lam delimiter
            }
            dataMonAn = Encoding.UTF8.GetBytes(stringMonAn);
            await ns.WriteAsync(dataMonAn, 0, dataMonAn.Length);
            //Lan gui thu 2: gui cac mon an cua user
            dsMonAn.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT TenMonAn FROM MonAn, NguoiDung WHERE MonAn.IDNCC = NguoiDung.IDNCC AND HoVaTen = '{username}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())   //nap tat ca cac mon an tren query result vao danh sach mon an
                        {
                            string data = reader.GetString(0); // lay ten cac mon an o cot [0]
                            dsMonAn.Add(data);
                        }
                    }
                }
            }
            Array.Clear(dataMonAn, 0, dataMonAn.Length);
            stringMonAn = "";
            foreach (string MonAn in dsMonAn)
            {
                stringMonAn += MonAn + "+"; //lay '+' lam delimiter
            }
            dataMonAn = Encoding.UTF8.GetBytes(stringMonAn);
            await ns.WriteAsync(dataMonAn, 0, dataMonAn.Length);

        }

        private async Task AddMonAn(NetworkStream ns,  string username)
        {
            string IdMonAn;
            string TenMonAn;
            byte[] anh = new byte[2000000];
            byte[] buffer = new byte[30];
            int bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
            IdMonAn = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Array.Clear(buffer, 0, bytesRead);
            bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
            TenMonAn = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Array.Clear (buffer, 0, bytesRead);
            bytesRead = await ns.ReadAsync(anh, 0, anh.Length);
            string query = "INSERT INTO MonAn VALUES (@ID, @Ten, @Anh, @NguoiThem)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", IdMonAn);
                command.Parameters.AddWithValue("@Ten", TenMonAn);
                command.Parameters.AddWithValue("@Anh", anh);
                command.Parameters.AddWithValue("@NguoiThem", username);
                command.ExecuteNonQuery();
            }

            StatusBox.Text += $"A new dish added by {username}\n";
        }
    }
}
