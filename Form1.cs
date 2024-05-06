using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI02 f = new BAI02();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BAI06 f = new BAI06();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI01 f = new BAI01();
            f.Show();
        }
    }
}
