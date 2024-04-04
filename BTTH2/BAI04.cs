using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class BAI04 : Form
    {
        public BAI04()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SĐT_Click(object sender, EventArgs e)
        {

        }

        private void BAI04_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMSSV_TextChanged(object sender, EventArgs e)
        {
            // enable button to add student 
            ButtonAdd.Enabled = true;

        }

        private void ButtonWrite_Click(object sender, EventArgs e)
            
        {
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // disable the button until user have input all the required fields except for the AvgTextBox
            if (TextBoxName.Text == "" || TextBoxName.Text == "" || TextBoxPhoneNum.Text == "" || TextBoxScore1.Text == "" || TextBoxScore2.Text == "" || TextBoxScore3.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the input is valid for all scores score must be larger or equal to 0 and smaller or equal to 10
            try
            {
                if (int.Parse(TextBoxScore1.Text) < 0 || int.Parse(TextBoxScore1.Text) > 10 || int.Parse(TextBoxScore2.Text) < 0 || int.Parse(TextBoxScore2.Text) > 10 || int.Parse(TextBoxScore3.Text) < 0 || int.Parse(TextBoxScore3.Text) > 10)
                {
                    MessageBox.Show("Điểm phải trong hệ 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // catch exception if the input is not a number
            catch (Exception)
            {
                MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // name must not contain any character that is not a letter or a space
            foreach (char c in TextBoxName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Tên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
     

            


        }

        private void TextBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {
            // enable button to add student 
            ButtonAdd.Enabled = true;
        }

        private void TextBoxScore1_TextChanged(object sender, EventArgs e)
        {
            // enable button to add student 
            ButtonAdd.Enabled = true;
            ButtonCalculateAvg.Enabled = true;

        }

        private void TextBoxScore2_TextChanged(object sender, EventArgs e)
        {
            // enable button to add student 
            ButtonAdd.Enabled = true;
            ButtonCalculateAvg.Enabled = true;

        }

        private void TextBoxScore3_TextChanged(object sender, EventArgs e)
        {
            // enable button to add student 
            ButtonAdd.Enabled = true;
            ButtonCalculateAvg.Enabled = true;

        }

        private void ButtonCalculateAvg_Click(object sender, EventArgs e)
        {
            //calculate the average score from the 3 scores and check for invalid input scores must be larger or equal to 0 and smaller or equal to 10
            try
            {
                if (int.Parse(TextBoxScore1.Text) < 0 || int.Parse(TextBoxScore1.Text) > 10 || int.Parse(TextBoxScore2.Text) < 0 || int.Parse(TextBoxScore2.Text) > 10 || int.Parse(TextBoxScore3.Text) < 0 || int.Parse(TextBoxScore3.Text) > 10)
                {
                    MessageBox.Show("Điểm phải trong hệ 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //calculate the average score and update the AvgTextBox
                TextBoxAvg.Text = ((float)((int.Parse(TextBoxScore1.Text) + int.Parse(TextBoxScore2.Text) + int.Parse(TextBoxScore3.Text)) / 3)).ToString();
            }
            //catch exception if the input is not a number
            catch (Exception)
            {
                MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
