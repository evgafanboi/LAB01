namespace LAB04
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
            label1 = new Label();
            Browsebtn = new Button();
            URLBox = new TextBox();
            OutputBox = new RichTextBox();
            DirectoryBox = new TextBox();
            Exitbtn = new Button();
            Downloadbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(339, 23);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "BÀI 02";
            // 
            // Browsebtn
            // 
            Browsebtn.Location = new Point(613, 95);
            Browsebtn.Name = "Browsebtn";
            Browsebtn.Size = new Size(105, 27);
            Browsebtn.TabIndex = 1;
            Browsebtn.Text = "Browse";
            Browsebtn.UseVisualStyleBackColor = true;
            Browsebtn.Click += Browsebtn_Click;
            // 
            // URLBox
            // 
            URLBox.Location = new Point(40, 95);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(543, 27);
            URLBox.TabIndex = 2;
            // 
            // OutputBox
            // 
            OutputBox.BackColor = Color.Bisque;
            OutputBox.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputBox.Location = new Point(40, 198);
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.Size = new Size(678, 240);
            OutputBox.TabIndex = 3;
            OutputBox.Text = "";
            // 
            // DirectoryBox
            // 
            DirectoryBox.Location = new Point(40, 148);
            DirectoryBox.Name = "DirectoryBox";
            DirectoryBox.Size = new Size(543, 27);
            DirectoryBox.TabIndex = 4;
            // 
            // Exitbtn
            // 
            Exitbtn.Location = new Point(40, 451);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(105, 27);
            Exitbtn.TabIndex = 5;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // Downloadbtn
            // 
            Downloadbtn.Location = new Point(613, 148);
            Downloadbtn.Name = "Downloadbtn";
            Downloadbtn.Size = new Size(105, 27);
            Downloadbtn.TabIndex = 6;
            Downloadbtn.Text = "Download";
            Downloadbtn.UseVisualStyleBackColor = true;
            Downloadbtn.Click += Downloadbtn_Click;
            // 
            // BAI02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(757, 490);
            Controls.Add(Downloadbtn);
            Controls.Add(Exitbtn);
            Controls.Add(DirectoryBox);
            Controls.Add(OutputBox);
            Controls.Add(URLBox);
            Controls.Add(Browsebtn);
            Controls.Add(label1);
            Name = "BAI02";
            Text = "BAI02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Browsebtn;
        private TextBox URLBox;
        private RichTextBox OutputBox;
        private TextBox DirectoryBox;
        private Button Exitbtn;
        private Button Downloadbtn;
    }
}