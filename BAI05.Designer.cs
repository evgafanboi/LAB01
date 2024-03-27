namespace BTTH1
{
    partial class BAI05
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
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.roomcomboBox = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.compute_button = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.nameInputlabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // filmComboBox
            // 
            this.filmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.ItemHeight = 25;
            this.filmComboBox.Location = new System.Drawing.Point(27, 112);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(168, 33);
            this.filmComboBox.TabIndex = 0;
            this.filmComboBox.SelectedIndexChanged += new System.EventHandler(this.filmComboBox_SelectedIndexChanged);
            // 
            // roomcomboBox
            // 
            this.roomcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.roomcomboBox.FormattingEnabled = true;
            this.roomcomboBox.ItemHeight = 25;
            this.roomcomboBox.Location = new System.Drawing.Point(27, 161);
            this.roomcomboBox.Name = "roomcomboBox";
            this.roomcomboBox.Size = new System.Drawing.Size(168, 33);
            this.roomcomboBox.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // compute_button
            // 
            this.compute_button.Location = new System.Drawing.Point(432, 284);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(189, 65);
            this.compute_button.TabIndex = 6;
            this.compute_button.Text = "TÌM";
            this.compute_button.UseVisualStyleBackColor = true;
            this.compute_button.Click += new System.EventHandler(this.compute_button_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nametextBox.Location = new System.Drawing.Point(27, 33);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(208, 35);
            this.nametextBox.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "A1",
            "B1",
            "C1"});
            this.checkedListBox1.Location = new System.Drawing.Point(240, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(98, 148);
            this.checkedListBox1.TabIndex = 10;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "A2",
            "B2",
            "C2"});
            this.checkedListBox2.Location = new System.Drawing.Point(336, 74);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(98, 148);
            this.checkedListBox2.TabIndex = 11;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "A4",
            "B4",
            "C4"});
            this.checkedListBox4.Location = new System.Drawing.Point(528, 74);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(98, 148);
            this.checkedListBox4.TabIndex = 13;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "A3",
            "B3",
            "C3"});
            this.checkedListBox3.Location = new System.Drawing.Point(432, 74);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(98, 148);
            this.checkedListBox3.TabIndex = 12;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new object[] {
            "A5",
            "B5",
            "C5"});
            this.checkedListBox5.Location = new System.Drawing.Point(624, 74);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(98, 148);
            this.checkedListBox5.TabIndex = 14;
            // 
            // nameInputlabel
            // 
            this.nameInputlabel.AutoSize = true;
            this.nameInputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nameInputlabel.Location = new System.Drawing.Point(22, 1);
            this.nameInputlabel.Name = "nameInputlabel";
            this.nameInputlabel.Size = new System.Drawing.Size(191, 29);
            this.nameInputlabel.TabIndex = 15;
            this.nameInputlabel.Text = "Nhập họ và tên:";
            // 
            // BAI05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 431);
            this.Controls.Add(this.nameInputlabel);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.roomcomboBox);
            this.Controls.Add(this.filmComboBox);
            this.Name = "BAI05";
            this.Text = "BAI05";
            this.Load += new System.EventHandler(this.BAI05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filmComboBox;
        private System.Windows.Forms.ComboBox roomcomboBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button compute_button;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.Label nameInputlabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}