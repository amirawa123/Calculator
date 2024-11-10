using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            value = Double.Parse(textBox1.Text);
            op = button.Text;
            textBox1.Text += op;
        }

        private void number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            double result;
            if (op == "+") {
                result = value + Double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                value = result;
            }
            if (op == "-")
            {
                result = value - Double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                value = result;
            }
            if (op == "*")
            {
                result = value * Double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                value = result;
            }
            if (op == "/")
            {
                result = value / Double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
                value = result;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }
    }
}
