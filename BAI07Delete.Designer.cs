namespace LAB04
{
    partial class BAI07Delete
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
            label1 = new Label();
            IDInput = new TextBox();
            Deletebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập ID món ăn cần xóa:";
            // 
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDInput.Location = new Point(252, 25);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(125, 30);
            IDInput.TabIndex = 1;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.Red;
            Deletebtn.Location = new Point(119, 66);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(149, 29);
            Deletebtn.TabIndex = 31;
            Deletebtn.Text = "Xóa món ăn ";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // BAI07Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(389, 107);
            Controls.Add(Deletebtn);
            Controls.Add(IDInput);
            Controls.Add(label1);
            ForeColor = Color.Tan;
            Name = "BAI07Delete";
            Text = "BAI07Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IDInput;
        private Button Deletebtn;
    }
}