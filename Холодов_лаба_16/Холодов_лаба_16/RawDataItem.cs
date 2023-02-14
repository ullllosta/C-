using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Холодов_лаба_16
{
    class RawDataItem
    {
        public String Name { get; set; }
        public int Group { get; set; }
        public String Part { get; set; }
        public float Price { get; set; }
        public float Count { get; set; }
        public float Sum
        {
            get { return Count * Price; }
        }
    }
}
