using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class BAI04 : Form
    {
        public BAI04()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SĐT_Click(object sender, EventArgs e)
        {

        }

        private void BAI04_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream("input4.txt", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                StudentList StudentList = (StudentList)bf.Deserialize(fs);
                fs.Close();

                // display the current chosen student's information
                TextBoxNameRead.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadName();
                TextBoxIDRead.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadID().ToString();
                TextBoxPhoneNumRead.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadPhoneNum();
                TextBoxScore1Read.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadScore(0).ToString();
                TextBoxScore2Read.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadScore(1).ToString();
                TextBoxScore3Read.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).ReadScore(2).ToString();
                TextBoxAvgRead.Text = StudentList.ReadStudent(ComboBoxStudent.SelectedIndex).GetAvgScore().ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi đọc file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxMSSV_TextChanged(object sender, EventArgs e)
        {
            //enable textbox to enter student id
            TextBoxID.Enabled = true;

        }

        private void ButtonWrite_Click(object sender, EventArgs e)
            
        {
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // check input is empty
            if (TextBoxName.Text == "" || TextBoxID.Text == "" || TextBoxPhoneNum.Text == "" || TextBoxScore1.Text == "" || TextBoxScore2.Text == "" || TextBoxScore3.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the input is valid for all scores score must be larger or equal to 0 and smaller or equal to 10
            try
            {
                if (int.Parse(TextBoxScore1.Text) < 0 || int.Parse(TextBoxScore1.Text) > 10 || int.Parse(TextBoxScore2.Text) < 0 || int.Parse(TextBoxScore2.Text) > 10 || int.Parse(TextBoxScore3.Text) < 0 || int.Parse(TextBoxScore3.Text) > 10)
                {
                    MessageBox.Show("Điểm phải trong hệ 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // name must not contain any character that is not a letter or a space
            foreach (char c in TextBoxName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Tên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // first number must be 0 and the phone number must contain only 10 numbers
            if (TextBoxPhoneNum.Text[0] != '0' || TextBoxPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if phone num contains any character that is not a number
            foreach (char c in TextBoxPhoneNum.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Student ID must contain only 8 numbers
            if (TextBoxID.Text.Length != 8)
            {
                MessageBox.Show("Mã số sinh viên phải có 8 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // add student to the list after checking if the input is valid above
            Student InputStudent = new Student(TextBoxName.Text);
            InputStudent.SetID(int.Parse(TextBoxID.Text));
            InputStudent.SetPhoneNum(TextBoxPhoneNum.Text);
            InputStudent.AddScore(float.Parse(TextBoxScore1.Text));
            InputStudent.AddScore(float.Parse(TextBoxScore2.Text));
            InputStudent.AddScore(float.Parse(TextBoxScore3.Text));

            //try to create a filestream to write the student to the file if it exist, otherwise create a new file
            try
            {
                FileStream fs = new FileStream("input4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                StudentList studentList = new StudentList();
                // if the file exist, read the the file using binary formatter

                if (fs.Length != 0)
                {
                    BinaryFormatter Bf = new BinaryFormatter();
                    studentList = (StudentList)Bf.Deserialize(fs);
                }
                    fs.Close();
                

                // create a new list and add the student to the list
                studentList.AddStudent(InputStudent);   
                //serialize the list and write it to the file
                BinaryFormatter bf = new BinaryFormatter();
                //create a new filestream to overwrite the list to the file
                fs = new FileStream("input4.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        bf.Serialize(fs, studentList);
                        fs.Close();

                //clear all read comboboxes 
                ComboBoxStudent.Items.Clear();
                TextBoxOutput.Text = "";

                //print the list to the output textbox
                for (int i = 0; i < studentList.NumberOfStudent(); i++)
                {
                    TextBoxOutput.Text += "Sinh viên " + (i + 1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Tên: " + studentList.ReadStudent(i).ReadName() + "\r\n";
                    TextBoxOutput.Text += "MSSV: " + studentList.ReadStudent(i).ReadID() + "\r\n";
                    TextBoxOutput.Text += "SDT: " + studentList.ReadStudent(i).ReadPhoneNum() + "\r\n";
                    TextBoxOutput.Text += "Điểm 1: " + studentList.ReadStudent(i).ReadScore(0).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 2: " + studentList.ReadStudent(i).ReadScore(1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 3: " + studentList.ReadStudent(i).ReadScore(2).ToString() + "\r\n";
                    //TextBoxOutput.Text += "Average Score: " + studentList.ReadStudent(i).AvgScore().ToString() + "\r\n";
                    TextBoxOutput.Text += "\r\n";
                }

                ButtonCalculateAvg.Enabled = true;
                ButtonAdd.Enabled = false;

                
                
            }
            catch (Exception)
            {
                //show err and return
                MessageBox.Show("Lỗi khi ghi file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           




        }

        private void TextBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {
            // enalbe textbox to enter score 1
            TextBoxScore1.Enabled = true;
        }

        private void TextBoxScore1_TextChanged(object sender, EventArgs e)
        {
            // enable text box to enter score 2
            TextBoxScore2.Enabled = true;
        }

        private void TextBoxScore2_TextChanged(object sender, EventArgs e)
        {
            // enable textbox to enter score 3
            TextBoxScore3.Enabled = true;
        }

        private void TextBoxScore3_TextChanged(object sender, EventArgs e)
        {
            // enable button to calculate average score
            ButtonAdd.Enabled = true;
        }

        private void ButtonCalculateAvg_Click(object sender, EventArgs e)
        {



            // disable the button until user have input all the required fields except for the AvgTextBox
            if (TextBoxName.Text == "" || TextBoxID.Text == "" || TextBoxPhoneNum.Text == "" || TextBoxScore1.Text == "" || TextBoxScore2.Text == "" || TextBoxScore3.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the input is valid for all scores score must be larger or equal to 0 and smaller or equal to 10
            try
            {
                if (int.Parse(TextBoxScore1.Text) < 0 || int.Parse(TextBoxScore1.Text) > 10 || int.Parse(TextBoxScore2.Text) < 0 || int.Parse(TextBoxScore2.Text) > 10 || int.Parse(TextBoxScore3.Text) < 0 || int.Parse(TextBoxScore3.Text) > 10)
                {
                    MessageBox.Show("Điểm phải trong hệ 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // name must not contain any character that is not a letter or a space
            foreach (char c in TextBoxName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Tên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // first number must be 0 and the phone number must contain only 10 numbers
            if (TextBoxPhoneNum.Text[0] != '0' || TextBoxPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if phone num contains any character that is not a number
            foreach (char c in TextBoxPhoneNum.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
             
            



            

            // Student ID must contain only 8 numbers
            if (TextBoxID.Text.Length != 8)
            {
                MessageBox.Show("Mã số sinh viên phải có 8 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // calculate the average score from the 3 scores
            TextBoxAvg.Text = ((float)((int.Parse(TextBoxScore1.Text) + int.Parse(TextBoxScore2.Text) + int.Parse(TextBoxScore3.Text)) / 3)).ToString();



            // write to output4.txt
            Student InputStudent = new Student(TextBoxName.Text);
            InputStudent.SetID(int.Parse(TextBoxID.Text));
            InputStudent.SetPhoneNum(TextBoxPhoneNum.Text);
            InputStudent.AddScore(float.Parse(TextBoxScore1.Text));
            InputStudent.AddScore(float.Parse(TextBoxScore2.Text));
            InputStudent.AddScore(float.Parse(TextBoxScore3.Text));
            InputStudent.SetAvgScore(float.Parse(TextBoxAvg.Text));

            //try to create a filestream to write the student to the file if it exist, otherwise create a new file
            try
            {
                FileStream fs = new FileStream("output4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                StudentList studentList = new StudentList();
                // if the file exist, read the the file using binary formatter

                if (fs.Length != 0)
                {
                    BinaryFormatter Bf = new BinaryFormatter();
                    studentList = (StudentList)Bf.Deserialize(fs);
                }
                fs.Close();


                // create a new list and add the student to the list
                studentList.AddStudent(InputStudent);
                //serialize the list and write it to the file
                BinaryFormatter bf = new BinaryFormatter();
                //create a new filestream to overwrite the list to the file
                fs = new FileStream("output4.txt", FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, studentList);
                fs.Close();

                //clear all read comboboxes 
                ComboBoxStudent.Items.Clear();
                TextBoxOutput.Text = "";

                //print the list to the output textbox
                for (int i = 0; i < studentList.NumberOfStudent(); i++)
                {
                    TextBoxOutput.Text += "Sinh viên " + (i + 1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Tên: " + studentList.ReadStudent(i).ReadName() + "\r\n";
                    TextBoxOutput.Text += "MSSV: " + studentList.ReadStudent(i).ReadID() + "\r\n";
                    TextBoxOutput.Text += "SDT: " + studentList.ReadStudent(i).ReadPhoneNum() + "\r\n";
                    TextBoxOutput.Text += "Điểm 1: " + studentList.ReadStudent(i).ReadScore(0).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 2: " + studentList.ReadStudent(i).ReadScore(1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 3: " + studentList.ReadStudent(i).ReadScore(2).ToString() + "\r\n";
                    TextBoxOutput.Text += "Average Score: " + studentList.ReadStudent(i).GetAvgScore().ToString() + "\r\n";
                    TextBoxOutput.Text += "\r\n";
                }




            }
            catch (Exception)
            {
                //show err and return
                MessageBox.Show("Lỗi khi ghi file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }






             //call read button to read the list and add the student to the combobox
            ButtonRead_Click(sender, e);
            ButtonAdd.Enabled = true;
            ButtonCalculateAvg.Enabled = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //deserialize the student list from the file
            try
            {
                FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                StudentList StudentList = (StudentList)bf.Deserialize(fs);
                fs.Close();

                //remove the student from the list
                StudentList.RemoveStudent(ComboBoxStudent.SelectedIndex);

                //serialize the list and overwrite it to the file
                fs = new FileStream("input4.txt", FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, StudentList);
                fs.Close();

                //clear the combobox and the textboxes
                ComboBoxStudent.Items.Clear();
                TextBoxNameRead.Text = "";
                TextBoxIDRead.Text = "";
                TextBoxPhoneNumRead.Text = "";
                TextBoxScore1Read.Text = "";
                TextBoxScore2Read.Text = "";
                TextBoxScore3Read.Text = "";
                TextBoxAvgRead.Text = "";

                //reset combobox and disable the delete button
                ComboBoxStudent.Enabled = false;
                ComboBoxStudent.Text = "";
                TextBoxOutput.Text = "";

                //then call button read to read the list and add the student to the combobox
                ButtonRead_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi ghi file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxNameRead_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxIDRead_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            //enable textbox to enter phone number
            TextBoxPhoneNum.Enabled = true;
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            //clear 
            ComboBoxStudent.Items.Clear();
            TextBoxOutput.Text = "";

            // try to read the student list from the file
            try
            {
                FileStream fs = new FileStream("output4.txt", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                StudentList StudentList = (StudentList)bf.Deserialize(fs);
                fs.Close();

                //add the student names to combobox with the order
                for (int i = 0; i < StudentList.NumberOfStudent(); i++)
                    ComboBoxStudent.Items.Add((i + 1).ToString() + ". " + StudentList.ReadStudent(i).ReadName());

                //enable the combobox to select student
                ComboBoxStudent.Enabled = true;

                

                //print the list to the output textbox
                for (int i = 0; i < StudentList.NumberOfStudent(); i++)
                {
                    TextBoxOutput.Text += "Sinh viên " + (i + 1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Tên: " + StudentList.ReadStudent(i).ReadName() + "\r\n";
                    TextBoxOutput.Text += "MSSV: " + StudentList.ReadStudent(i).ReadID() + "\r\n";
                    TextBoxOutput.Text += "SDT: " + StudentList.ReadStudent(i).ReadPhoneNum() + "\r\n";
                    TextBoxOutput.Text += "Điểm 1: " + StudentList.ReadStudent(i).ReadScore(0).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 2: " + StudentList.ReadStudent(i).ReadScore(1).ToString() + "\r\n";
                    TextBoxOutput.Text += "Điểm 3: " + StudentList.ReadStudent(i).ReadScore(2).ToString() + "\r\n";
                    TextBoxOutput.Text += "Average Score: " + StudentList.ReadStudent(i).GetAvgScore().ToString() + "\r\n";
                    TextBoxOutput.Text += "\r\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi đọc file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
