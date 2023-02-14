using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Windows.Forms.DataVisualization.Charting;


namespace Холодов_лаба_17
{
    public partial class Form1 : Form
    {
        // Цвет графика
        Color color = Color.Red;
        // Режим отображения
        int mode = 1;
        // Шаг расчёта функции
        double dx = 10;               // было dx = 5
        // Интервал изменения x
        double x0 = 0.0, xn = 400.00;
        // Коэффициенты функции
        double a = 5, b = 100, p = -0.5, k = 2;

        private void comboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Устанавливаем режим рисования графика
            mode = ((ComboBox)sender).SelectedIndex;
            //MessageBox.Show($"{mode}");
        }

        private void btnClearPanelGraf_Click(object sender, EventArgs e)
        {
            panelGraf.Invalidate();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Устанавливаем новый цвет
                color = dlg.Color;
                // Перерисовываем панель с графиком 
                btnRedraw_Click(sender, e);
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            Graphics g = panelGraf.CreateGraphics();
            Pen myPen = new Pen(color);
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            k = Convert.ToDouble(txtK.Text);
            p = Convert.ToDouble(txtP.Text);

            double x = 0;
            x0 = 0;
            List<Point> points = new List<Point>();
            while (x0 <= xn)
            {
                x = x0;
                var point = new Point(Convert.ToInt32(x), Convert.ToInt32(MyFunc(x)+panelGraf.Height/2));
                points.Add(point);
                x0 += dx;
            }
            if (mode == 1)
                g.DrawCurve(myPen, points.ToArray());
            else if (mode == 0)
            {
                foreach (Point pnt in points)
                    g.DrawRectangle(myPen, pnt.X, pnt.Y, 1, 1);
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Инициализация компонентов формы значениями переменных
            // Выбор режима
            comboMode.SelectedIndex = mode;
            // Установка коэффициентов
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            txtK.Text = k.ToString();
            txtP.Text = p.ToString();
        }

        private double MyFunc(double x)
        {
            if (x == 0)
                return 0;
            else
                return a * Math.Pow(x, -p) * Math.Sin(k * x + b) + a * Math.Pow(x, -p) * Math.Sin(k * x + b);
                //return a * Math.Pow(x, -p) * Math.Sin(k * x + b);
        }
    }
}
