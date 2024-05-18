namespace LAB04
{
    partial class BAI07CreateAccount
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
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            Submitbtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            FemaleRadbtn = new RadioButton();
            MaleRadbtn = new RadioButton();
            LanguageChoice = new ComboBox();
            BirthdayInput = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            LastNameInput = new TextBox();
            PhoneNumberInput = new TextBox();
            label7 = new Label();
            label8 = new Label();
            EmailInput = new TextBox();
            FirstNameInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Clearbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(177, 131);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '#';
            PasswordInput.Size = new Size(323, 34);
            PasswordInput.TabIndex = 38;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(177, 72);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(323, 34);
            UsernameInput.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Bisque;
            label3.Location = new Point(24, 134);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 36;
            label3.Text = "Password*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(24, 75);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 35;
            label1.Text = "Username*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Bisque;
            label2.Location = new Point(178, 42);
            label2.Name = "label2";
            label2.Size = new Size(263, 46);
            label2.TabIndex = 34;
            label2.Text = "Create Account";
            // 
            // Submitbtn
            // 
            Submitbtn.BackColor = Color.Honeydew;
            Submitbtn.Cursor = Cursors.Hand;
            Submitbtn.Font = new Font("Segoe UI", 10.2F);
            Submitbtn.ForeColor = Color.DarkGreen;
            Submitbtn.Location = new Point(468, 810);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(120, 56);
            Submitbtn.TabIndex = 33;
            Submitbtn.Text = "Create!";
            Submitbtn.UseVisualStyleBackColor = false;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UsernameInput);
            groupBox1.Controls.Add(PasswordInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(32, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 201);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credential";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FemaleRadbtn);
            groupBox2.Controls.Add(MaleRadbtn);
            groupBox2.Controls.Add(LanguageChoice);
            groupBox2.Controls.Add(BirthdayInput);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(LastNameInput);
            groupBox2.Controls.Add(PhoneNumberInput);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(EmailInput);
            groupBox2.Controls.Add(FirstNameInput);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Orange;
            groupBox2.Location = new Point(32, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 469);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // FemaleRadbtn
            // 
            FemaleRadbtn.AutoSize = true;
            FemaleRadbtn.Cursor = Cursors.Hand;
            FemaleRadbtn.Location = new Point(267, 419);
            FemaleRadbtn.Name = "FemaleRadbtn";
            FemaleRadbtn.Size = new Size(95, 32);
            FemaleRadbtn.TabIndex = 49;
            FemaleRadbtn.Text = "Female";
            FemaleRadbtn.UseVisualStyleBackColor = true;
            FemaleRadbtn.CheckedChanged += FemaleRadbtn_CheckedChanged;
            // 
            // MaleRadbtn
            // 
            MaleRadbtn.AutoSize = true;
            MaleRadbtn.Checked = true;
            MaleRadbtn.Cursor = Cursors.Hand;
            MaleRadbtn.Location = new Point(177, 419);
            MaleRadbtn.Name = "MaleRadbtn";
            MaleRadbtn.Size = new Size(76, 32);
            MaleRadbtn.TabIndex = 48;
            MaleRadbtn.TabStop = true;
            MaleRadbtn.Text = "Male";
            MaleRadbtn.UseVisualStyleBackColor = true;
            MaleRadbtn.CheckedChanged += MaleRadbtn_CheckedChanged;
            // 
            // LanguageChoice
            // 
            LanguageChoice.FormattingEnabled = true;
            LanguageChoice.Items.AddRange(new object[] { "vi", "en" });
            LanguageChoice.Location = new Point(177, 366);
            LanguageChoice.Name = "LanguageChoice";
            LanguageChoice.Size = new Size(323, 36);
            LanguageChoice.TabIndex = 47;
            LanguageChoice.Text = "vi ";
            // 
            // BirthdayInput
            // 
            BirthdayInput.Location = new Point(177, 308);
            BirthdayInput.Name = "BirthdayInput";
            BirthdayInput.Size = new Size(323, 34);
            BirthdayInput.TabIndex = 46;
            BirthdayInput.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Bisque;
            label11.Location = new Point(21, 421);
            label11.Name = "label11";
            label11.Size = new Size(50, 28);
            label11.TabIndex = 45;
            label11.Text = "Sex*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Bisque;
            label10.Location = new Point(21, 369);
            label10.Name = "label10";
            label10.Size = new Size(105, 28);
            label10.TabIndex = 44;
            label10.Text = "Language*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Bisque;
            label9.Location = new Point(24, 313);
            label9.Name = "label9";
            label9.Size = new Size(93, 28);
            label9.TabIndex = 43;
            label9.Text = "Birthday*";
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(177, 192);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(323, 34);
            LastNameInput.TabIndex = 41;
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.Location = new Point(177, 251);
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(323, 34);
            PhoneNumberInput.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Bisque;
            label7.Location = new Point(24, 195);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 39;
            label7.Text = "Lastname*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Bisque;
            label8.Location = new Point(24, 254);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 40;
            label8.Text = "Phone*";
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(177, 72);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(323, 34);
            EmailInput.TabIndex = 37;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(177, 131);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(323, 34);
            FirstNameInput.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Bisque;
            label4.Location = new Point(24, 75);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 35;
            label4.Text = "Email*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Bisque;
            label5.Location = new Point(24, 134);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 36;
            label5.Text = "Firstname*";
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.Honeydew;
            Clearbtn.Cursor = Cursors.Hand;
            Clearbtn.Font = new Font("Segoe UI", 10.2F);
            Clearbtn.ForeColor = Color.DarkGreen;
            Clearbtn.Location = new Point(342, 810);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(120, 56);
            Clearbtn.TabIndex = 42;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // BAI07CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(600, 878);
            Controls.Add(Clearbtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(Submitbtn);
            Name = "BAI07CreateAccount";
            Text = "BAI07CreateAccount";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button Submitbtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private TextBox LastNameInput;
        private TextBox PhoneNumberInput;
        private Label label7;
        private Label label8;
        private TextBox EmailInput;
        private TextBox FirstNameInput;
        private Label label4;
        private Label label5;
        private ComboBox LanguageChoice;
        private DateTimePicker BirthdayInput;
        private Label label11;
        private RadioButton FemaleRadbtn;
        private RadioButton MaleRadbtn;
        private Button Clearbtn;
    }
}