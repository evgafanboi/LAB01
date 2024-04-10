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
using System.IO;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace BTTH2
{
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }

        private static string databasePath = "..\\BAI06.sqlite";
        private static string connectionString = $"Data Source = {databasePath}; Version=3;";
        public string username;
        static void DBInit()
        {
            SQLiteConnection.CreateFile(databasePath);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //create a couple of tables for foods and consumers...

                string createTables = @"
                    CREATE TABLE NguoiDung(
                    IDNCC TEXT PRIMARY KEY,
                    HoVaTen TEXT,
                    QuyenHan TEXT
                    );

                    CREATE TABLE MonAn(
                    IDMA TEXT PRIMARY KEY,
                    TenMonAn TEXT,
                    HinhAnh BLOB,
                    IDNCC TEXT,
                    FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                    );
                    ";
                //execute query
                using (SQLiteCommand command = new SQLiteCommand(createTables, connection))
                {
                    command.ExecuteNonQuery();
                }

                //nhap lieu
                byte[] bunbo = File.ReadAllBytes("BunBo.jpg");
                byte[] pho = File.ReadAllBytes("PHO.jpg");
                byte[] banhmi = File.ReadAllBytes("BanhMi.jpeg");
                byte[] burrito = File.ReadAllBytes("Burrito.jpg");
                byte[] pizza = File.ReadAllBytes("Pizza.jpg");
                byte[] lasagna = File.ReadAllBytes("Lasagna.jpg");
                byte[] heinz = File.ReadAllBytes("HEINZ.jpg");
                byte[] grass = File.ReadAllBytes("grass.jpg");
                byte[] burger = File.ReadAllBytes("LGBTBurger.png");

                string insertData = @"
                    INSERT INTO MonAn VALUES
                    ('BB', 'Bun bo', @imageBunBo, 'Admin'),
                    ('Ph', 'Pho', @imagePho, 'Admin'),
                    ('Ls', 'Lasagna', @imageLasagna, 'Admin'),
                    ('Br', 'Burrito', @imageBurrito, 'Amigo'),
                    ('Pz', 'Pizza', @imagePizza, 'American'),
                    ('Bg', 'Burger', @imageBurger, 'American'),
                    ('BM', 'Banh mi', @imageBanhmi, 'Admin'),
                    ('Hz', '5000 oz of Heinz ketchup', @imageHeinz, 'Amigo'),
                    ('Gr', 'Grass', @imageGrass, 'Herbivore');

                    INSERT INTO NguoiDung VALUES
                    ('Admin', 'Quan tri vien', 'E'),
                    ('American', 'Your average 300 lbs WHAT-THE-FUCK-IS-A-KILOMETER???!!', 'E'),
                    ('Amigo', 'Etu case Mitu Casa', 'E'),
                    ('Herbivore', 'Dong vat an co', 'E'),
                    ('Woman1', 'Trung binh phu nu', 'V'),
                    ('GirlFriend1', 'Trung binh con gai', 'V'),
                    ('GigaChad', 'Gi cung an', 'V'),
                    ('GenshinImpactPlayer', 'Another 300 lbs MY-WAIFU-IS-FAR-SUPERIOR!!!!', 'V')
                ";

                //execute query
                using (SQLiteCommand command = new SQLiteCommand(insertData, connection))
                {
                    command.Parameters.Add(new SQLiteParameter("@imageBunBo", DbType.Binary) { Value = bunbo });
                    command.Parameters.Add(new SQLiteParameter("@imagePho", DbType.Binary) { Value = pho });
                    command.Parameters.Add(new SQLiteParameter("@imageLasagna", DbType.Binary) { Value = lasagna });
                    command.Parameters.Add(new SQLiteParameter("@imageHeinz", DbType.Binary) { Value = heinz });
                    command.Parameters.Add(new SQLiteParameter("@imageBanhmi", DbType.Binary) { Value = banhmi });
                    command.Parameters.Add(new SQLiteParameter("@imageGrass", DbType.Binary) { Value = grass });
                    command.Parameters.Add(new SQLiteParameter("@imagePizza", DbType.Binary) { Value = pizza });
                    command.Parameters.Add(new SQLiteParameter("@imageBurger", DbType.Binary) { Value = burger });
                    command.Parameters.Add(new SQLiteParameter("@imageBurrito", DbType.Binary) { Value = burrito });
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Khoi tao csdl thanh cong!", "Khong that bai", MessageBoxButtons.OK);
            }
        }

        private void BAI06_Load(object sender, EventArgs e)
        {
            string databasePath = "..\\BAI06.sqlite";

            if (!File.Exists(databasePath)) //neu db chua co san, khoi tao
            {
                DBInit();
            }
        }

        private bool CheckName(string username) //check username xem co ton tai trong db
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = " SELECT COUNT(*) FROM NguoiDung WHERE HoVaTen = @username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool CheckAuthorization(string username) //check username xem co ton tai trong db
        {
            string PowerLevel = "E";  //E = Editor quyen han cao nhat, V = Viewer nguoi dung thong thuong
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = " SELECT COUNT(*) FROM NguoiDung WHERE QuyenHan = @authorization AND HoVaTen = @username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorization", PowerLevel);
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            if (CheckName(username))
            {
                textBox1.ReadOnly = true;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                if (CheckAuthorization(username))
                    button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ten nguoi dung khong ton tai! Lien he your mom de tao tai khoan!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Text = "";
            button3.Enabled= false;
            button4.Enabled= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string databasePath = "..\\BAI06.sqlite";
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
            byte[] HinhMonAn = null;    //mang byte chua hinh anh cua 
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT HinhAnh FROM MonAn WHERE TenMonAn = '{MonAn}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())   //load hinh anh vao hinh mon an duoi dang mang byte
                    {
                        HinhMonAn = GetBytes(reader);
                    }
                }
            }
            
            using (MemoryStream  ms = new MemoryStream(HinhMonAn))  //gan hinh anh vao picture box
            {
                ms.Seek(0, SeekOrigin.Begin);
                Image img = Image.FromStream(ms);
                pictureBox1.Image =new Bitmap(img);
            }
            label1.Text = $"{MonAn}";
        }

        static byte[] GetBytes(SQLiteDataReader reader)
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
                    if (bytesRead <= 0) break; // No more data to read, exit loop
                    stream.Write(buffer, 0, (int)bytesRead);
                    dataIndex += bytesRead;
                    bufferSizeIndex += buffersize;
                }
                return stream.ToArray();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BAI06Input form = new BAI06Input(username);
            form.Show();
        }

        private void ShowList_Click(object sender, EventArgs e)
        {
            BAI06View view = new BAI06View();
            view.Show();
        }
    }
}
