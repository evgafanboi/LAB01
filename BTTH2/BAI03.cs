using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH2
{
    public partial class BAI03 : Form
    {
        public BAI03()
        {
            InitializeComponent();
        }
        public double Process(string raw)
        {
            if (Parse(raw) != -1)
                return Calculate(raw);
            else
                return double.NaN;  //loi do sai dau ngoac
        }
        public int Parse(string raw)   //chuan hoa chuoi input
        {
            raw.Replace(" ", "");
            Stack<char> st = new Stack<char>();
            foreach (char c in raw)
            {
                if (c == '(')
                    st.Push(c);
                else if (c == ')')
                {
                    if (st.Count == 0)  //thieu dau ngoac don mo
                    {
                        MessageBox.Show("Dấu ngoặc đơn sai quy cách\n Thiếu ngoặc mở", "Error", MessageBoxButtons.OK);
                        return -1;
                    }
                    else
                        st.Pop();

                }
            }
            if (st.Count > 0)   //thieu dau ngoac don dong
            {
                MessageBox.Show("Dấu ngoặc đơn sai quy cách\n Thiếu ngoặc đóng", "Error", MessageBoxButtons.OK);
                return -1;
            }
            return 1;
        }
        public double Calculate(string raw)         //tinh toan chinh
        {
            if (raw.Length == 1 && double.TryParse(raw, out double num)) //neu chi la mot so le, tra ve result
                return num;

            for (int i=0; i<raw.Length; i ++)
            {
                if (raw[i] == '(')  
                {
                    int closebracketindex = FindMatchingBracket(raw[i], raw, i); //tim vi tri ngoac dong
                    string InBracket = raw.Substring(i+1, closebracketindex-i-1);  //tao sub string la phep toan trong ngoac
                    double prioritized_res = Calculate(InBracket);   //de quy tim uu tien ra ket qua cua phep toan trong ngoac truoc, tra ve ket qua
                    raw = raw.Remove(i, closebracketindex - i +1).Insert(i, prioritized_res.ToString());    //ket qua nay thay the toan bo phep toan trong ngoac tro thanh mot toan hang thuong 
                }
            }
            //tai buoc nay, cac dau ngoac don da duoc xy ly hoan toan (ke ca khi dang de quy). Do vay ta tiep tuc uu tien phep nhan chia bang cach tach chuoi raw ra cac phan boi dau '+' va '-'
            string[] subraw = raw.Split('+', '-');
            double result = NhanChia(subraw[0]);    //nhan chia ve dau truoc (neu co) va dua vao ketqua
            //cong hoac tru cac "subraw"(phep nhan chia)
            for (int i=1; i < subraw.Length; i++)
            {
                char op = (raw[raw.IndexOf(subraw[i]) - 1]);
                if (op == '+')
                    result += NhanChia(subraw[i]);
                else if (op == '-')
                    result -= Math.Abs(NhanChia(subraw[i]));
            }

            return result;
        }

        public double NhanChia(string subraw)
        {
            double result;
            if (double.TryParse(subraw, out result))    //base case: neu chi la 1 toan hang
                return result;
            else
            {
                string[] Operands = subraw.Split('*', '/'); //neu tach chuoi nhan chia boi phep toan, ta nhan duoc cac chuoi con cung chinh la cac toan hang. ("4.2*3.6") -> ("4.2"; "3.6")
                result = NhanChia(Operands[0]); //ta biet chac Operands[0] chi don thuan la 1 toan hang, viec de quy chac chan se tra ve double ga cho result
                for(int i=1; i<Operands.Length;i++)
                {
                    char op = (subraw[subraw.IndexOf(Operands[i]) - 1]); //dung indexof de lay vi tri cua toan hang sau do tren chuoi ban dau, -1 de lay duoc phep toan
                    if (op == '*')
                        result *= NhanChia(Operands[i]);    //nhan voi toan hang lien ke
                    else if (op == '/')
                    {
                        if (NhanChia(Operands[i]) == 0)
                            throw new DivideByZeroException("Chia cho 0!");
                        else 
                            result /= NhanChia(Operands[i]);
                    }
                }
                return result;
            }
        }


        private void button1_Click(object sender, EventArgs e)  //Doc file
        {
            FileStream fs = new FileStream("..\\input3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)  //Tinh toan va ghi file
        {
            StringReader sr = new StringReader(richTextBox1.Text);
            using (StreamWriter sw = new StreamWriter("..\\output3.txt", append: false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double res = Process(line);
                    sw.WriteLine(line + $" =  {res}");
                }
            }
            FileStream fs = new FileStream("..\\output3.txt", FileMode.Open);
            StreamReader output = new StreamReader(fs);
            richTextBox1.Text = output.ReadToEnd();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int FindMatchingBracket(char c, string s, int start)       //tim vi tri dau ngoac don dong
        {
            int count = 1;
            int i = start+1;
            for (; count > 0; i++)
            {
                if (s[i] == '(')
                    count++;
                else if (s[i] == ')')
                {
                    count--;
                }
                if (count == 0)
                    return i;
            }
            return -1;
        }
    }
}
