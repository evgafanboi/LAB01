
namespace BTTH1
{
    partial class BAI07
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
            this.DatePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LabelZodiac = new System.Windows.Forms.Label();
            this.TextBoxZodiacSign = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickerBirthDay
            // 
            this.DatePickerBirthDay.CustomFormat = "dd MM yyyy";
            this.DatePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerBirthDay.Location = new System.Drawing.Point(98, 72);
            this.DatePickerBirthDay.Name = "DatePickerBirthDay";
            this.DatePickerBirthDay.Size = new System.Drawing.Size(200, 20);
            this.DatePickerBirthDay.TabIndex = 0;
            this.DatePickerBirthDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(139, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(119, 42);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Bai07";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // LabelZodiac
            // 
            this.LabelZodiac.AutoSize = true;
            this.LabelZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelZodiac.Location = new System.Drawing.Point(33, 154);
            this.LabelZodiac.Name = "LabelZodiac";
            this.LabelZodiac.Size = new System.Drawing.Size(208, 20);
            this.LabelZodiac.TabIndex = 2;
            this.LabelZodiac.Text = "Cung hoàng đạo của bạn là:";
            this.LabelZodiac.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxZodiacSign
            // 
            this.TextBoxZodiacSign.Location = new System.Drawing.Point(272, 154);
            this.TextBoxZodiacSign.Name = "TextBoxZodiacSign";
            this.TextBoxZodiacSign.ReadOnly = true;
            this.TextBoxZodiacSign.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZodiacSign.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 187);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BAI07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxZodiacSign);
            this.Controls.Add(this.LabelZodiac);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.DatePickerBirthDay);
            this.Name = "BAI07";
            this.Text = "BAI07";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePickerBirthDay;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label LabelZodiac;
        private System.Windows.Forms.TextBox TextBoxZodiacSign;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}