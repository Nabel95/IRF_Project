using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketViewer.Entities
{
    public class StockData
    {
        public DateTime Date { get; set; }
        public String Stock { get; set; }
        public double CloseValue { get; set; }
        public double Return { get; set; }
    }
}
