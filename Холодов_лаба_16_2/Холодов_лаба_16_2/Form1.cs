using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Холодов_лаба_16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Рассчёт средней стоимости 1 кв. м среди объктов
        // выбранного в typeListBox типа 
        private void AverageMetrCost()
        {
            if (typeListBox.SelectedIndex == -1)
            {
                averageTextBox.Text = "Не выбрано";
                return;
            }
            List<double> metrCosts = new List<double>();
            double sum = 0;
            for (int i = 0; i < srcTable.RowCount; i++)
                for (int j = 0; j < 1; j++)
                {
                    if (srcTable[j, i].Value.ToString() == typeListBox.SelectedItem.ToString())
                        metrCosts.Add(Convert.ToDouble(srcTable[j + 4, i].Value));
                }
            foreach (double metrCost in metrCosts)
                sum += metrCost;
            averageTextBox.Text = (sum / metrCosts.Count).ToString();
        }

        // Загрузка таблиц данными из выбранного файла
        private void ShowData(string datapath)
        {
            try
            {
                FillSrcTable data = FillSrcTable.TableFiller(datapath);
                srcTable.DataSource = data.GetSrcItem();
                srcTable.ReadOnly = true;
                maxMetrCostTable.DataSource = data.GetMostExpensiveMetr();
                maxMetrCostTable.ReadOnly = true;
                srcTable.BorderStyle = BorderStyle.None;
                maxMetrCostTable.BorderStyle = BorderStyle.None;
                AverageMetrCost();
            } catch (Exception ex) { MessageBox.Show("При загрузке данных что-то сломалось"); }
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srcTable.BorderStyle = BorderStyle.FixedSingle;
            maxMetrCostTable.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AverageMetrCost();
        }
    }
}
