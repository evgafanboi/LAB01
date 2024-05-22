using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI07RandomWindow : Form
    {
        public BAI07Food food { private get; set; }
        public string title { private get; set; }
        public BAI07RandomWindow(BAI07Food input, string title)
        {
            InitializeComponent();
            food = input;
            food.CastImage();
            this.title = title;
        }

        private void BAI07RandomWindow_Load(object sender, EventArgs e)
        {
            Text = $"{title}";
            Panel.Controls.Add(food);
        }
    }
}
