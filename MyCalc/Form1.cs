using System.DirectoryServices;

namespace MyCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        string calcTtl;
        long num1;
        long num2;
        string option;
        long result;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (num1 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                MessageBox.Show("Error");
                return;
            }

            else if (num2 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void plsBtn_Click(object sender, EventArgs e)
        {
            num1 = long.Parse(textBox1.Text);
            if (num1 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else if (num2 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else
            {
                option = "+";
                textBox1.Clear();
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            num1 = long.Parse(textBox1.Text);
            if (num1 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else if (num2 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else
            {
                option = "-";
                textBox1.Clear();
            }

        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            num1 = long.Parse(textBox1.Text);
            if (num1 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else if (num2 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else
            {
                option = "*";
                textBox1.Clear();
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            num1 = long.Parse(textBox1.Text);
            if (num1 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else if (num2 > 999999999999999)
            {
                textBox1.Text = "Kebanyakan";
                return;
            }

            else
            {
                option = "/";
                textBox1.Clear();
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            bool detection = long.TryParse(textBox1.Text, out _);

            if (detection == true)
            {
                num2 = long.Parse(textBox1.Text);

                if (result > 999999999999999)
                {
                    textBox1.Text = "Kebanyakan";
                    return;
                }

                else if (option == "+")
                {
                    result = num1 + num2;
                }

                else if (option == "-")
                {
                    result = num1 - num2;
                }

                else if (option == "+")
                {
                    result = num1 + num2;
                }

                else if (option == "/")
                {
                    result = num1 / num2;
                }

                else if (option == "*")
                {
                    result = num1 * num2;
                }




                textBox1.Text = result + "";

                ;
            }
            else
            {
                return;
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}