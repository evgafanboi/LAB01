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
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            if ((!int.TryParse(TextBoxA.Text, out A)) || (!int.TryParse(TextBoxB.Text, out B)))
                MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK , MessageBoxIcon.Error);
            // Lỗi khi không parse dược text -> int

            // Giai thừa
            if (ButtonGiaiThua.Checked)
            {
                // handle negative factorial
                if (B > A)
                {
                    MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (A - B == 0)
                {
                    TextBoxAnswer.Text = "1";
                    return;
                }
                int Answer = 1;
                for(int i = A - B; i > 0; i--)
                {
                    Answer = Answer * i;
                }
                TextBoxAnswer.Text = Answer.ToString();
                return;
            }

            // Tổng S
            if (ButtonSum.Checked)
            {
                if(B < 1)
                {
                    MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double Answer = 0;
                for(int i = 1; i <= B; i++)
                {
                    Answer = Answer + Math.Pow(A, i);
                }
                TextBoxAnswer.Text = Answer.ToString();
                return;
            }

            // Cửu chương
            if (ButtonBangCuuChuong.Checked)
            {
                if (A >= B)
                {
                    MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Clear answer box first
                TextBoxAnswer.Text = "";

                for (int i = 1; i <= 10; i++)
                {
                    TextBoxAnswer.AppendText( (B - A).ToString() + " x " + i.ToString() + " = " + ((B - A) * i).ToString() );
                    TextBoxAnswer.AppendText(Environment.NewLine);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAI06_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateButton.Enabled = true;
        }

        private void ButtonGiaiThua_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGiaiThua_CheckedChanged(object sender, EventArgs e)
        {
                CalculateButton.Enabled = true;
        }

        private void ButtonSum_CheckedChanged(object sender, EventArgs e)
        {
                CalculateButton.Enabled = true;
        }
    }
}
