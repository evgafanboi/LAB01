namespace LAB04
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
            TextBoxURL = new TextBox();
            TextBoxUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TextBoxPassword = new TextBox();
            label3 = new Label();
            RichTextBoxOutput = new RichTextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // TextBoxURL
            // 
            TextBoxURL.Location = new Point(182, 44);
            TextBoxURL.Name = "TextBoxURL";
            TextBoxURL.Size = new Size(272, 23);
            TextBoxURL.TabIndex = 0;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(182, 86);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(272, 23);
            TextBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(182, 129);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(272, 23);
            TextBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 137);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // RichTextBoxOutput
            // 
            RichTextBoxOutput.Location = new Point(67, 203);
            RichTextBoxOutput.Name = "RichTextBoxOutput";
            RichTextBoxOutput.Size = new Size(387, 148);
            RichTextBoxOutput.TabIndex = 6;
            RichTextBoxOutput.Text = "";
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(212, 370);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(75, 23);
            ButtonLogin.TabIndex = 7;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // BAI05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 442);
            Controls.Add(ButtonLogin);
            Controls.Add(RichTextBoxOutput);
            Controls.Add(label3);
            Controls.Add(TextBoxPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxURL);
            Name = "BAI05";
            Text = "BAI05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxURL;
        private TextBox TextBoxUsername;
        private Label label1;
        private Label label2;
        private TextBox TextBoxPassword;
        private Label label3;
        private RichTextBox RichTextBoxOutput;
        private Button ButtonLogin;
    }
}