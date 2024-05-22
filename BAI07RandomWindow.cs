using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
=======
using System.Reflection;
>>>>>>> 24b7506 (BAI07 finalized)
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI07RandomWindow : Form
    {
        public BAI07Food food { private get; set; }
<<<<<<< HEAD
        public BAI07RandomWindow(BAI07Food input)
=======
        public string title { private get; set; }
        public BAI07RandomWindow(BAI07Food input, string title)
>>>>>>> 24b7506 (BAI07 finalized)
        {
            InitializeComponent();
            food = input;
            food.CastImage();
<<<<<<< HEAD
=======
            this.title = title;
>>>>>>> 24b7506 (BAI07 finalized)
        }

        private void BAI07RandomWindow_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Text = $"Hôm nay ăn {food.nameFood}";
=======
            Text = $"{title}";
>>>>>>> 24b7506 (BAI07 finalized)
            Panel.Controls.Add(food);
        }
    }
}
