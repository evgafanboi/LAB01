using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBai02_Click(object sender, EventArgs e)
        {
            BAI02 bAI02 = new BAI02();
            bAI02.Show();
        }

        private void ButtonBai06_Click(object sender, EventArgs e)
        {
            BAI06 bAI06 = new BAI06();
            bAI06.Show();
        }

        private void ButtonBai03_Click(object sender, EventArgs e)
        {
            BAI03 f3 = new BAI03();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
