using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;



namespace LAB04
{
    public partial class BAI04 : Form
    {
       public BAI04()
        {
            InitializeComponent();
            //this.Size = new Size(612, 739);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            webView21.ZoomFactor = 1.1;
        }
    }
}
