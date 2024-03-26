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
    public partial class LAB1 : Form
    {
        public LAB1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI02 f2 = new BAI02();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI01 f1 = new BAI01();
            f1.Show();
        }

        private void LAB1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAI03 f3 = new BAI03();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BAI04 f4 =  new BAI04();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BAI05 f5 = new BAI05();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BAI06 fBai06 = new BAI06();
            fBai06.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BAI07 fBai07 = new BAI07();
            fBai07.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai08 fBai08 = new Bai08();
            fBai08.Show();
        }
    }
}
