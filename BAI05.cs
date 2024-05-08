﻿using System;
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
    public partial class BAI05 : Form
    {
        public BAI05()
        {
            InitializeComponent();
        }
        List <BAI05Client> clients = new List <BAI05Client>();
        private void ServerOpenbtn_Click(object sender, EventArgs e)
        {
            BAI05Server server = new BAI05Server();
            server.Show();
            server.FormClosed += BAI05Server_Closed;
            ServerOpenbtn.Enabled = false;  //nut disabled, chi cho phep 1 server
        }

        private void BAI05Server_Closed(object sender, FormClosedEventArgs e)
        {
            ServerOpenbtn.Enabled = true;   //khi form server dong, nut "Open TCP Server" tro lai kha dung
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            clients.Clear();
            Close();
        }

        private void NewClientbtn_Click(object sender, EventArgs e)
        {
            BAI05Client client = new BAI05Client();
            clients.Add(client);
            client.Show();
        }
    }
}
