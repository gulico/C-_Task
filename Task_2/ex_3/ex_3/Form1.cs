using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex_3
{
    public partial class Form1 : Form
    {
        float fontSize;
        int colorflag = 1;
        public Form1()
        {
            InitializeComponent();
            fontSize = this.label2.Font.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.label2.Font.Size < 11) {
                this.label2.Font = new Font("宋体", fontSize+=1);
                this.button3.Enabled = true;
            }

            if (this.label2.Font.Size ==11)
            {
                this.button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.label2.Font.Size > 9)
            {
                this.label2.Font = new Font("宋体", fontSize-=1);
                this.button2.Enabled = true;
            }
            if (this.label2.Font.Size == 9) {
                this.button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorflag == 1)
            {
                this.label2.ForeColor = Color.Red;
                colorflag = 0;
            }
            else
            {
                colorflag = 1;
                this.label2.ForeColor = Color.Black;
            }
        }
    }
}
