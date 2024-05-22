using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using HtmlAgilityPack;
using System.Net;
using System.Security.Policy;

namespace LAB04
{
    public partial class BAI03 : Form
    {
        public BAI03()
        {
            InitializeComponent();
            webView.NavigationStarting += CheckHTTPS;
            InitializeAsync();
        }

        private async void Browsebtn_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(URLBox.Text);
            }
        }

        void CheckHTTPS(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            string uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync("");
            }
        }

        private async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            URLBox.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DownloadResourcebtn_Click(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            //DownloadHTMLbtn.PerformClick();
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.Load("A:\\Downloads\\BAI3.html");
            var resourceUrls = new List<string>();
            var imgURLs = htmlDocument.DocumentNode.SelectNodes("//img/@src");
            if (imgURLs != null)
            {
                foreach (var imgNode in imgURLs)
                {
                    resourceUrls.Add(imgNode.GetAttributeValue("src", ""));
                }
            }
            // tai cac file anh vao duong dan mac dinh..
            using (WebClient client = new WebClient())
            {
                foreach (var url in resourceUrls)
                {
                    string fileName = GenerateUniqueFileName(url);
                    client.DownloadFile(new Uri(url), fileName);
                }
            }

            MessageBox.Show("Đã hoàn tất tải về các tài nguyên!", "Thành công", MessageBoxButtons.OK);
        }

        private async void DownloadHTMLbtn_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                Browsebtn.PerformClick();
                await webClient.DownloadFileTaskAsync(new Uri(URLBox.Text), "A:\\Downloads\\BAI3.html");
                MessageBox.Show("Đã hoàn tất tải về!", "Thành công", MessageBoxButtons.OK);
            }
        }

        private string GenerateUniqueFileName(string url)           //ham de tao ra cac ten khac nhau, tranh truong hop nhieu file co cung mot ten
        {
            string extension = Path.GetExtension(url);
            string uniqueFileName = $"{Guid.NewGuid().ToString("N")}{extension}";
            return Path.Combine("A:\\Downloads", uniqueFileName);
        }
    }
}
