using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Domain.Request
{
    public class StockOut
    {
        public DateTime StockOutDate { get; set; }
        public int StockOutShift { get; set; }
        public int StockOutUserId { get; set; }
        public int StockTaking { get; set; }
        public int GenerateId { get; set; }
    }
}
