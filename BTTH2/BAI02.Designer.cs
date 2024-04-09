namespace WindowsFormsApplication2
{
    partial class BAI02
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
            this.readbutton = new System.Windows.Forms.Button();
            this.content_richtext = new System.Windows.Forms.RichTextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.size_textbox = new System.Windows.Forms.TextBox();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.linecount_textbox = new System.Windows.Forms.TextBox();
            this.wordcount_textbox = new System.Windows.Forms.TextBox();
            this.charcount_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(152, 21);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(119, 51);
            this.readbutton.TabIndex = 0;
            this.readbutton.Text = "READ";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // content_richtext
            // 
            this.content_richtext.Location = new System.Drawing.Point(356, 37);
            this.content_richtext.Name = "content_richtext";
            this.content_richtext.ReadOnly = true;
            this.content_richtext.Size = new System.Drawing.Size(288, 266);
            this.content_richtext.TabIndex = 1;
            this.content_richtext.Text = "";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.name_textbox.Location = new System.Drawing.Point(98, 86);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(220, 24);
            this.name_textbox.TabIndex = 2;
            // 
            // size_textbox
            // 
            this.size_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.size_textbox.Location = new System.Drawing.Point(98, 126);
            this.size_textbox.Name = "size_textbox";
            this.size_textbox.ReadOnly = true;
            this.size_textbox.Size = new System.Drawing.Size(220, 24);
            this.size_textbox.TabIndex = 3;
            // 
            // url_textbox
            // 
            this.url_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.url_textbox.Location = new System.Drawing.Point(98, 164);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.ReadOnly = true;
            this.url_textbox.Size = new System.Drawing.Size(220, 24);
            this.url_textbox.TabIndex = 4;
            // 
            // linecount_textbox
            // 
            this.linecount_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linecount_textbox.Location = new System.Drawing.Point(98, 200);
            this.linecount_textbox.Name = "linecount_textbox";
            this.linecount_textbox.ReadOnly = true;
            this.linecount_textbox.Size = new System.Drawing.Size(220, 24);
            this.linecount_textbox.TabIndex = 5;
            // 
            // wordcount_textbox
            // 
            this.wordcount_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.wordcount_textbox.Location = new System.Drawing.Point(98, 238);
            this.wordcount_textbox.Name = "wordcount_textbox";
            this.wordcount_textbox.ReadOnly = true;
            this.wordcount_textbox.Size = new System.Drawing.Size(220, 24);
            this.wordcount_textbox.TabIndex = 6;
            // 
            // charcount_textbox
            // 
            this.charcount_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.charcount_textbox.Location = new System.Drawing.Point(98, 274);
            this.charcount_textbox.Name = "charcount_textbox";
            this.charcount_textbox.ReadOnly = true;
            this.charcount_textbox.Size = new System.Drawing.Size(220, 24);
            this.charcount_textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "LINE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "WORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CHAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "SIZE";
            // 
            // BAI02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charcount_textbox);
            this.Controls.Add(this.wordcount_textbox);
            this.Controls.Add(this.linecount_textbox);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.size_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.content_richtext);
            this.Controls.Add(this.readbutton);
            this.Name = "BAI02";
            this.Text = "BAI02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.RichTextBox content_richtext;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox size_textbox;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.TextBox linecount_textbox;
        private System.Windows.Forms.TextBox wordcount_textbox;
        private System.Windows.Forms.TextBox charcount_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}

