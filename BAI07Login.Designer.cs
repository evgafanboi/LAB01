namespace LAB04
{
    partial class BAI07Login
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
            label2 = new Label();
            Submitbtn = new Button();
            label1 = new Label();
            label3 = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(242, 48);
            label2.Name = "label2";
            label2.Size = new Size(194, 46);
            label2.TabIndex = 26;
            label2.Text = "Đăng nhập";
            // 
            // Submitbtn
            // 
            Submitbtn.BackColor = Color.AliceBlue;
            Submitbtn.Font = new Font("Segoe UI", 10.2F);
            Submitbtn.ForeColor = Color.MidnightBlue;
            Submitbtn.Location = new Point(529, 168);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(120, 56);
            Submitbtn.TabIndex = 24;
            Submitbtn.Text = "Log In";
            Submitbtn.UseVisualStyleBackColor = false;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(30, 148);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 27;
            label1.Text = "Đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(30, 207);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 28;
            label3.Text = "Đăng ký";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(159, 152);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(323, 27);
            UsernameInput.TabIndex = 29;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(159, 211);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '#';
            PasswordInput.Size = new Size(323, 27);
            PasswordInput.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(200, 316);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 31;
            label4.Text = "Chưa có tài khoản?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(384, 316);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 32;
            label5.Text = "Tạo mới";
            label5.Click += label5_Click;
            // 
            // BAI07Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(695, 353);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Submitbtn);
            Name = "BAI07Login";
            Text = "BAI07Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Randomizebtn;
        private Button Submitbtn;
        private Label label1;
        private Label label3;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Label label4;
        private Label label5;
    }
}