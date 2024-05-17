using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json;

namespace LAB04
{
    public partial class BAI05 : Form
    {
        public BAI05()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {

            //var url = "https://nt106.uitiot.vn/auth/token";
            var url = TextBoxURL.Text;
            var username = TextBoxUsername.Text;
            var password = TextBoxPassword.Text;


            //check url
            if (string.IsNullOrEmpty(TextBoxURL.Text))
            {
                MessageBox.Show("Please enter URL");
                return;
            }
            if(string.IsNullOrEmpty(TextBoxUsername.Text))
            {
                MessageBox.Show("Please enter Username");
                return;
            }
            if(string.IsNullOrEmpty(TextBoxPassword.Text))
            {
                MessageBox.Show("Please enter Password");
                return;
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            var dict = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password },

            }; // dict

            var content = new FormUrlEncodedContent(dict);
            // k dùng form content nữa vì server chỉ nhận form-urlencoded


            HttpResponseMessage respond = null;
            
            try
            {
                respond = await client.PostAsync(url, content);
            }
            catch
            {
                MessageBox.Show("Failed to send POST request to server");
            }
            
            try
            {
                var respondString = await respond.Content.ReadAsStringAsync();
                var respondJson = JObject.Parse(respondString);
                if(respond.IsSuccessStatusCode)
                {
                    //extract access token and token type
                    string access_token = respondJson["access_token"].ToString();
                    string token_type = respondJson["token_type"].ToString();

                    //update richtextbox
                    RichTextBoxOutput.Text = token_type + "\n" + access_token + "\n Loged In"  ;
                }
            }
            catch
            {
                MessageBox.Show("Could not receive data from Server");
            }

            //close connection
            client.Dispose();
        }
    }
}
