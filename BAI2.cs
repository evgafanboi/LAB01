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
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            int min = 0, max = 0;
            if ((Int32.TryParse(textBox1.Text.Trim(), out int result1))
                && (Int32.TryParse(textBox2.Text.Trim(), out int result2))
                && (Int32.TryParse(textBox3.Text.Trim(), out int result3))
                )
            {
                num1 = result1;
                num2 = result2;
                num3 = result3;
                if (num1 < num2 && num1 < num3)  //case where num1 is max
                {
                    min = num1;
                    if (num2 > num3)    //find max of either 2 or 3
                        max = num2;
                    else
                        max = num3;
                }
                else if (num1 > num2 && num3 > num2)    //for num2
                {
                    min = num2;
                    if (num1 > num3)
                        max = num1;
                    else
                        max = num3;
                }
                else    //only num3 now
                {
                    min = num3;
                    if (num1 > num2)
                        max = num1;
                    else
                        max = num2;
                }
                textBox4.Text = max.ToString(); //so lon nhat
                textBox5.Text = min.ToString(); //so nho nhat
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                this.button3_Click(sender, e);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

