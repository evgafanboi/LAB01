namespace LAB04
{
    partial class BAI01
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(54, 126);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(648, 629);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(530, 39);
            button1.Name = "button1";
            button1.Size = new Size(172, 71);
            button1.TabIndex = 4;
            button1.Text = "GOGOGO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(54, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 41);
            textBox1.TabIndex = 3;
            // 
            // BAI01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 800);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "BAI01";
            Text = "BAI01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox1;
    }
}