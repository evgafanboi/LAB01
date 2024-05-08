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
    public partial class BAI05View : Form
    {
        public BAI05View(string[] Community, string[] Personal)
        {
            InitializeComponent();

            foreach (string item in Community)
            {
                CommunityList.Text += item + "\n";
            }
            foreach(string item in Personal)
            {
                PersonalList.Text += item + "\n";
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
