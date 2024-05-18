using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI07RandomWindow : Form
    {
        public BAI07Food food { private get; set; }
        public BAI07RandomWindow(BAI07Food input)
        {
            InitializeComponent();
            food = input;
            food.CastImage();
        }

        private void BAI07RandomWindow_Load(object sender, EventArgs e)
        {
            Text = $"Hôm nay ăn {food.nameFood}";
            Panel.Controls.Add(food);
        }
    }
}
