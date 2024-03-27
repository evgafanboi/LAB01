using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH1
{
    public partial class BAI07 : Form
    {
        public BAI07()
        {
            InitializeComponent();
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            switch(CheckZodiacSignCase(DatePickerBirthDay.Value))
            {
                case 0:
                    TextBoxZodiacSign.Text = "Bạch dương";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[0];
                    break;
                case 1:
                    TextBoxZodiacSign.Text = "Kim Ngưu";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[1];
                    break;
                case 2:
                    TextBoxZodiacSign.Text = "Song tử";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[2];
                    break;
                case 3:
                    TextBoxZodiacSign.Text = "Cự giải";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[3];
                    break;
                case 4:
                    TextBoxZodiacSign.Text = "Sư tử";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[4];
                    break;
                case 5:
                    TextBoxZodiacSign.Text = "Xử nữ";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[5];
                    break;
                case 6:
                    TextBoxZodiacSign.Text = "Thiên bình";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[6];
                    break;
                case 7:
                    TextBoxZodiacSign.Text = "Thần nông";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[7];
                    break;
                case 8:
                    TextBoxZodiacSign.Text = "Nhân mã";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[8];
                    break;
                case 9:
                    TextBoxZodiacSign.Text = "Ma kết";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[9];
                    break;
                case 10:
                    TextBoxZodiacSign.Text = "Bảo bình";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[10];
                    break;
                case 11:
                    TextBoxZodiacSign.Text = "Song ngư";
                    PictureZodiacSign.Image = ImageListZodiacSign.Images[11];
                    break;
                case -1:
                    MessageBox.Show("Input không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PictureZodiacSign.Image = null;
                    break;

            }


        }

        private int CheckZodiacSignCase(DateTime x)
        {
            int Year = 1; // non leap year

            if (DateTime.IsLeapYear(x.Year))
                Year = 1584;
            // Set the year to a closest know leap year
            
            DateTime Birthday = new DateTime(Year, x.Month, x.Day); // set year to var Year so I can compare dates easily 

            //Bạch dương
            if(Birthday >= new DateTime(Year,3,21) && Birthday <= new DateTime(Year,4,20))
            //if (Birthday.Day >= 21 && Birthday.Month >= 3 && Birthday.Day <= 20 && Birthday.Month <= 4)
                return 0;
            // Kim Ngưu
            else if(Birthday >= new DateTime(Year,4,21) && Birthday <= new DateTime(Year,5,21))
            //if (Birthday.Day >= 21 && Birthday.Month >= 4 && Birthday.Day <= 21 && Birthday.Month <= 5) look
                return 1;
            // Song tử
            else if (Birthday >= new DateTime(Year, 5, 22) && Birthday <= new DateTime(Year, 6, 21))
                //if (Birthday.Day >= 22 && Birthday.Month >= 5 && Birthday.Day <= 21 && Birthday.Month <= 6)
                return 2;
            // Cự giải
            else if (Birthday >= new DateTime(Year, 6, 22) && Birthday <= new DateTime(Year, 7, 22))
                //else if (Birthday.Day >= 22 && Birthday.Month >= 6 && Birthday.Day <= 22 && Birthday.Month <= 7)
                return 3;
            // Sư tử
            else if (Birthday >= new DateTime(Year, 7, 23) && Birthday <= new DateTime(Year, 8, 22))
                //else if (Birthday.Day >= 23 && Birthday.Month >= 7 && Birthday.Day <= 22 && Birthday.Month <= 8)
                return 4;
            // Xử nữ
            else if (Birthday >= new DateTime(Year, 8, 23) && Birthday <= new DateTime(Year, 9, 23))
                //else if (Birthday.Day >= 23 && Birthday.Month >= 8 && Birthday.Day <= 23 && Birthday.Month <= 9)
                return 5;
            // Thiên bình
            else if (Birthday >= new DateTime(Year, 9, 24) && Birthday <= new DateTime(Year, 10, 23))
                //else if (Birthday.Day >= 24 && Birthday.Month >= 9 && Birthday.Day <= 23 && Birthday.Month <= 10)
                return 6;
            // Thần nông
            else if (Birthday >= new DateTime(Year, 10, 24) && Birthday <= new DateTime(Year, 11, 22))
                //else if (Birthday.Day >= 24 && Birthday.Month >= 10 && Birthday.Day <= 22 && Birthday.Month <= 11)
                return 7;
            // Nhân mã
            else if (Birthday >= new DateTime(Year, 11, 23) && Birthday <= new DateTime(Year, 12, 21))
                //else if (Birthday.Day >= 23 && Birthday.Month >= 11 && Birthday.Day <= 21 && Birthday.Month <= 12)
                return 8;
            // Ma kết
            else if (Birthday >= new DateTime(Year, 12, 22) || Birthday <= new DateTime(Year, 1, 20))
                //else if ((Birthday.Day >= 22 && Birthday.Day <= 31 && Birthday.Month == 12) || (Birthday.Day >= 1 && Birthday.Day <= 20 && Birthday.Month == 1))
                return 9;
            // Bảo bình
            else if (Birthday >= new DateTime(Year, 1, 21) && Birthday <= new DateTime(Year, 2, 19))
                //else if (Birthday.Day >= 21 && Birthday.Month == 1 && Birthday.Day <= 19 && Birthday.Month <= 2)
                return 10;
            // Song ngư
            else if (Birthday >= new DateTime(Year, 2, 20) && Birthday <= new DateTime(Year, 3, 20))
                //else if (Birthday.Day >= 20 && Birthday.Month >= 2 && Birthday.Day <= 20 && Birthday.Month <= 3)
                return 11;
            
            // handle exception
            else
                return -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatePickerBirthDay_KeyDown(object sender, KeyEventArgs e)
        {
            // disable user input to prevent invalid dates
            e.SuppressKeyPress = true;
        }
    }
}
