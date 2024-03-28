using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class BAI01 : Form
    {
        public BAI01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\HP\\LAB01\\BTTH2\\input1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            using (StreamWriter sw = new StreamWriter("C:\\Users\\HP\\LAB01\\BTTH2\\output1.txt", append: false))
            {
                sw.Write(input);
            }
            MessageBox.Show("Content written successfully!", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
