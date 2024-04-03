using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public enum Operator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }
        public class Operation
        {
            double[] operands; //numeric array storing operands of each operation
            Operator[] ops; //an enum type that stores operator type
            int[] prt;    //priority in an operation: in the calculation loop, sub-operations of higher priority is executed first, such as those in "()" or "\*"

            public Operation(int num)
            {
                operands = new double[num];
                ops = new Operator[num];
                prt = new int[num];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\HP\\LAB01\\BTTH2\\input3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> lines = new List<string>();
            int length = 0;
            while (sr.ReadLine() != null)
            {
                length++;
                lines.Add(sr.ReadLine());
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
