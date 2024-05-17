namespace LAB04
{
    partial class BAI06
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
            ButtonLogin = new Button();
            RichTextBoxOutput = new RichTextBox();
            label3 = new Label();
            TextBoxPassword = new TextBox();
            label2 = new Label();
            TextBoxUsername = new TextBox();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(193, 339);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(75, 23);
            ButtonLogin.TabIndex = 15;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // RichTextBoxOutput
            // 
            RichTextBoxOutput.Location = new Point(48, 172);
            RichTextBoxOutput.Name = "RichTextBoxOutput";
            RichTextBoxOutput.Size = new Size(387, 148);
            RichTextBoxOutput.TabIndex = 14;
            RichTextBoxOutput.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(163, 98);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(272, 23);
            TextBoxPassword.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(163, 55);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(272, 23);
            TextBoxUsername.TabIndex = 9;
            // 
            // BAI06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 448);
            Controls.Add(ButtonLogin);
            Controls.Add(RichTextBoxOutput);
            Controls.Add(label3);
            Controls.Add(TextBoxPassword);
            Controls.Add(label2);
            Controls.Add(TextBoxUsername);
            Name = "BAI06";
            Text = "BAI06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private RichTextBox RichTextBoxOutput;
        private Label label3;
        private TextBox TextBoxPassword;
        private Label label2;
        private TextBox TextBoxUsername;
    }
}