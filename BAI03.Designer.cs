namespace LAB04
{
    partial class BAI03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DownloadResourcebtn = new Button();
            Exitbtn = new Button();
            URLBox = new TextBox();
            Browsebtn = new Button();
            label1 = new Label();
            DownloadHTMLbtn = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // DownloadResourcebtn
            // 
            DownloadResourcebtn.Location = new Point(499, 122);
            DownloadResourcebtn.Name = "DownloadResourcebtn";
            DownloadResourcebtn.Size = new Size(105, 52);
            DownloadResourcebtn.TabIndex = 13;
            DownloadResourcebtn.Text = "Download Resource";
            DownloadResourcebtn.UseVisualStyleBackColor = true;
            DownloadResourcebtn.Click += DownloadResourcebtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Location = new Point(61, 122);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(105, 27);
            Exitbtn.TabIndex = 12;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // URLBox
            // 
            URLBox.Location = new Point(61, 70);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(543, 27);
            URLBox.TabIndex = 9;
            // 
            // Browsebtn
            // 
            Browsebtn.Location = new Point(634, 70);
            Browsebtn.Name = "Browsebtn";
            Browsebtn.Size = new Size(105, 27);
            Browsebtn.TabIndex = 8;
            Browsebtn.Text = "Browse";
            Browsebtn.UseVisualStyleBackColor = true;
            Browsebtn.Click += Browsebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(352, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 7;
            label1.Text = "BÀI 03";
            // 
            // DownloadHTMLbtn
            // 
            DownloadHTMLbtn.Location = new Point(634, 122);
            DownloadHTMLbtn.Name = "DownloadHTMLbtn";
            DownloadHTMLbtn.Size = new Size(105, 52);
            DownloadHTMLbtn.TabIndex = 14;
            DownloadHTMLbtn.Text = "Download HTML";
            DownloadHTMLbtn.UseVisualStyleBackColor = true;
            DownloadHTMLbtn.Click += DownloadHTMLbtn_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 200);
            webView.Name = "webView";
            webView.Size = new Size(781, 355);
            webView.TabIndex = 15;
            webView.ZoomFactor = 1D;
            // 
            // BAI03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(805, 567);
            Controls.Add(webView);
            Controls.Add(DownloadHTMLbtn);
            Controls.Add(DownloadResourcebtn);
            Controls.Add(Exitbtn);
            Controls.Add(URLBox);
            Controls.Add(Browsebtn);
            Controls.Add(label1);
            Name = "BAI03";
            Text = "BAI03";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DownloadResourcebtn;
        private Button Exitbtn;
        private TextBox URLBox;
        private Button Browsebtn;
        private Label label1;
        private Button DownloadHTMLbtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}