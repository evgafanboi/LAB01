using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04
{
    public partial class BAI07Delete : Form
    {
        public string ID
        {
            get
            {
                return IDInput.Text;
            }

            set
            {
                IDInput.Text = value;
            }
        }

        private int[] IDlist { get; set; }
        public BAI07Delete(int[] selfIDs)
        {
            InitializeComponent();
            IDlist = selfIDs;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (IDInput.Text == null || !IDlist.Contains(Int32.Parse(IDInput.Text)))
                MessageBox.Show("ID phải là của món ăn của bản thân", "Lỗi", MessageBoxButtons.OK);
            DialogResult = DialogResult.OK;
        }
    }
}
