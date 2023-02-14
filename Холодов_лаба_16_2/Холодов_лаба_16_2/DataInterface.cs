using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Холодов_лаба_16_2
{
    interface DataInterface
    {
        List<SourceItem> GetSrcItem();
        List<SourceItem> GetMostExpensiveMetr();
    }
}
