using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace пз3
{
    public partial class Form1 : Form
    {
        DateTimeFormat dtFomat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        Point LocMouse;
        double counter2;
        

        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }
        public Form1()
        { 

            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
            this.ContextMenuStrip = this.contextMenuStrip1;
        }
        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFomat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else 
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }


        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFomat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate3;
            currentCheckedItem.Checked = true;
        }

        private void ToolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFomat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            LocMouse = new Point(e.X, e.Y);
            toolStripStatusLabel2.Text = LocMouse.ToString();


            double xx = e.X;
            double yy = e.Y;
            if (counter2 == 2)
                resultLabel.Text = Math.Pow(yy, 3) + xx.ToString();
            if(counter2 == 1)
                resultLabel.Text = Math.Pow(xx, 4) + xx + yy.ToString();    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(toolStripTextBox1.Text);
            double y = double.Parse(toolStripTextBox2.Text);
            double z = double.Parse(toolStripTextBox3.Text);
            double a = double.Parse(toolStripComboBox1.Text);
            double b = double.Parse(toolStripComboBox2.Text);
            double count = 0;

            count = a * x + b * y + Math.Sin(z) + x - y;
            Text = String.Format("{0}", count);
        }

        private void z1_Click(object sender, EventArgs e)
        {
            counter2 = 2;
        }

        private void z2_Click(object sender, EventArgs e)
        {
            counter2 = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripTextBox4.Text = "1";
            toolStripTextBox5.Text = "2";
            toolStripTextBox6.Text = "3";
            toolStripComboBox3.Text = "4";
            toolStripComboBox4.Text = "5";

        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            double x = double.Parse(toolStripTextBox4.Text);
            double y = double.Parse(toolStripTextBox5.Text);
            double z = double.Parse(toolStripTextBox6.Text);
            double a = double.Parse(toolStripComboBox3.Text);
            double b = double.Parse(toolStripComboBox4.Text);
            double count = 0;

            count = a * x + b * y + Math.Sin(z) + x - y;
            textBox1.Text = count.ToString();
        }
    }
}
