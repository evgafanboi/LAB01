using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH2
{
    public partial class BAI05 : Form
    {

        List<string> checkedSeats;
        Dictionary<string, List<string>> movieroomInfo = new Dictionary<string, List<string>>();
        Dictionary<string, double> ticketPrices = new Dictionary<string, double>();
        Dictionary<List<string>, string> seatCategories = new Dictionary<List<string>, string>()
        {
            {new List<string>() {"A1", "A5", "C1", "C5"}, "Vé vớt"},
            {new List<string>() {"A2", "A3", "A4", "C2", "C3", "C4"}, "Vé thường"},
            {new List<string>() {"B2", "B3", "B4"}, "Vé VIP"},
        };
        public BAI05()
        {
            InitializeComboBoxes();
            InitializeComponent();
        }

        void InitializeComboBoxes()
        {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "input5.txt");

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string movie;
                        double price;
                        string[] rooms;
                        List<string> lst_room;

                        // Loop read lines until the end of the file
                        while ((movie = sr.ReadLine()) != null)
                        {
                            price = double.Parse(sr.ReadLine());
                            rooms = sr.ReadLine().Split(' ');
                            //MessageBox.Show(n.ToString(), movie);
                            
                            // Ensure room is not null
                            if (rooms == null)
                            {
                                MessageBox.Show($"Invalid room data for movie '{movie}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            lst_room = new List<string>();
                            lst_room.AddRange(rooms);

                            ticketPrices.Add(movie, price);
                            movieroomInfo.Add(movie, lst_room);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The file input5.txt does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void BAI05_Load(object sender, EventArgs e){}
        private void filmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            roomcomboBox.Items.Clear();

            string selectedMovie = filmComboBox.SelectedItem as string;
            foreach (var room in movieroomInfo[selectedMovie])
            {
                roomcomboBox.Items.Add($"Phòng chiếu {room}");
            }
        }
        private void get_button_Click(object sender, EventArgs e)
        {
            filmComboBox.Items.Clear();
            roomcomboBox.Items.Clear();
            filmComboBox.Items.AddRange(movieroomInfo.Keys.ToArray());
        }

        private void GetCheckedSeats(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedSeats.Add(checkedListBox.Items[i].ToString());
                }
            }
        }
        private void compute_button_Click(object sender, EventArgs e)
        {
            checkedSeats = new List<string>();
            string name = nametextBox.Text;
            string movie = filmComboBox.SelectedItem as String;
            string room = roomcomboBox.SelectedItem as String;
            GetCheckedSeats(checkedListBox1);
            GetCheckedSeats(checkedListBox2);
            GetCheckedSeats(checkedListBox3);
            GetCheckedSeats(checkedListBox4);
            GetCheckedSeats(checkedListBox5);
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên, cảm ơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(movie) || string.IsNullOrEmpty(room))
            {
                MessageBox.Show("Không có phim nào được chọn!, vui lòng điền đầy đủ thông tin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (checkedSeats.Count < 1)
            {
                MessageBox.Show("Không có chỗ ngồi nào được chọn!, vui lòng điền đầy đủ thông tin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double totalPrice = CalculateTotalPrice();
            //MessageBox.Show($"Họ và tên: {name}\n Tên phim: {movie}\n {room} \n" + $" Ghe da chon:{string.Join(",", checkedSeats)}\n Số vé đã bán {checkedSeats.Count()} \n Số tiền cần phải thanh toán: {totalPrice}", "Kết quả", MessageBoxButtons.OK);


            int ticketsold = checkedSeats.Count();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "output5.txt");
            try
            {
                // Open the file using a FileStream
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Wrap the FileStream in a StreamWriter for easier writing
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        // Write lines to the file
                        writer.WriteLine($"Tên phim: {movie}\nSố vé đã bán: {ticketsold}\nSố lượng vé tồn: {15 - ticketsold}\nTỉ lệ vé bán ra: {(ticketsold * 100) / (15 - ticketsold)}%\nDoanh thu: {totalPrice}");

                    }
                }

                Console.WriteLine("File written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            int totalSteps = 100; // Number of steps to complete the progress
            int currentStep = 0;

            while (currentStep <= totalSteps)
            {
                progressBar1.Value = currentStep;
                currentStep++;
                System.Threading.Thread.Sleep(5); // Adjust the delay as needed
            }
            // writer.WriteLine($"Tên phim: {movie}\nSố vé đã bán: {ticketsold}\nSố lượng vé tồn: {15 - ticketsold}\nTỉ lệ vé bán ra: {(ticketsold * 100) / (15 - ticketsold)}%\nDoanh thu: {totalPrice}");

            MessageBox.Show($"Tên phim: {movie}\nSố vé đã bán: {ticketsold}\nSố lượng vé tồn: {15 - ticketsold}\nTỉ lệ vé bán ra: {(ticketsold * 100) / (15 - ticketsold)}%\nDoanh thu: {totalPrice}","ĐÃ GHI VÀO FILE 'output5.txt' NỘI DUNG:");

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
        private double GetBasePriceForMovie(string movie)
        {
            if (ticketPrices.ContainsKey(movie))
            {
                return ticketPrices[movie];
            }
            return 0;
        }
        private string GetCategoryForSeat(string seat)
        {
            foreach (var category in seatCategories)
            {
                if (category.Key.Contains(seat))
                {
                    return category.Value;
                }
            }
            return null;
        }
        private double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var seat in checkedSeats)
            {
                double basePrice = GetBasePriceForMovie(filmComboBox.SelectedItem as String);
                string category = GetCategoryForSeat(seat);
                double multiplier = GetTicketPriceMultiplier(category);
                totalPrice += basePrice * multiplier;
            }
            return totalPrice;
        }
    }
}
