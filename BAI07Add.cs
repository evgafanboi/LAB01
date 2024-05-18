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
    public partial class BAI07Add : Form
    {
        public string nameFood { get; set; }
        public string priceFood { get; set; }
        public string addressFood { get; set; }
        public string imageSource { get; set; }
        public string description {  get; set; }
        public BAI07Add()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            NameInput.Clear();
            PriceInput.Clear();
            AddressFood.Clear();
            imageURL.Clear();
            DescriptionInput.Clear();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            nameFood = NameInput.Text;
            priceFood = PriceInput.Text;
            addressFood = AddressFood.Text;
            imageSource = imageURL.Text;
            description = DescriptionInput.Text;
            DialogResult = DialogResult.OK;
        }

    }
}
