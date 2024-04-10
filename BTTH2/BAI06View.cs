using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace BTTH2
{
    public partial class BAI06View : Form
    {
        private static string databasePath = "..\\BAI06.sqlite";
        private static string connectionString = $"Data Source = {databasePath}; Version=3;";
        public BAI06View()
        {
            InitializeComponent();
            ListMonAn();
        }

        private void BAI06View_Load(object sender, EventArgs e)
        {

        }

        private void ListMonAn()
        {
            string query = "SELECT TenMonAn FROM MonAn";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string attributeValue = reader["TenMonAn"].ToString();
                        ListMA.Items.Add(attributeValue);
                    }
                }
            }
        }

        private void DisplayImage(string selectedValue)
        {
            string query = "SELECT HinhAnh FROM MonAn WHERE TenMonAn = @AttributeValue";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AttributeValue", selectedValue);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    byte[] imageData = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        ImagePreview.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ImagePreview.Image = null;
                    MessageBox.Show("No image found for the selected attribute.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ListMA.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedValue))
            {
                DisplayImage(selectedValue);
            }
        }
    }
}
