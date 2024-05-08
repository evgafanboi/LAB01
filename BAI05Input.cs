using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Net.Sockets;

namespace LAB03
{
    public partial class BAI05Input : Form
    {
        public string IdMonAn { get; private set; }
        public string Ten {  get; private set; }
        public byte[] imageData { get; private set; }
        NetworkStream ns;
        public BAI05Input()
        {
            InitializeComponent();
        }
        private string imagepath;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Ten = textBox1.Text;
            IdMonAn = textBox2.Text;
            if (string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(IdMonAn) || string.IsNullOrEmpty(imagepath))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            imageData = File.ReadAllBytes(imagepath);
            this.DialogResult = DialogResult.OK;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            ImagePreview.Image = null;
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
    }
}
