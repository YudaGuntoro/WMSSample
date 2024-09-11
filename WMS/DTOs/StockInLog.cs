using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.DTOs
{
    public class StockInLog
    {
        public int Id { get; set; }
        public int StockInShift { get; set; }
        public string UserName { get; set; } 
        public string StockInDate { get; set; }
    }
}
