using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LAB2());
            DBInit();
        }
        static void DBInit()
        {
            string databasePath = "..\\BAI06.sqlite";
            string connectionString = $"Data Souce = {databasePath}; Version=3;";
            SQLiteConnection.CreateFile(databasePath);
        
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //create a couple of tables for foods and consumers...
        
                string createTables = @"
                    CREATE TABLE IF NOT EXISTS MonAn(
                        IDMA TEXT PRIMARY KEY,
                        TenMonAn TEXT,
                        HinhAnh BLOB,
                        IDNCC TEXT FOREIGN KEY REFERNCES NguoiDung(IDNCC)
                    );
        
                    CREATE TABLE IF NOT EXISTS NguoiDung(
                    IDNCC TEXT PRIMARY KEY,
                    HoVaTen TEXT,
                    QuyenHan TEXT
                    );
                    ";
                //execute query
                using (SQLiteCommand command = new SQLiteCommand(createTables, connection))
                {
                    command.ExecuteNonQuery();
                }
        
                //nhap lieu
                string insertData = @"
                    INSERT INTO MonAn VALUES
                    ('BB', 'Bun bo', @'imageBunBo', 'Admin'),
                    ('Ph', 'Pho', @'imagePho', 'Admin'),
                    ('Ls', 'Lasagna', @'imageLasagna', 'Admin'),
                    ('Br', 'Burrito', @'imageBurrito', 'Amigo'),
                    ('Pz', 'Pizza', @'imagePizza', 'American'),
                    ('Bg', 'Burger', @'imageBurger', 'American'),
                    ('BM', 'Banh mi', @'imageBanhmi', 'Admin'),
                    ('Hz', '5000 oz of Heinz ketchup', @'imageHeinz', 'Amigo'),
                    ('Gr', 'Grass', @'imageGrass', 'Herbivore')
        
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
                    command.ExecuteNonQuery();
                }
        
                MessageBox.Show("Ket noi voi csdl thanh cong!", "Ket noi khong that bai", MessageBoxButtons.OK);
            }
        }
    }
}
