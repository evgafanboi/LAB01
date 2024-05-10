namespace LAB04
{
    partial class LAB04
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 81);
            button1.Name = "button1";
            button1.Size = new Size(145, 68);
            button1.TabIndex = 0;
            button1.Text = "Bài 01";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 174);
            button2.Name = "button2";
            button2.Size = new Size(145, 68);
            button2.TabIndex = 1;
            button2.Text = "Bài 02";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(57, 277);
            button3.Name = "button3";
            button3.Size = new Size(145, 68);
            button3.TabIndex = 2;
            button3.Text = "Bài 03";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(447, 81);
            button4.Name = "button4";
            button4.Size = new Size(145, 68);
            button4.TabIndex = 3;
            button4.Text = "Bài 05";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(447, 174);
            button5.Name = "button5";
            button5.Size = new Size(145, 68);
            button5.TabIndex = 4;
            button5.Text = "Bài 06";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(447, 277);
            button6.Name = "button6";
            button6.Size = new Size(145, 68);
            button6.TabIndex = 5;
            button6.Text = "Bài 07";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(248, 174);
            button7.Name = "button7";
            button7.Size = new Size(145, 68);
            button7.TabIndex = 6;
            button7.Text = "Bài 04";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 17);
            label1.Name = "label1";
            label1.Size = new Size(148, 44);
            label1.TabIndex = 7;
            label1.Text = "LAB 04";
            // 
            // button8
            // 
            button8.Location = new Point(248, 277);
            button8.Name = "button8";
            button8.Size = new Size(145, 68);
            button8.TabIndex = 8;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = true;
            // 
            // LAB04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 373);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LAB04";
            Text = "LAB04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Button button8;
    }
}
