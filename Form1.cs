using System.Runtime.InteropServices;

namespace Lab_13
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            output.Text = ("= " + (num1 + num2));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (double.TryParse(add1.Text, out _))
            {
                num1 = double.Parse(add1.Text);
            }
            else
            {
                Console.WriteLine(add1.Text);
                num1 = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(add2.Text, out _))
            {
                num2 = double.Parse(add2.Text);
            }
            else
            {
                num2 = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            output.Text = "= output";
            add1.Text = "";
            add2.Text = "";
        }
    }
}