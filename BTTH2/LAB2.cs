﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class LAB2 : Form
    {
        public LAB2()
        {
            InitializeComponent();
        }

        private void LAB2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI01 f1 = new BAI01();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BAI04 f4 = new BAI04();
            f4.Show();
        }
    }
}