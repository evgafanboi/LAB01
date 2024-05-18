using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata;

namespace LAB04
{
    public partial class BAI07 : Form
    {
        // Cac bien duoc su dung thuong xuyen...
        private string accessToken { get; set; }
        private string tokenType { get; set; }
        public string authUrl { get; private set; } = "https://nt106.uitiot.vn/auth/token";
        public string getUserUrl { get; private set; } = "https://nt106.uitiot.vn/api/v1/user/me";
        public string createUserUrl { get; private set; } = "https://nt106.uitiot.vn/api/v1/user/signup";
        public string getMonAnAllUrl { get; private set; } = "https://nt106.uitiot.vn/api/v1/monan/all";
        public string getMonAnSelfUrl { get; private set; } = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
        private bool Authenticated { get; set; } = false;
        private bool ViewMode { get; set; } = false; // False for all, true for self view
        private int available { get; set; }    // Mot bien total de giu tong so cac mon an
        private string username { get; set; }
        private string password { get; set; }
        private List<BAI07Food> selfFood {  get; set; } // Mot mang chi chua cac mon an cua ban than de tien cho viec random
        public BAI07()
        {
            InitializeComponent();
        }

        private async void Randomizebtn_Click(object sender, EventArgs e)
        {
            // Neu da dang nhap, randomize nhu thuong:
            if (Authenticated)
            {
                // Randomizing--------------------------------
                if (ViewMode)
                {// Neu dang randomzing o che do ca nhan:

                    Random rand = new Random();
                    int RandomIndex = rand.Next(0, selfFood.Count);
                    BAI07Food randomFood = selfFood[RandomIndex];
                    BAI07RandomWindow view = new BAI07RandomWindow(randomFood);
                    view.Show();
                    return;
                }
                else
                {
                    Random rand = new Random();
                    int RandomID = rand.Next(1, available);
                    await GetMonAn(RandomID);    // Goi ham lay thuc an co id = random index tu API
                    return;
                }
            }
            // tao form dang nhap neu chua dang nhap
            BAI07Login LoginForm = new BAI07Login();
            if (LoginForm.ShowDialog() == DialogResult.OK)  // Goi form dang nhap
            {
                if (LoginForm.RequestNewAccount == true)    // Neu form dang nhap dong do nguoi dung muon tao tai khoan:
                {
                    BAI07CreateAccount CreateAccountForm = new BAI07CreateAccount();    // Goi form tao tai khoan moi
                    if (CreateAccountForm.ShowDialog() == DialogResult.OK)
                    {
                        await CreateAccount(CreateAccountForm);
                    }
                }
                else
                {
                    // ----------------------Xu ly dang nhap---------------------------
                    username = LoginForm.Username;
                    password = LoginForm.Password;
                    // Khoi tao HttpClient de gui data len API
                    using (var client = new HttpClient())
                    {
                        var content = new MultipartFormDataContent
                        {
                            {new StringContent(username, Encoding.UTF8), "username" },
                            {new StringContent(password, Encoding.UTF8), "password" }
                        };  // Mot bo json data gom username va password

                        // Tao bien response de chua phan hoi tu API
                        var response = await client.PostAsync(authUrl, content);
                        // Doc response
                        var responseString = await response.Content.ReadAsStringAsync();
                        // JSON object chua response de goi cac thanh phan trong response de dang hon
                        var responseObject = JObject.Parse(responseString);
                        if (!response.IsSuccessStatusCode)  // Neu phan hoi khong theo mong doi:
                        {
                            var detail = responseObject["detail"].ToString();   // Goi thanh phan detail trong phan hoi o dang JSON object
                            MessageBox.Show($"Lỗi: {detail}", "Lỗi", MessageBoxButtons.OK);
                            return; // Thoat va doi nguoi dung thu dang nhap lai
                        }
                        tokenType = responseObject["token_type"].ToString();    // Luu token
                        accessToken = responseObject["access_token"].ToString();
                        client.DefaultRequestHeaders.Authorization = new
                            System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                        var getUserResponse = await client.GetAsync(getUserUrl);
                        var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                        var UserObject = JObject.Parse(getUserResponseString);

                        // Thong bao dang nhap thanh cong cho nguoi dung va cac buoc xu ly khac
                        UserWelcomeLabel.Text = $"Welcome, {UserObject["first_name"]}";
                        MessageBox.Show($"Chào mừng, {UserObject["first_name"]}!", "Thông báo", MessageBoxButtons.OK);
                        Authenticated = true;

                        AddFoodbtn.Enabled = true;
                        LogOutLabel.Text = "Log out";
                        LogOutLabel.Visible = true;
                        ProgressBar.Value = 20;
                    }
                }

                //--------------------Dang nhap/tao tai khoan thanh cong-----------------------------

                // Xu ly cac control khac:
                if (Authenticated)
                {
                    //---------------------------------Fetch dishes for both Views---------------------------
                    await FetchFoodList(ViewMode);
                }
            }
            // Neu nguoi dung cancel login form, khong lam gi ca...
            return;
        }

