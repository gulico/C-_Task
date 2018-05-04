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
        int origin_location_x;
        int origin_location_y;
        int location_x;
        int location_y;

        public enum RunState
        {
            Left_running,
            Right_running,
            stop
        }
        private int i = 0;

        RunState state = RunState.stop;


        public Form1()
        {
            InitializeComponent();
            origin_location_x = label1.Location.X;
            origin_location_y = label1.Location.Y;
            location_x = origin_location_x;
            location_y = origin_location_y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                this.state = RunState.Left_running;
            }
            else if (radioButton2.Checked) {
                this.state = RunState.Right_running;
            }
            while (state!=RunState.stop) {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                if (state == RunState.Left_running)
                {
                    label1.Location = new System.Drawing.Point(location_x++, location_y);
                }
                else if (state == RunState.Right_running)
                {
                    label1.Location = new System.Drawing.Point(location_x, location_y++);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.state = RunState.stop;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                if (state == RunState.stop)
                {
                    label1.Location = new System.Drawing.Point(origin_location_x, origin_location_y);
                    location_x = origin_location_x;
                    location_y = origin_location_y;
                }
                else {
                    MessageBox.Show("请先暂停移动");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (state == RunState.stop)
                {
                    label1.Location = new System.Drawing.Point(origin_location_x, origin_location_y);
                    location_x = origin_location_x;
                    location_y = origin_location_y;
                }
                else
                {
                    MessageBox.Show("请先暂停移动");
                }
            }
        }

    }
}
