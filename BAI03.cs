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
    public partial class BAI03 : Form
    {
        public BAI03()
        {
            InitializeComponent();
        }

        private void OpenServerbtn_Click(object sender, EventArgs e)
        {
            BAI03Server server = new BAI03Server();
            server.Show();
            server.FormClosed += BAI03Server_Closed;
            ServerOpenbtn.Enabled = false;  //nut disabled, chi cho phep 1 server
        }

        private void BAI03Server_Closed(object sender, FormClosedEventArgs e)
        {
            ServerOpenbtn.Enabled = true;   //khi form server dong, nut "Open TCP Server" tro lai kha dung
        }

        private void NewClientbtn_Click(object sender, EventArgs e)
        {
            BAI03Client client = new BAI03Client();
            client.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
