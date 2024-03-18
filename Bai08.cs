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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }

        private void Bai08_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBoxOutput.Text = "";
            Student InputStudent = new Student();
            bool NameHasBeenSet = false;    
            float Temp = -1;
            foreach (string i in TextBoxInput.Text.Split(','))
            {
                if (float.TryParse(i, out Temp) && Temp >= 0 && Temp <=10) // add score to arr
                    InputStudent.AddScore(Temp);
                else // if the string isn't a int => a string (name ?)
                {
                    if (!NameHasBeenSet)
                    {
                        InputStudent.SetName(i);
                        NameHasBeenSet = true;
                    }
                    else
                    {
                        MessageBox.Show("Input không hợp lệ", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // handle edge case when the user don't input names or score
            if (InputStudent.ReadName() == "" || InputStudent.NumberOfScore() <= 0)
            {
                MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Append output to Output textbox
            RichTextBoxOutput.AppendText("Họ và tên: " + InputStudent.ReadName() + Environment.NewLine);

            for (int i = 0; i < InputStudent.NumberOfScore(); i++)
                RichTextBoxOutput.AppendText("Môn "+ (i+1).ToString() + ": " + InputStudent.ReadScore(i).ToString() + Environment.NewLine);

            RichTextBoxOutput.AppendText("Điểm trung bình: " + InputStudent.AvgScore() + Environment.NewLine);
            RichTextBoxOutput.AppendText("Số môn đậu: " + InputStudent.NumPassingScores() + Environment.NewLine);
            RichTextBoxOutput.AppendText("Số môn không đậu: " + InputStudent.NumFailedScores() + Environment.NewLine);
            RichTextBoxOutput.AppendText("Sinh viên xếp loại: ");
            switch (InputStudent.GradeStudent())
            {
                case 4:
                    RichTextBoxOutput.AppendText("Giỏi");
                    break;

                case 3:
                    RichTextBoxOutput.AppendText("Khá");
                    break;

                case 2:
                    RichTextBoxOutput.AppendText("Trung bình");
                    break;
                case 1:
                    RichTextBoxOutput.AppendText("Yếu");
                    break;

                default:
                    RichTextBoxOutput.AppendText("Kém");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
