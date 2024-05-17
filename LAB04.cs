using System.Text;

namespace LAB04
{
    public partial class LAB04 : Form
    {
        public LAB04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new BAI01();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI02 f2 = new BAI02();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAI03 f3 = new BAI03();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f4 = new BAI04();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BAI05 f5 = new BAI05();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BAI06 f6 = new BAI06();
            f6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //BAI07 f7 = new BAI07();
            //f7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
