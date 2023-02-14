using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Холодов_лаба_16_2
{
    // Поля главной таблицы (sourceTable)
    class SourceItem
    {
        public string Type { get; set; }
        public byte Rooms { get; set; }
        public int Area { get; set; }
        public double Cost { get; set; }
        public double MetrCost 
        {
            get { return Math.Round(Cost / Area, 2);  } 
        }
    }
}
