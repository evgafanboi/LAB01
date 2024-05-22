using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;

namespace LAB04
{
    public partial class BAI07Food : UserControl
    {
        public BAI07Food()
        {
            InitializeComponent();

            this.Click += BAI07Food_Click;
        }

        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("ten_mon_an")]
        public string nameFood
        {    // Dung FoodName.Text de doc va ghi
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }
        [JsonProperty("gia")]
        public string priceFood
        {
            get { return FoodPrice.Text; }
            set { FoodPrice.Text = value; }
        }
        [JsonProperty("hinh_anh")]
        public string imageFood { get; set; }
        [JsonProperty("dia_chi")]
        public string addressFood
        {    // Dung FoodName.Text de doc va ghi
            get { return Address.Text; }
            set { Address.Text = value; }
        }
        [JsonProperty("nguoi_dong_gop")]
        public string contributorFood
        {    // Dung FoodName.Text de doc va ghi
            get { return Contributor.Text; }
            set { Contributor.Text = value; }
        }

        public void CastImage()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(imageFood);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        FoodPictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BAI07Food_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Món {this.nameFood} có ID = {this.id}", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
