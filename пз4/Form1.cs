using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace пз4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reshit_Click(object sender, EventArgs e)
        {
            double z = 1;
            double x = double.Parse(tbx.Text);
            double kolvo = double.Parse(tbkolvo.Text);


            for (int i = 2; i - 1 < kolvo; i++)
            {
                if (i % 2 == 0)
                    z = z - (Math.Sin(Math.Pow(x, i)) / i);
                else
                    z = z + (Math.Cos(Math.Pow(x, i)) / i);

            }

            textBox1.Text = "Z = " + z.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = reshit.BackColor;
            dlg.Color = button1.BackColor;
            dlg.Color = button2.BackColor;
            dlg.Color = button3.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                reshit.BackColor = dlg.Color;
                button1.BackColor = dlg.Color;
                button2.BackColor = dlg.Color;
                button3.BackColor = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = reshit.Font;
            dlg.Font = button1.Font;
            dlg.Font = button2.Font;
            dlg.Font = button3.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                reshit.Font = dlg.Font;
                button1.Font = dlg.Font;
                button2.Font = dlg.Font;
                button3.Font = dlg.Font;
                reshit.ForeColor = dlg.Color;
                button1.ForeColor = dlg.Color;
                button2.ForeColor = dlg.Color;
                button3.ForeColor = dlg.Color;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "*.tsx";
            dlg.Filter = "Test files|*.txt";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                dlg.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName, true))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                }
            }
        }
    }
}
