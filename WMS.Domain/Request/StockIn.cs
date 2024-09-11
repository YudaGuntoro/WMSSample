using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Domain.Request
{
    public class StockIn
    {
        public DateTime StockInDate {get;set;}
        public int StockInShift { get; set; }
        public int StockInUserId { get; set; }
        public int GenerateId { get; set; }
    }
}
