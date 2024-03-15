
namespace BTTH1
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.TextBoxAnswer = new System.Windows.Forms.TextBox();
            this.ButtonGiaiThua = new System.Windows.Forms.RadioButton();
            this.ButtonSum = new System.Windows.Forms.RadioButton();
            this.ButtonBangCuuChuong = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(182, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(119, 42);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Bai06";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(36, 80);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(100, 20);
            this.TextBoxA.TabIndex = 1;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(340, 80);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(100, 20);
            this.TextBoxB.TabIndex = 2;
            this.TextBoxB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giai thừa A-B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bảng cửu chương";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(326, 157);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(114, 49);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Tính";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(76, 51);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(14, 13);
            this.ALabel.TabIndex = 11;
            this.ALabel.Text = "A";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(384, 51);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(14, 13);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "B";
            this.BLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.Location = new System.Drawing.Point(36, 259);
            this.TextBoxAnswer.Multiline = true;
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Size = new System.Drawing.Size(404, 200);
            this.TextBoxAnswer.TabIndex = 14;
            this.TextBoxAnswer.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ButtonGiaiThua
            // 
            this.ButtonGiaiThua.AutoSize = true;
            this.ButtonGiaiThua.Location = new System.Drawing.Point(208, 140);
            this.ButtonGiaiThua.Name = "ButtonGiaiThua";
            this.ButtonGiaiThua.Size = new System.Drawing.Size(14, 13);
            this.ButtonGiaiThua.TabIndex = 16;
            this.ButtonGiaiThua.UseVisualStyleBackColor = true;
            this.ButtonGiaiThua.CheckedChanged += new System.EventHandler(this.ButtonGiaiThua_CheckedChanged);
            this.ButtonGiaiThua.Click += new System.EventHandler(this.ButtonGiaiThua_Click);
            // 
            // ButtonSum
            // 
            this.ButtonSum.AutoSize = true;
            this.ButtonSum.Location = new System.Drawing.Point(208, 175);
            this.ButtonSum.Name = "ButtonSum";
            this.ButtonSum.Size = new System.Drawing.Size(14, 13);
            this.ButtonSum.TabIndex = 17;
            this.ButtonSum.UseVisualStyleBackColor = true;
            this.ButtonSum.CheckedChanged += new System.EventHandler(this.ButtonSum_CheckedChanged);
            // 
            // ButtonBangCuuChuong
            // 
            this.ButtonBangCuuChuong.AutoSize = true;
            this.ButtonBangCuuChuong.Location = new System.Drawing.Point(208, 217);
            this.ButtonBangCuuChuong.Name = "ButtonBangCuuChuong";
            this.ButtonBangCuuChuong.Size = new System.Drawing.Size(14, 13);
            this.ButtonBangCuuChuong.TabIndex = 18;
            this.ButtonBangCuuChuong.UseVisualStyleBackColor = true;
            this.ButtonBangCuuChuong.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BAI06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(476, 483);
            this.Controls.Add(this.ButtonBangCuuChuong);
            this.Controls.Add(this.ButtonSum);
            this.Controls.Add(this.ButtonGiaiThua);
            this.Controls.Add(this.TextBoxAnswer);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.MainLabel);
            this.Name = "BAI06";
            this.Text = "BAI06";
            this.Load += new System.EventHandler(this.BAI06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox TextBoxAnswer;
        private System.Windows.Forms.RadioButton ButtonGiaiThua;
        private System.Windows.Forms.RadioButton ButtonSum;
        private System.Windows.Forms.RadioButton ButtonBangCuuChuong;
    }
}