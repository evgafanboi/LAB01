namespace LAB05
{
    partial class BAI01pw
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(160, 107);
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '#';
            this.InputBox.Size = new System.Drawing.Size(237, 22);
            this.InputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your password for the email address:";
            // 
            // Sendbtn
            // 
            this.Sendbtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbtn.ForeColor = System.Drawing.Color.Bisque;
            this.Sendbtn.Location = new System.Drawing.Point(203, 273);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(158, 47);
            this.Sendbtn.TabIndex = 5;
            this.Sendbtn.Text = "OK";
            this.Sendbtn.UseVisualStyleBackColor = false;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your name for the email (optional)";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(160, 220);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(237, 22);
            this.NameBox.TabIndex = 6;
            // 
            // BAI01pw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(562, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Name = "BAI01pw";
            this.Text = "BAI01pw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
    }
}