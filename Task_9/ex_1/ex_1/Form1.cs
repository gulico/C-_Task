using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  

namespace ex_1
{
    public partial class Form1 : Form
    {
        System.IO.FileInfo file;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file = new System.IO.FileInfo(ofd.FileName);
                //其他代码
                label6.Text = ofd.FileName;
                button2.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             label7.Text = file.CreationTime.ToString();
             label8.Text = file.DirectoryName;
             DirectoryInfo directoryInfo = new DirectoryInfo(file.DirectoryName);
             label9.Text = directoryInfo.Root.ToString();
             label10.Text = file.Extension;
        }
    }
}
