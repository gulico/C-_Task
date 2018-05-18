using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ex_2
{
    public partial class Form1 : Form
    {
        DriveInfo[] allDrives;
        public Form1()
        {
            InitializeComponent();
            allDrives = DriveInfo.GetDrives();
            for (int i = 0; i < allDrives.Length; i++) {
                listBox1.Items.Add(allDrives[i].Name);
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("驱动器名称："+allDrives[listBox1.SelectedIndex].Name+"\n");
            textBox1.AppendText("文件系统：" + allDrives[listBox1.SelectedIndex].DriveFormat + "\n");
            textBox1.AppendText("驱动类型：" + allDrives[listBox1.SelectedIndex].DriveType + "\n");
            textBox1.AppendText("卷标：" + allDrives[listBox1.SelectedIndex].VolumeLabel + "\n");
            textBox1.AppendText("总容量：" + allDrives[listBox1.SelectedIndex].TotalFreeSpace + "\n");
            textBox1.AppendText("可用容量：" + allDrives[listBox1.SelectedIndex].TotalSize + "\n");
        }
    }
}
