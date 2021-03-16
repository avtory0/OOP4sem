using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
        }

        bool nwOper = true;
        int op = -1;

       

        private void button8_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e) //sin
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
            nwOper = true;
            op = -1;
        }

        private void button13_Click(object sender, EventArgs e) //cos
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();
            nwOper = true;
            op = -1;
        }
        private void button14_Click(object sender, EventArgs e) //tan
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
            nwOper = true;
            op = -1;
        }
        private void button15_Click(object sender, EventArgs e) //ctg
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = (1/Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();
            nwOper = true;
            op = -1;
        }

        private void button16_Click(object sender, EventArgs e) //sqrt
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
            nwOper = true;
            op = -1;
        }

        private void button17_Click(object sender, EventArgs e) //cbrt
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Pow((Convert.ToDouble(textBox1.Text)),1.0/3.0).ToString();
            nwOper = true;
            op = -1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = ((Convert.ToDouble(textBox1.Text)) * Convert.ToDouble(textBox1.Text)).ToString();
            nwOper = true;
            op = -1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") == -1) textBox1.Text += ',';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
    }
}
