namespace BTTH1
{
    partial class BAI09
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
            this.foodListTextBox = new System.Windows.Forms.RichTextBox();
            this.foodtextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodListTextBox
            // 
            this.foodListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.foodListTextBox.Location = new System.Drawing.Point(534, 26);
            this.foodListTextBox.Name = "foodListTextBox";
            this.foodListTextBox.Size = new System.Drawing.Size(241, 323);
            this.foodListTextBox.TabIndex = 0;
            this.foodListTextBox.Text = "";
            // 
            // foodtextBox
            // 
            this.foodtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.foodtextBox.Location = new System.Drawing.Point(33, 82);
            this.foodtextBox.Name = "foodtextBox";
            this.foodtextBox.Size = new System.Drawing.Size(240, 65);
            this.foodtextBox.TabIndex = 1;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.addbutton.Location = new System.Drawing.Point(295, 82);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(154, 100);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(534, 355);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(241, 71);
            this.removebutton.TabIndex = 3;
            this.removebutton.Text = "REMOVE";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(85, 346);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(118, 71);
            this.findbutton.TabIndex = 4;
            this.findbutton.Text = "FIND";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // resulttextBox
            // 
            this.resulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.resulttextBox.Location = new System.Drawing.Point(279, 299);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(220, 50);
            this.resulttextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "VUI LÒNG NHẬP MÓN ĂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(28, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "HÔM NAY ĂN MÓN: ";
            // 
            // BAI09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.foodtextBox);
            this.Controls.Add(this.foodListTextBox);
            this.Name = "BAI09";
            this.Text = "BAI09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox foodListTextBox;
        private System.Windows.Forms.TextBox foodtextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}