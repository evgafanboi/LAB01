namespace LAB04
{
    partial class BAI07Add
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
            groupBox2 = new GroupBox();
            DescriptionInput = new RichTextBox();
            Data = new GroupBox();
            AddressFood = new TextBox();
            imageURL = new TextBox();
            label4 = new Label();
            label5 = new Label();
            NameInput = new TextBox();
            PriceInput = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            Submitbtn = new Button();
            Clearbtn = new Button();
            groupBox2.SuspendLayout();
            Data.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DescriptionInput);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Orange;
            groupBox2.Location = new Point(46, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 296);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(20, 47);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(488, 222);
            DescriptionInput.TabIndex = 0;
            DescriptionInput.Text = "";
            // 
            // Data
            // 
            Data.Controls.Add(AddressFood);
            Data.Controls.Add(imageURL);
            Data.Controls.Add(label4);
            Data.Controls.Add(label5);
            Data.Controls.Add(NameInput);
            Data.Controls.Add(PriceInput);
            Data.Controls.Add(label1);
            Data.Controls.Add(label3);
            Data.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Data.ForeColor = Color.Orange;
            Data.Location = new Point(46, 94);
            Data.Name = "Data";
            Data.Size = new Size(534, 295);
            Data.TabIndex = 44;
            Data.TabStop = false;
            Data.Text = "Credential";
            // 
            // AddressFood
            // 
            AddressFood.Location = new Point(185, 166);
            AddressFood.Name = "AddressFood";
            AddressFood.Size = new Size(323, 34);
            AddressFood.TabIndex = 41;
            // 
            // imageURL
            // 
            imageURL.Location = new Point(185, 225);
            imageURL.Name = "imageURL";
            imageURL.Size = new Size(323, 34);
            imageURL.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Bisque;
            label4.Location = new Point(32, 169);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 39;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Bisque;
            label5.Location = new Point(32, 228);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 40;
            label5.Text = "Nguồn hình ảnh:";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(185, 53);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(323, 34);
            NameInput.TabIndex = 37;
            // 
            // PriceInput
            // 
            PriceInput.Location = new Point(185, 112);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(323, 34);
            PriceInput.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(32, 56);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 35;
            label1.Text = "Tên món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Bisque;
            label3.Location = new Point(32, 115);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 36;
            label3.Text = "Giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Bisque;
            label2.Location = new Point(218, 33);
            label2.Name = "label2";
            label2.Size = new Size(188, 46);
            label2.TabIndex = 43;
            label2.Text = "Add a dish";
            // 
            // Submitbtn
            // 
            Submitbtn.BackColor = Color.Honeydew;
            Submitbtn.Cursor = Cursors.Hand;
            Submitbtn.Font = new Font("Segoe UI", 10.2F);
            Submitbtn.ForeColor = Color.DarkGreen;
            Submitbtn.Location = new Point(460, 724);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(120, 56);
            Submitbtn.TabIndex = 42;
            Submitbtn.Text = "Submit!";
            Submitbtn.UseVisualStyleBackColor = false;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.Honeydew;
            Clearbtn.Cursor = Cursors.Hand;
            Clearbtn.Font = new Font("Segoe UI", 10.2F);
            Clearbtn.ForeColor = Color.DarkGreen;
            Clearbtn.Location = new Point(334, 724);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(120, 56);
            Clearbtn.TabIndex = 46;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // BAI07Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(616, 802);
            Controls.Add(Clearbtn);
            Controls.Add(groupBox2);
            Controls.Add(Data);
            Controls.Add(label2);
            Controls.Add(Submitbtn);
            Name = "BAI07Add";
            Text = "BAI07Add";
            groupBox2.ResumeLayout(false);
            Data.ResumeLayout(false);
            Data.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox Data;
        private TextBox NameInput;
        private TextBox PriceInput;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button Submitbtn;
        private Button Clearbtn;
        private RichTextBox DescriptionInput;
        private TextBox AddressFood;
        private TextBox imageURL;
        private Label label4;
        private Label label5;
    }
}