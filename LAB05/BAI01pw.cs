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
    public partial class BAI01pw : Form
    {
        public string pw;
        public string name;
        public BAI01pw()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            pw = InputBox.Text;
            if (string.IsNullOrEmpty(pw) )
            {
                MessageBox.Show("Password is empty?");
                return;
            }
            name = NameBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
