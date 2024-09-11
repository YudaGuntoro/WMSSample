using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.DTOs
{
    public class StockOutLog
    {
        public int Id { get; set; }
        public int StockOutShift { get; set; }
        public string UserName { get; set; }
        public int StockTaking { get; set; }
        public string StockOutDate { get; set; }
        public string Customer { get; set; }
    }
}
