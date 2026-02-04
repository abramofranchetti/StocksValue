using System;
using System.Collections.Generic;
using System.Text;

namespace StocksValue
{
    public class RealTimeQuote
    {
        public string Code { get; set; }
        public long Timestamp { get; set; }
        public int Gmtoffset { get; set; }

        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }

        public long Volume { get; set; }

        public decimal PreviousClose { get; set; }
        public decimal Change { get; set; }
        public decimal Change_P { get; set; }
    }

}
