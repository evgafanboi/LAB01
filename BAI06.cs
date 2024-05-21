using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace LAB04
{
    public partial class BAI06 : Form
    {
        public BAI06()
        {
            InitializeComponent();
        }


        private async void ButtonLogin_Click(object sender, EventArgs e)
        {

            var url = "https://nt106.uitiot.vn/auth/token";
            //var url = TextBoxURL.Text;
            var username = TextBoxUsername.Text;
            var password = TextBoxPassword.Text;


            //check url
            //if (string.IsNullOrEmpty(TextBoxURL.Text))
            //{
            //    MessageBox.Show("Please enter URL");
            //    return;
            //}
            if (string.IsNullOrEmpty(TextBoxUsername.Text))
            {
                MessageBox.Show("Please enter Username");
                return;
            }
            if (string.IsNullOrEmpty(TextBoxPassword.Text))
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
                return;
            }
            string access_token = "";
            string token_type = ""; 

            try
            {
                var respondString = await respond.Content.ReadAsStringAsync();
                var respondJson = JObject.Parse(respondString);
                if (respond.IsSuccessStatusCode)
                {
                    //extract access token and token type
                    access_token = respondJson["access_token"].ToString();
                    token_type = respondJson["token_type"].ToString();

                    //update richtextbox
                    RichTextBoxOutput.Text = token_type + "\n" + access_token + "\n Loged In";
                }
            }
            catch
            {
                MessageBox.Show("Could not receive data from Server");
                return;
            }

            if (string.IsNullOrEmpty(access_token) || string.IsNullOrEmpty(token_type))
            {
                MessageBox.Show("Could not receive data from Server");
                return;
            }

            client.Dispose();
            client = new HttpClient();
            url = "https://nt106.uitiot.vn/api/v1/user/me";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token_type, access_token);
            var Response2 = await client.GetAsync(url);
            var Response2_String = await Response2.Content.ReadAsStringAsync();
            if (Response2.IsSuccessStatusCode)
            {
                var Response2_Json = JObject.Parse(Response2_String);
                string id = Response2_Json["id"].ToString();
                string username2 = Response2_Json["username"].ToString();
                string email = Response2_Json["email"].ToString();
                string email_verified = Response2_Json["email_verified"].ToString();
                string first_name = Response2_Json["first_name"].ToString();
                string last_name = Response2_Json["last_name"].ToString();
                string avatar = Response2_Json["avatar"].ToString();
                string sex = Response2_Json["sex"].ToString();
                string birthday = Response2_Json["birthday"].ToString();
                string language = Response2_Json["language"].ToString();
                string phone = Response2_Json["phone"].ToString();
                string phone_verified = Response2_Json["phone_verified"].ToString();
                string is_active = Response2_Json["is_active"].ToString();
                string is_superuser = Response2_Json["is_superuser"].ToString();
                //RichTextBoxOutput.Text += "\n" +  Response2_Json.ToString();
                RichTextBoxOutput.Text += "\n" + "Data from server: ";
                RichTextBoxOutput.Text += "\n" + "id: " + id;
                RichTextBoxOutput.Text += "\n" + "username: " + username2;
                RichTextBoxOutput.Text += "\n" + "email: " + email;
                RichTextBoxOutput.Text += "\n" + "email_verified: " + email_verified;
                RichTextBoxOutput.Text += "\n" + "first_name: " + first_name;
                RichTextBoxOutput.Text += "\n" + "last_name: " + last_name;
                RichTextBoxOutput.Text += "\n" + "avatar: " + avatar;
                RichTextBoxOutput.Text += "\n" + "sex " + sex;
                RichTextBoxOutput.Text += "\n" + "birthday: " + birthday;
                RichTextBoxOutput.Text += "\n" + "language: " + language;
                RichTextBoxOutput.Text += "\n" + "phone: " + phone;
                RichTextBoxOutput.Text += "\n" + "phone_verified: " + phone_verified;
                RichTextBoxOutput.Text += "\n" + "is_active: " + is_active;
                RichTextBoxOutput.Text += "\n" + "is_superuser: " + is_superuser;
            }
            else
            {
                MessageBox.Show("Failed to get data from server");
                return;
            }
            //close connection
            client.Dispose();
        }
    }
}   
