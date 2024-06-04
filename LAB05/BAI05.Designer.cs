namespace LAB05
{
    partial class BAI05
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
            this.Exitbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loginbtn = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(821, 139);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(109, 37);
            this.Exitbtn.TabIndex = 26;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.Sender,
            this.Date});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 186);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 335);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 300;
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 185;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 180;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(586, 31);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(255, 57);
            this.Loginbtn.TabIndex = 22;
            this.Loginbtn.Text = "View";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Bisque;
            this.LabelPassword.Location = new System.Drawing.Point(57, 67);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(97, 22);
            this.LabelPassword.TabIndex = 21;
            this.LabelPassword.Text = "Password";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.Bisque;
            this.LabelEmail.Location = new System.Drawing.Point(57, 31);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(59, 22);
            this.LabelEmail.TabIndex = 20;
            this.LabelEmail.Text = "Email";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(169, 69);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(287, 22);
            this.TextBoxPassword.TabIndex = 19;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(169, 31);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(287, 22);
            this.TextBoxEmail.TabIndex = 18;
            // 
            // BAI05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(962, 553);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Name = "BAI05";
            this.Text = "BAI05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxEmail;
    }
}