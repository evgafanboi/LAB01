﻿using System;
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
            BAI2 f2 = new BAI2();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI1 f1 = new BAI1();
            f1.Show();
        }

        private void LAB1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAI3 f3 = new BAI3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BAI06 fBai06 = new BAI06();
            fBai06.Show();
        }
    }
}
