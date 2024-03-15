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
            //switch(CheckZodiacSignCase(DatePickerBirthDay.Value))




        }

        private int CheckZodiacSignCase(DateTime Birthday)
        {

            //Bạch dương
            if (Birthday.Day >= 21 && Birthday.Month >= 3 && Birthday.Day <= 20 && Birthday.Month <= 4)
                return 0;
            // Kim Ngưu
            else if (Birthday.Day >= 21 && Birthday.Month >= 4 && Birthday.Day <= 21 && Birthday.Month <= 5)
                return 1;
            // Song tử
            else if (Birthday.Day >= 22 && Birthday.Month >= 5 && Birthday.Day <= 21 && Birthday.Month <= 6)
                return 2;
            // Cự giải
            else if (Birthday.Day >= 22 && Birthday.Month >= 6 && Birthday.Day <= 22 && Birthday.Month <= 7)
                return 3;
            // Sư tử
            else if (Birthday.Day >= 23 && Birthday.Month >= 7 && Birthday.Day <= 22 && Birthday.Month <= 8)
                return 4;
            // Xử nữ
            else if (Birthday.Day >= 23 && Birthday.Month >= 8 && Birthday.Day <= 23 && Birthday.Month <= 9)
                return 5;
            // Thiên bình
            else if (Birthday.Day >= 24 && Birthday.Month >= 9 && Birthday.Day <= 23 && Birthday.Month <= 10)
                return 6;
            // Thần nông
            else if (Birthday.Day >= 24 && Birthday.Month >= 10 && Birthday.Day <= 22 && Birthday.Month <= 11)
                return 7;
            // Nhân mã
            else if (Birthday.Day >= 23 && Birthday.Month >= 11 && Birthday.Day <= 21 && Birthday.Month <= 12)
                return 8;
            // Ma kết
            else if ((Birthday.Day >= 22 && Birthday.Day <= 31 && Birthday.Month == 12) || (Birthday.Day >= 1 && Birthday.Day <= 20 && Birthday.Month == 1))
                return 9;
            // Bảo bình
            else if (Birthday.Day >= 21 && Birthday.Month == 1 && Birthday.Day <= 19 && Birthday.Month <= 2)
                return 10;
            // Song ngư
            else if (Birthday.Day >= 20 && Birthday.Month >= 2 && Birthday.Day <= 20 && Birthday.Month <= 3)
                return 11;
            
            // handle exception
            else
                return -1;
        }
    }
}
