using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 推出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //工具栏保存
             
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //工具栏复制
            this.richTextBox1.Copy();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单复制
            this.richTextBox1.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //工具栏剪切
            this.richTextBox1.Cut();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单剪切
            this.richTextBox1.Cut();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //工具栏粘贴
            this.richTextBox1.Paste();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单粘贴
            this.richTextBox1.Paste();
        }
    }
}
