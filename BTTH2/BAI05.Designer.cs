namespace BTTH2
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
            this.get_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // filmComboBox
            // 
            this.filmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.filmComboBox.ItemHeight = 31;
            this.filmComboBox.Location = new System.Drawing.Point(27, 134);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(240, 39);
            this.filmComboBox.TabIndex = 0;
            this.filmComboBox.SelectedIndexChanged += new System.EventHandler(this.filmComboBox_SelectedIndexChanged);
            // 
            // roomcomboBox
            // 
            this.roomcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.roomcomboBox.FormattingEnabled = true;
            this.roomcomboBox.ItemHeight = 31;
            this.roomcomboBox.Location = new System.Drawing.Point(27, 209);
            this.roomcomboBox.Name = "roomcomboBox";
            this.roomcomboBox.Size = new System.Drawing.Size(240, 39);
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
            this.compute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.compute_button.Location = new System.Drawing.Point(423, 314);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(225, 73);
            this.compute_button.TabIndex = 6;
            this.compute_button.Text = "XUẤT DỮ LIỆU";
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
            this.checkedListBox1.Location = new System.Drawing.Point(281, 112);
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
            this.checkedListBox2.Location = new System.Drawing.Point(377, 112);
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
            this.checkedListBox4.Location = new System.Drawing.Point(569, 112);
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
            this.checkedListBox3.Location = new System.Drawing.Point(473, 112);
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
            this.checkedListBox5.Location = new System.Drawing.Point(665, 112);
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
            // get_button
            // 
            this.get_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.get_button.Location = new System.Drawing.Point(411, 33);
            this.get_button.Name = "get_button";
            this.get_button.Size = new System.Drawing.Size(237, 45);
            this.get_button.TabIndex = 16;
            this.get_button.Text = "LẤY DỮ LIỆU";
            this.get_button.UseVisualStyleBackColor = true;
            this.get_button.Click += new System.EventHandler(this.get_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(802, 49);
            this.progressBar1.TabIndex = 17;
            // 
            // BAI05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 479);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.get_button);
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
        private System.Windows.Forms.Button get_button;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}