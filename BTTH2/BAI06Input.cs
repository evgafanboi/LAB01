using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;
using System.IO;
namespace BTTH2
{
    public partial class BAI06Input : Form
    {
        private string username;
        public BAI06Input(string username)
        {
            InitializeComponent();
            this.username = username;

        }
        private string imagepath;
        private static string databasePath = "..\\BAI06.sqlite";
        private static string connectionString = $"Data Source = {databasePath}; Version=3;";
        private void BAI06Input_Load(object sender, EventArgs e)
        {

        }

        private void FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                ImagePreview.Image = Image.FromFile(imagepath);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            ImagePreview.Image = null;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string TenMonAn = textBox1.Text;
            string IdMonAn = textBox2.Text;
            if (string.IsNullOrEmpty(TenMonAn) || string.IsNullOrEmpty(IdMonAn) || string.IsNullOrEmpty(imagepath))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            byte[] imageData = File.ReadAllBytes(imagepath);
            InsertMonAn(IdMonAn, TenMonAn, imageData);

            MessageBox.Show("Thêm món ăn thành công");
            Clear_Click(sender, e);
        }

        private void InsertMonAn(string id, string ten, byte[] image)
        {
            string query = "INSERT INTO MonAn VALUES (@ID, @Ten, @Anh, @NguoiThem)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@Anh", image);
                command.Parameters.AddWithValue("@NguoiThem", username);
                command.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
