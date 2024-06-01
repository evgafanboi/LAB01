namespace LAB05
{
    partial class BAI06form2
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
            this.WebView2_Output = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonReply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WebView2_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // WebView2_Output
            // 
            this.WebView2_Output.AllowExternalDrop = true;
            this.WebView2_Output.CreationProperties = null;
            this.WebView2_Output.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView2_Output.Location = new System.Drawing.Point(43, 74);
            this.WebView2_Output.Name = "WebView2_Output";
            this.WebView2_Output.Size = new System.Drawing.Size(724, 316);
            this.WebView2_Output.TabIndex = 0;
            this.WebView2_Output.ZoomFactor = 1D;
            this.WebView2_Output.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebView2_Output_CoreWebView2InitializationCompleted);
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(40, 19);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(35, 13);
            this.LabelFrom.TabIndex = 1;
            this.LabelFrom.Text = "label1";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(379, 19);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(35, 13);
            this.LabelTo.TabIndex = 2;
            this.LabelTo.Text = "label2";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(40, 49);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(50, 16);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "label3";
            // 
            // ButtonReply
            // 
            this.ButtonReply.Location = new System.Drawing.Point(359, 406);
            this.ButtonReply.Name = "ButtonReply";
            this.ButtonReply.Size = new System.Drawing.Size(75, 23);
            this.ButtonReply.TabIndex = 4;
            this.ButtonReply.Text = "Reply";
            this.ButtonReply.UseVisualStyleBackColor = true;
            // 
            // BAI06form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReply);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.WebView2_Output);
            this.Name = "BAI06form2";
            this.Text = "BAI06form2";
            ((System.ComponentModel.ISupportInitialize)(this.WebView2_Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebView2_Output;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonReply;
    }
}