        private async void LogOutLabel_Click(object sender, EventArgs e)
        {
            if (!Authenticated)
                Close();
            //-------------Log out logic here [remember to change text to Exit too]---------------
            await ResetToken();
            Authenticated = false;
            UserWelcomeLabel.Text = "Anonymous";
            LogOutLabel.Text = "Exit";
        }
        private async Task FetchFoodList(bool mode)  // Async Task function de fetch cac mon an dua tren lua chon page
        {
            string selectedUrl;
            if (!mode)
                selectedUrl = getMonAnAllUrl;
            else
                selectedUrl = getMonAnSelfUrl;
            using (var client = new HttpClient())
            {
                // Xu ly authorization token
                client.DefaultRequestHeaders.Add("Authorization", $"{tokenType} {accessToken}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{accessToken}");

                var jsonContent = $"{{\"current\": {CurrentPageCB.Text}, \"pageSize\": {PageCapCB.Text}}}";
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(selectedUrl, content);

                ProgressBar.Value = 40;

                // Bat loi
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK);
                    ProgressBar.Value = 0;
                    return;
                }

                // Chuyen du lieu thanh mang cac form BAI07Item chua thong tin mon an
                var responseString = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(responseString.ToString());
                var jsonArray = (JArray)jsonResponse["data"];    // Deserialize vao mot array list cac mon an

