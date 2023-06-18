using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /***/
        float x=0, y=0;
        string jam, tafrigh, zarb, taqsim;
        /***/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            label1.Text = x.ToString();
            label5.Text = "+";
            textBox1.Text = "";
            jam = "a";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            label1.Text = x.ToString();
            label5.Text = "-";
            textBox1.Text = "";
            tafrigh = "a";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            label1.Text = x.ToString();
            label5.Text = "*";
            textBox1.Text = "";
            zarb = "a";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            label1.Text = x.ToString();
            label5.Text = "/";
            textBox1.Text = "";
            taqsim = "a";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Enabled == true)
            {
                textBox1.Text += ".";
                button15.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (taqsim == "a")
            {
                y = float.Parse(textBox1.Text);
                label2.Text = y.ToString();
                textBox1.Text = (x / y).ToString();
                button15.Enabled = false;
                button16.Enabled = false;
            }

            else if (zarb == "a")
            {
                y = float.Parse(textBox1.Text);
                label2.Text = y.ToString();
                textBox1.Text = (x * y).ToString();
                button15.Enabled = false;
                button16.Enabled = false;
            }

            else if (jam == "a")
            {
                y = float.Parse(textBox1.Text);
                label2.Text = y.ToString();
                textBox1.Text = (x + y).ToString();
                button15.Enabled = false;
                button16.Enabled = false;
            }

            else if (tafrigh == "a")
            {
                y = float.Parse(textBox1.Text);
                label2.Text = y.ToString();
                textBox1.Text = (x / y).ToString();
                button15.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ساخته شده توسط عرفان شالی کار ، حسین رضوانی ، شاهین بابایی");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            x = 0;
            y = 0;
            jam = "n";
            tafrigh = "n";
            zarb = "n";
            taqsim = "n";
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            label5.Text = "عملگر";
            label1.Text = "0";
            label2.Text = "0";
        }


    }
}
