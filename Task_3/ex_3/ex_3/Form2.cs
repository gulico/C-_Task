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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(TextBox username,TextBox password)
        {
            InitializeComponent();
            this.textBox1.Text = username.Text;
            this.textBox2.Text = password.Text;
            this.textBox1 = username;
            this.textBox2 = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.Close();
        }
    }
}
