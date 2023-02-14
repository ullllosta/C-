using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Холодов_лаба_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowData(String datapath)
        {
            try
            {
                DataStorage data = DataStorage.DataCreator(datapath);
                dgvRaw.DataSource = data.GetRawData();
                dgvRaw.ReadOnly = true;
                dgvSummary.DataSource = data.GetSummaryData();
                dgvSummary.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При загрузке данных что-то сломалось");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDig.InitialDirectory = Application.StartupPath;
            if (openFileDig.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDig.FileName);
            }
        }
    }
}
