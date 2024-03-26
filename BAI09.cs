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
    public partial class BAI09 : Form
    {
        public BAI09()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string food = foodtextBox.Text;

            if (!string.IsNullOrEmpty(food))
            {
                foodListTextBox.AppendText(food + '\n');
                foodtextBox.Text = null;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            foodListTextBox.Text = null;
            resulttextBox.Text = null;
        }

        private void findbutton_Click(object sender, EventArgs e)
        {

            if (foodListTextBox.TextLength == 0) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                resulttextBox.Text = null;
                string foods = foodListTextBox.Text;

                string[] food_list = foods.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Random random = new Random();
                string randomfood = food_list[random.Next(food_list.Length)];
                resulttextBox.Text = randomfood;
            }

        }
    }
}
