
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAI07));
            this.DatePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LabelZodiac = new System.Windows.Forms.Label();
            this.TextBoxZodiacSign = new System.Windows.Forms.TextBox();
            this.PictureZodiacSign = new System.Windows.Forms.PictureBox();
            this.ImageListZodiacSign = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiacSign)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickerBirthDay
            // 
            this.DatePickerBirthDay.CustomFormat = "dd MM yyyy";
            this.DatePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerBirthDay.Location = new System.Drawing.Point(129, 109);
            this.DatePickerBirthDay.Name = "DatePickerBirthDay";
            this.DatePickerBirthDay.Size = new System.Drawing.Size(200, 20);
            this.DatePickerBirthDay.TabIndex = 0;
            this.DatePickerBirthDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.DatePickerBirthDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatePickerBirthDay_KeyDown);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(176, 9);
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
            // PictureZodiacSign
            // 
            this.PictureZodiacSign.Location = new System.Drawing.Point(37, 205);
            this.PictureZodiacSign.Name = "PictureZodiacSign";
            this.PictureZodiacSign.Size = new System.Drawing.Size(388, 274);
            this.PictureZodiacSign.TabIndex = 4;
            this.PictureZodiacSign.TabStop = false;
            this.PictureZodiacSign.Click += new System.EventHandler(this.PictureZodiacSign_Click);
            // 
            // ImageListZodiacSign
            // 
            this.ImageListZodiacSign.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListZodiacSign.ImageStream")));
            this.ImageListZodiacSign.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListZodiacSign.Images.SetKeyName(0, "0.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(1, "1.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(2, "2.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(3, "3.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(4, "4.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(5, "5.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(6, "6.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(7, "7.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(8, "8.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(9, "9.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(10, "10.jpg");
            this.ImageListZodiacSign.Images.SetKeyName(11, "11.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hãy chọn ngày sinh của bạn";
            // 
            // BAI07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureZodiacSign);
            this.Controls.Add(this.TextBoxZodiacSign);
            this.Controls.Add(this.LabelZodiac);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.DatePickerBirthDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BAI07";
            this.Text = "BAI07";
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiacSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePickerBirthDay;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label LabelZodiac;
        private System.Windows.Forms.TextBox TextBoxZodiacSign;
        private System.Windows.Forms.PictureBox PictureZodiacSign;
        private System.Windows.Forms.ImageList ImageListZodiacSign;
        private System.Windows.Forms.Label label1;
    }
}