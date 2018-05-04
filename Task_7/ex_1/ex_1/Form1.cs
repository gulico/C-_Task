using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
                label3.Text = "+";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Text = "-";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label3.Text = "*";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label3.Text = "/";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label3.Text = "mod";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int ans = 0;
            if (radioButton1.Checked) {
                ans = x + y;
            }
            else if (radioButton2.Checked) {
                ans = x - y;
            }
            else if (radioButton4.Checked)
            {
                ans = x * y;
            }
            else if (radioButton3.Checked)
            {
                ans = x / y;
            }
            else if (radioButton5.Checked)
            {
                ans = x % y;
            }
            textBox3.Text = ans+"";
        }


    }
}
