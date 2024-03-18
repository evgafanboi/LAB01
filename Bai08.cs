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
            Student InputStudent = new Student();
            bool NameHasBeenSet = false;    
            float Temp;
            foreach (string i in TextBoxInput.Text.Split(','))
            {
                if (float.TryParse(i, out Temp)) // add score to arr
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

                // handle edge case when the user don't input names
                if (InputStudent.ReadName() == "")
                    MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
