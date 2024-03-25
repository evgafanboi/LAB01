using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BTTH1
{
    public partial class BAI04 : Form
    {
        public BAI04()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string DemSo(long inp)
        {
            string oup = "";
            bool negative = false;  //tim dau
            if (inp < 0)
            {
                negative = true;
                inp *= -1;
            }

            int len = inp.ToString().Length;    //length of input long integer
            string so = inp.ToString();     //long in string type
            //main stuff starts here
            if (inp < 10 && inp > -10)
            {
                if (negative)
                {
                    oup += "Âm ";
                    oup += DocSo(so[0] - '0', false);
                }
                else
                    oup = DocSo(so[0] - '0', true);
            }
            else if (inp < 20 && inp > -20)
            {
                if (negative)
                {
                    oup += "Âm mười ";
                    oup += DocSo(so[1] - '0', false);
                }
                else
                {
                    oup += "Mười ";
                    oup += DocSo(so[1] - '0', false);
                }
            }
            else
            {
                int pos = len - 1; //tra vi tri cua chu so de them cac phu am
                if (negative)
                {
                    oup += "Âm ";
                    oup += DocSo(so[0] - '0', false);
                }
                else
                    oup += DocSo(so[0] - '0', true);
                for (int i = 1; i < len; i++)
                {
                    if (pos % 3 == 1)
                    {  //pos tai vi tri gia tri hang chuc

                        oup += " mươi ";
                        if (so[i] - '0' == 1)
                        { //special case xxxxx1.xxx -> doc thanh xx mươi mốt 
                            oup += "mốt";
                            pos--;
                            continue;
                        }
                    }
                    else if (pos % 3 == 2)
                    {  //pos tai vi tri gia tri tram
                        oup += " trăm ";
                        if (so[i] - '0' == 0 && so[i + 1] - '0' != 0)
                        {
                            oup += "lẻ ";
                            oup += DocSo(so[i + 1] - '0', false);
                            i++;
                            pos -= 2;
                            continue;
                        }
                        else if (so[i] - '0' == 0 && so[i + 1] - '0' == 0)
                        {
                            i++;
                            pos -= 2;
                            continue;
                        }
                        else if (so[i] - '0' == 1)
                        { //special case xxxx1x -> doc thanh mười xx 
                            if (so[i+1] - '0' == 5)   //15 -> muoi lam do tieng viet qua lo?
                            {
                                oup += "mười lăm";
                                i++;   //skip gia tri
                                pos -= 2;
                                continue;
                            }
                            oup += "mười " + DocSo(so[i + 1] - '0', false);
                            i++;   //skip gia tri
                            pos -= 2;
                            continue;
                        }
                    }
                    else if (pos % 9 == 3)  //pos tai vi tri gia tri ngan
                    {
                        int tmp = pos;
                        oup += " ngàn ";
                        while (tmp > 0 && so[tmp - 3] - '0' == 0)
                        {
                            oup += "tỉ ";
                            tmp -= 9;
                        }
                        if (so[i] - '0' == 0)
                        {
                            oup += "không";
                            pos--;
                            continue;
                        }
                    }
                    else if (pos % 9 == 6)  //pos tai vi tri gia tri trieu
                    {
                        int tmp = pos;
                        oup += " triệu ";
                        while (tmp > 0 && so[tmp - 6] - '0' == 0)
                        {
                            oup += "tỉ ";
                            tmp -= 9;
                        }
                        int rem = (int)Math.Abs(inp % Math.Pow(10, pos));    //xu ly truong hop lmao nhu x0000xx
                        if (rem < 1000)
                        {
                            i = len - 3;
                            pos = 2;
                            if (so[i] == '0')
                            {
                                oup += "không";
                                continue;
                            }
                            oup += DocSo(so[i] - '0', false);
                            continue;
                        }
                        if (so[i] - '0' == 0)
                        {
                            oup += "không";
                            pos--;
                            continue;
                        }
                    }
                    else if (pos % 9 == 0 && pos != 0)  //pos tai vi tri gia tri ti
                    {
                        int tmp = pos;
                        oup += " tỉ ";
                        while (tmp > 9 && so[tmp - 9] - '0' == 0)
                        {
                            oup += "tỉ ";
                            tmp -= 9;
                        }
                        int rem = (int)Math.Abs(inp % Math.Pow(10, pos));    //xu ly truong hop lmao nhu x0000000xx
                        if (rem < 1000)
                        {
                            i = len - 3;
                            pos = 2;
                            if (so[i] == '0')
                            {
                                oup += "không";
                                continue;
                            }
                            oup += DocSo(so[i] - '0', false);
                            continue;
                        }
                        else if (rem >=1000 || rem < 1000000)
                        {
                            i = len - 6;
                            pos = 5;
                            if (so[i] == '0')
                            {
                                oup += "không";
                                continue;
                            }
                            oup += DocSo(so[i] - '0', false);
                            continue;
                        }
                        //beta test 
                        if (so[i] - '0' == 0)
                        {
                            oup += "không";
                            pos--;
                            continue;
                        }
                    }

                    oup += DocSo(so[i] - '0', false);

                    pos--;
                }
            }

            //function xu ly so am va hoan thien

            return oup;
        }

        private string DocSo(int inp, bool chudau)  //ham dem chu so, tra ve string, chudau = 1 neu la chu so dau
        {
            string res;
            if (!chudau)
            {
                switch (inp)    //cac chu so - in thuong
                {
                    case 0:
                        res = "";
                        break;
                    case 1:
                        res = "một";
                        break;
                    case 2:
                        res = "hai";
                        break;
                    case 3:
                        res = "ba";
                        break;
                    case 4:
                        res = "bốn";
                        break;
                    case 5:
                        res = "năm";
                        break;
                    case 6:
                        res = "sáu";
                        break;
                    case 7:
                        res = "bảy";
                        break;
                    case 8:
                        res = "tám";
                        break;
                    case 9:
                        res = "chín";
                        break;
                    default:
                        res = "x";
                        break;
                }
            }
            else
            {
                switch (inp)    //cac chu so hang cao nhat - in hoa
                {
                    case 0:
                        res = "Không";  //truong hop nay khong bao gio xay ra nhung ma bo di thi tiec...
                        break;
                    case 1:
                        res = "Một";
                        break;
                    case 2:
                        res = "Hai";
                        break;
                    case 3:
                        res = "Ba";
                        break;
                    case 4:
                        res = "Bốn";
                        break;
                    case 5:
                        res = "Năm";
                        break;
                    case 6:
                        res = "Sáu";
                        break;
                    case 7:
                        res = "Bảy";
                        break;
                    case 8:
                        res = "Tám";
                        break;
                    case 9:
                        res = "Chín";
                        break;
                    default:
                        res = "x";
                        break;
                }   //end switch-case in hoa
            }
            return res;
        }

        private void BAI04_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            long inp = 0;
            string oup;
            if (long.TryParse(textBox1.Text, out inp))
            {
                oup = DemSo(inp);
                textBox2.Text = oup;
            }
            else
            {
                MessageBox.Show("Không phải số nguyên!");
                button2_Click_1(sender, e);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