                // Xu ly cac settings trang
                int cap = Int32.Parse(PageCapCB.SelectedItem.ToString());
                int current = 1;
                var pagination = jsonResponse["pagination"];
                available = Int32.Parse(pagination["total"].ToString());
                CurrentPageCB.Items.Clear();
                CurrentPageCB.Items.Add(current.ToString());
                CurrentPageCB.SelectedItem = current;
                int total = available;
                while (total - cap > 0)
                {
                    current++;
                    CurrentPageCB.Items.Add(current.ToString());
                    total -= cap;

                }
                List<BAI07Food> foodArray = jsonArray.ToObject<List<BAI07Food>>();  // Tao mot array cac mon an tu json response o tren
                ProgressBar.Value = 60;
                if (!mode)
                {
                    AllFoodFlow.Controls.Clear();
                    foreach (BAI07Food food in foodArray)
                    {
                        AllFoodFlow.Controls.Add(food);
                        food.CastImage();   // Goi ham rieng de lay anh bang webclient va dua len picturebox
                        ProgressBar.Value++;
                    }
                }
                else
                {
                    selfFood = foodArray;   // Neu dang o che do ca nhan, luu vao array
                    MyFoodFlow.Controls.Clear();
                    foreach (BAI07Food food in foodArray)
                    {
                        MyFoodFlow.Controls.Add(food);
                        food.CastImage();   // Goi ham rieng de lay anh bang webclient va dua len picturebox
                        ProgressBar.Value++;
                    }
                }
            }
            ProgressBar.Value = 100;
        }

        private async Task CreateAccount(BAI07CreateAccount inputForm)
        {
            using (var client = new HttpClient())
            {
                // Xu ly authorization token
                client.DefaultRequestHeaders.Add("Authorization", $"{tokenType} {accessToken}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{accessToken}");

                var jsonContent = $"{{\"username\": \"{inputForm.Username}\", \"email\": \"{inputForm.Email}\"," +
                    $"\"password\": \"{inputForm.Password}\", \"first_name\": \"{inputForm.FirstName}\"," +
                    $"\"sex\": \"{inputForm.Sex}\", \"birthday\": \"{inputForm.Birthday}\"," +
                    $"\"language\": \"{inputForm.Language}\", \"phone\": \"{inputForm.Phone}\"}}";
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(createUserUrl, content);
                ProgressBar.Value = 40;

                // Bat loi
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản, hãy thử lại", "Thông báo", MessageBoxButtons.OK);
                    ProgressBar.Value = 0;
                    return;
                }
                else
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    var jsonResponse = JObject.Parse(responseString.ToString());
                    MessageBox.Show("Tạo tài khoản hoàn tất!", "Thông báo", MessageBoxButtons.OK);
                    Authenticated = true;
                    UserWelcomeLabel.Text = $"Welcome, {jsonResponse["username"].ToString()}";
                    return;
                }
            }
        }



        private void MyFoodFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelfTabView_Click(object sender, EventArgs e)
        {

        }

        private void AllFoodFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void TabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewMode)
                ViewMode = false;
            else
                ViewMode = true;

            await FetchFoodList(ViewMode);
        }

        private async void CurrentPageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FetchFoodList(ViewMode);
        }

        private async void PageCapCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FetchFoodList(ViewMode);
        }

        private async Task GetMonAn(int Id)
        {
                using (var client = new HttpClient())
                {
                    // Xu ly authorization token
                    client.DefaultRequestHeaders.Add("Authorization", $"{tokenType} {accessToken}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{accessToken}");

                    var jsonContent = $"{{\"current\": {CurrentPageCB.Text}, \"pageSize\": {PageCapCB.Text}}}";
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    var response = await client.GetAsync($"https://nt106.uitiot.vn/api/v1/monan/{Id}");

                    ProgressBar.Value = 40;

                    // Bat loi
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    // Dua response ve dang json object
                    var responseString = await response.Content.ReadAsStringAsync();
                    var jsonResponse = JObject.Parse(responseString);

                    // Chuyen json object ve BAI07Food object
                    BAI07Food RandomFood = jsonResponse.ToObject<BAI07Food>();
                    BAI07RandomWindow RandomPopUp = new BAI07RandomWindow(RandomFood);
                    RandomPopUp.Show();
                }
            }
        

        private async void AddFoodbtn_Click(object sender, EventArgs e)
        {
            BAI07Add input = new BAI07Add();
            if (input.ShowDialog() == DialogResult.OK)
            {
                using (var client = new HttpClient())
                {
                    // Add token
                    client.DefaultRequestHeaders.Add("Authorization", $"{tokenType} {accessToken}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{accessToken}");
                    // Init JSON request body
                    var jsonContent = $"{{\"ten_mon_an\": \"{input.nameFood}\", \"gia\": {input.priceFood}," +
                        $" \"mo_ta\": \"{input.description}\", \"hinh_anh\": \"{input.imageSource}\"," +
                        $" \"dia_chi\": \"{input.addressFood}\"}}";

                    //POST
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/add", content);
                    if (response.IsSuccessStatusCode) {
                        MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Thêm món ăn thất bại!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private async Task ResetToken()
        {
            using (var client = new HttpClient())
            {
                // Add token
                client.DefaultRequestHeaders.Add("Authorization", $"{tokenType} {accessToken}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{accessToken}");
                var content = new MultipartFormDataContent
                        {
                            {new StringContent(username, Encoding.UTF8), "username" },
                            {new StringContent(password, Encoding.UTF8), "password" }
                        };  // Mot bo json data gom username va password
                var response = await client.PostAsync("https://nt106.uitiot.vn/auth/refresh", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã đăng xuất!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Đăng xuất thất bại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
