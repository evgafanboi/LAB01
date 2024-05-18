namespace LAB04
{
    partial class BAI07Food
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FoodPictureBox = new PictureBox();
            Contributor = new Label();
            Address = new Label();
            FoodPrice = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FoodPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FoodPictureBox
            // 
            FoodPictureBox.Location = new Point(15, 13);
            FoodPictureBox.Name = "FoodPictureBox";
            FoodPictureBox.Size = new Size(168, 141);
            FoodPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FoodPictureBox.TabIndex = 16;
            FoodPictureBox.TabStop = false;
            // 
            // Contributor
            // 
            Contributor.AutoSize = true;
            Contributor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contributor.ForeColor = Color.DarkSlateGray;
            Contributor.Location = new Point(358, 131);
            Contributor.Name = "Contributor";
            Contributor.Size = new Size(41, 23);
            Contributor.TabIndex = 15;
            Contributor.Text = "N/A";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.ForeColor = Color.DarkSlateGray;
            Address.Location = new Point(358, 97);
            Address.Name = "Address";
            Address.Size = new Size(41, 23);
            Address.TabIndex = 14;
            Address.Text = "N/A";
            // 
            // FoodPrice
            // 
            FoodPrice.AutoSize = true;
            FoodPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodPrice.ForeColor = Color.Maroon;
            FoodPrice.Location = new Point(358, 62);
            FoodPrice.Name = "FoodPrice";
            FoodPrice.Size = new Size(19, 23);
            FoodPrice.TabIndex = 13;
            FoodPrice.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(189, 131);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 12;
            label3.Text = "Đóng góp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(189, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 11;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(189, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 10;
            label1.Text = "Giá:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.DarkSlateGray;
            nameLabel.Location = new Point(189, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(170, 38);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Tên món ăn";
            // 
            // BAI07Food
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(FoodPictureBox);
            Controls.Add(Contributor);
            Controls.Add(Address);
            Controls.Add(FoodPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameLabel);
            Name = "BAI07Food";
            Size = new Size(606, 166);
            ((System.ComponentModel.ISupportInitialize)FoodPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FoodPictureBox;
        private Label Contributor;
        private Label Address;
        private Label FoodPrice;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label nameLabel;
    }
}
