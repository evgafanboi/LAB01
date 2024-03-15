using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH1
{
    public partial class BAI01 : Form
    {
        public BAI01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            long sum = 0;
            if ((Int32.TryParse(textBox1.Text.Trim(), out int result1)) && (Int32.TryParse(textBox2.Text.Trim(), out int result)))
            {
                num1 = result1;
                num2 = result;
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số int32!");
                textBox3.Text = "Không có gì ở đây.";
            }

        }
    }
}
