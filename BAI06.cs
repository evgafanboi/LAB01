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
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            BAI06Client f = new BAI06Client();
            f.Show();
        }

        private void ButtonServer_Click(object sender, EventArgs e)
        {
            BAI06Server f = new BAI06Server();
            f.Show();
        }
    }
}
