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
    public partial class BAI3 : Form
    {
        public BAI3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inp = 0;
            string oup;
            if (Int32.TryParse(textBox1.Text, out inp))
            {
                switch (inp)
                {
                    case 0:
                        oup = "Không";
                        break;
                    case 1:
                        oup = "Một";
                        break;
                    case 2:
                        oup = "Hai";
                        break;
                    case 3:
                        oup = "Ba";
                        break;
                    case 4:
                        oup = "Bốn";
                        break;
                    case 5:
                        oup = "Năm";
                        break;
                    case 6:
                        oup = "Sáu";
                        break;
                    case 7:
                        oup = "Bảy";
                        break;
                    case 8:
                        oup = "Tám";
                        break;
                    case 9:
                        oup = "Chín";
                        break;
                    default:
                        oup = "Số không hợp lệ...";
                        break;
                }
                textBox2.Text = oup;
            }
            else
            {
                MessageBox.Show("Không phải số nguyên!");
                button2_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
