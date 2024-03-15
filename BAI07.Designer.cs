
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
            // BAI07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 423);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.DatePickerBirthDay);
            this.Name = "BAI07";
            this.Text = "BAI07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePickerBirthDay;
        private System.Windows.Forms.Label MainLabel;
    }
}