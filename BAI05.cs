using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH1
{
    public partial class BAI05 : Form
    {
        List<string> checkedSeats = new List<string>();

        Dictionary<string, List<string>> movieroomInfo = new Dictionary<string, List<string>>()
        {
            {"Đào, phở và piano", new List<string>() {"1", "2", "3"}},
            {"Mai", new List<string>() {"2", "3"}},
            {"Gặp lại chị bầu", new List<string>() {"1"}},
            {"Tarot", new List<string>() {"3"}}
        };

        Dictionary<string, double> ticketPrices = new Dictionary<string, double>()
        {
            {"Đào, phở và piano", 45000},
            {"Mai", 100000},
            {"Gặp lại chị bầu", 70000},
            {"Tarot", 90000}
        };

    
        Dictionary<List<string>, string> seatCategories = new Dictionary<List<string>, string>()
        {
            {new List<string>() {"A1", "A5", "C1", "C5"}, "Vé vớt"},
            {new List<string>() {"A2", "A3", "A4", "C2", "C3", "C4"}, "Vé thường"},
            {new List<string>() {"B2", "B3", "B4"}, "Vé VIP"},
        };
  
        public BAI05()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            // Load film names into ComboBox
            foreach (var filmName in ticketPrices.Keys)
            {
                filmComboBox.Items.Add(filmName);
            }

        }
        private double GetTicketPriceMultiplier(string category)
        {
            if (category == "Vé vớt")
                return 0.25;
            else if (category == "Vé thường")
                return 1;
            else if (category == "Vé VIP")
                return 2;
            else
                return 1;
        }
        private string GetRoomForSeat(string seat)
        {
            // Duyệt qua từng phòng chiếu
            foreach (var room in movieroomInfo)
            {
                // Nếu ghế thuộc phòng chiếu, trả về tên phòng chiếu
                if (room.Value.Contains(seat))
                {
                    return room.Key;
                }
            }

            // Không tìm thấy ghế trong phòng chiếu nào, trả về null
            return null;
        }

        private string GetMovieForRoom(string room)
        {
            // Tìm tên phim dựa trên tên phòng chiếu
            if (movieroomInfo.ContainsKey(room))
            {
                return room;
            }

            // Không tìm thấy phim cho phòng chiếu, trả về null
            return null;
        }

        private double GetBasePriceForMovie(string movie)
        {
            // Lấy giá vé chuẩn của phim
            if (ticketPrices.ContainsKey(movie))
            {
                return ticketPrices[movie];
            }

            // Không tìm thấy giá vé cho phim, trả về 0
            return 0;
        }

        private string GetCategoryForSeat(string seat)
        {
            // Duyệt qua từng loại ghế
            foreach (var category in seatCategories)
            {
                // Nếu ghế thuộc loại ghế, trả về tên loại ghế
                if (category.Key.Contains(seat))
                {
                    return category.Value;
                }
            }

            // Không tìm thấy loại ghế cho ghế, trả về null
            return null;
        }
        private double CalculateTotalPrice()
        {
            double totalPrice = 0;

            // Duyệt qua từng ghế đã chọn
            foreach (var seat in checkedSeats)
            {
                // Lấy giá vé chuẩn của phim
                double basePrice = GetBasePriceForMovie(filmComboBox.SelectedItem as String);

                // Tìm loại vé của ghế
                string category = GetCategoryForSeat(seat);

                // Lấy hệ số giá vé cho loại vé
                double multiplier = GetTicketPriceMultiplier(category);

                // Tính toán giá vé của ghế và cộng vào tổng giá
                totalPrice += basePrice * multiplier;
            }

            return totalPrice;
        }

        private void BAI05_Load(object sender, EventArgs e){}

        private void filmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomcomboBox.SelectedItem = null;
            roomcomboBox.SelectedItem = -1;

            string selectedMovie = filmComboBox.SelectedItem as string;

            foreach (var room in movieroomInfo[selectedMovie])
            {
                roomcomboBox.Items.Add($"Phòng chiếu {room}");
            }
        }


       
        private void GetCheckedSeats(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                if (checkedListBox.GetItemChecked(i))
                {
                    // Lấy tên của mục và thêm vào mảng checkedSeats
                    checkedSeats.Add(checkedListBox.Items[i].ToString());
                }
            }
        }

        private void compute_button_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string movie = filmComboBox.SelectedItem as String;
            string room = roomcomboBox.SelectedItem as String;
            GetCheckedSeats(checkedListBox1);
            GetCheckedSeats(checkedListBox2);
            GetCheckedSeats(checkedListBox3);
            GetCheckedSeats(checkedListBox4);
            GetCheckedSeats(checkedListBox5);
            double totalPrice = CalculateTotalPrice();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên, cảm ơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(movie) && string.IsNullOrEmpty(room))
            {
                MessageBox.Show("Không có phim nào được chọn!, vui lòng điền đầy đủ thông tin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkedSeats.Count < 1)
            {
                MessageBox.Show("Không có chỗ ngồi nào được chọn!, vui lòng điền đầy đủ thông tin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show($"Họ và tên: {name}\n Tên phim: {movie}\n {room} \n" +
                $" Ghe da chon:{string.Join(",", checkedSeats)} \n Số tiền cần phải thanh toán: {totalPrice}", "Kết quả", MessageBoxButtons.OK);
        }
    }
}
