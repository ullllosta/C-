using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace пз5
{
    public partial class Form1 : Form
    {
        private DataStorage data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog1.FileName);
            }
        }
        private void ShowData(string datapath)
        {
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При загрузке данных произошла ошибка");
            }

            dgrRaw.DataSource = data.GetRawData();
            dgrRaw.ReadOnly = true;
            dgrSummary.DataSource = data.GetSummaryData();
            dgrSummary.ReadOnly = true;
        }
        class RawDataItem
        {
            public string Name { get; set; }
            public int Group { get; set; }
            public string Part { get; set; }
            public float Price { get; set; }
            public float Count { get; set; }
            public float Sum
            {
                get { return Count * Price; }
            }
        }

        class SummaryDataItem
        {
            public string GroupName { get; set; }
            public float GroupSum { get; set; }
        }

        class Utils
        {
            private static Dictionary<int, string> dict;
            static Utils()
            {
                if (dict == null)
                {
                    dict = new Dictionary<int, string>(5);
                    dict.Add(0, "Товар");
                    dict.Add(1, "Товарная группа");
                    dict.Add(2, "Одежда");
                    dict.Add(3, "Фрукты");
                    dict.Add(4, "Полиграфия");
                }
            }

            public static String GetGroupByNumber(int number)
            {
                if (dict.ContainsKey(number))
                    return dict[number];
                else
                    return "???";
            }
        }

        interface DataInterface
        {
            List<RawDataItem> GetRawData();
            List<SummaryDataItem> GetSummaryData();
        }

        class DataStorage : DataInterface
        {
            public bool IsReady
            {
                get
                {
                    if (rawdata == null) return false;
                    else return true;
                }
            }
            private List<RawDataItem> rawdata;
            private List<SummaryDataItem> sumdata;
            private char devider = '%';
            private DataStorage() { }

            private void BuildSummary()
            {
                Dictionary<int, float> tmp = new Dictionary<int, float>();
                foreach (var item in rawdata)
                {
                    if (tmp.ContainsKey(item.Group))
                        tmp[item.Group] += item.Sum;
                    else
                        tmp[item.Group] = item.Sum;
                }

                sumdata = new List<SummaryDataItem>();
                foreach (var item in tmp)
                {
                    sumdata.Add(new SummaryDataItem()
                    {
                        GroupName = Utils.GetGroupByNumber(item.Key),
                        GroupSum = item.Value
                    });
                }
            }

            private bool InitData(String datapath)
            {
                rawdata = new List<RawDataItem>();

                try
                {
                    StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] items = line.Split(devider);
                        var item = new RawDataItem()
                        {
                            Name = items[0].Trim(),
                            Part = items[1].Trim(),
                            Group = Convert.ToInt32(items[2].Trim()),
                            Price = Convert.ToInt32(items[3].Trim()),
                            Count = Convert.ToInt32(items[4].Trim())
                        };
                        rawdata.Add(item);
                    }
                    sr.Close();
                    BuildSummary();
                }
                catch (IOException ex)
                {
                    return false;
                }
                return true;
            }
            public static DataStorage DataCreator(String path)
            {
                DataStorage d = new DataStorage();
                if (d.InitData(path))
                    return d;
                else
                    return null;
            }
            public List<RawDataItem> GetRawData()
            {
                if (this.IsReady)
                    return rawdata;
                else
                    return null;
            }
            public List<SummaryDataItem> GetSummaryData()
            {
                if (this.IsReady)
                    return sumdata;
                else
                    return null;
            }
        }
    }
}
