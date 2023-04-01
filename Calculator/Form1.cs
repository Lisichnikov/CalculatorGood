namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = "Синус: ";
            label2.Text = "Число: ";
            textBox3.Text = "00000000000000";
            label4.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "Тангенс: ";
            label2.Text = "Число: ";
            textBox3.Text = "00000000000000";
            label4.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = "Косинус: ";
            label2.Text = "Число: ";
            textBox3.Text = "00000000000000";
            label4.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "Первое число: ";
            label2.Text = "Второе число: ";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label4.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (label4.Text == "+")
            {
                textBox1.Text = textBox1.Text + (a + b);
            }
            if (label4.Text == "-")
            {
                textBox1.Text = textBox1.Text + (a - b);
            }
            if (label4.Text == "*")
            {
                textBox1.Text = textBox1.Text + (a * b);
            }
            if (label4.Text == "/")
            {
                textBox1.Text = textBox1.Text + (a / b);
                if (b == 0)
                {
                    textBox1.Text = "Вот скажи, ты дурак?";
                }
            }
            if (label1.Text == "Синус: ")
            {
                textBox1.Text = textBox1.Text + (Math.Sin(b));
            }
            if (label1.Text == "Косинус: ")
            {
                textBox1.Text = textBox1.Text + (Math.Cos(b));
            }
            if (label1.Text == "Тангенс: ")
            {
                textBox1.Text = textBox1.Text + (Math.Tan(b));
            }
            if (label1.Text == "Квадратный корень: ")
            {
                textBox1.Text = textBox1.Text + (Math.Sqrt(b));
            }
            if (label4.Text == "^")
            {
                textBox1.Text = textBox1.Text + (Math.Pow(a, b));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label4.Text = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 7;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 3;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "Число: ";
            label2.Text = "Степень ";
            label4.Text = "^";
            textBox3.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "Квадратный корень: ";
            label2.Text = "Из: ";
            textBox3.Text = "00000000000000";
            label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}