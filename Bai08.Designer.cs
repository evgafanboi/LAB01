
namespace BTTH1
{
    partial class Bai08
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LabelBai08 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(351, 120);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Bắt đầu";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(77, 94);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(615, 20);
            this.TextBoxInput.TabIndex = 1;
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(77, 158);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(615, 280);
            this.RichTextBoxOutput.TabIndex = 2;
            this.RichTextBoxOutput.Text = "";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(329, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(119, 42);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Bai08";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // LabelBai08
            // 
            this.LabelBai08.AutoSize = true;
            this.LabelBai08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBai08.Location = new System.Drawing.Point(88, 68);
            this.LabelBai08.Name = "LabelBai08";
            this.LabelBai08.Size = new System.Drawing.Size(293, 16);
            this.LabelBai08.TabIndex = 4;
            this.LabelBai08.Text = "Hãy nhập Tên, điểm được ngăn cách bằng dấu ,";
            this.LabelBai08.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelBai08);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bai08";
            this.Text = "BAI08";
            this.Load += new System.EventHandler(this.Bai08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label LabelBai08;
    }
}