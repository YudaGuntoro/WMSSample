using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Entity
{
    public class Balance
    {
        public int Id { get; set; }
        public int InitialQuantity { get; set; }
        public int RemainsQuantity { get; set; }
        public long LotNo { get; set; }
        public int PartNo { get; set; }
        public string PartName { get; set; }
        public string RackLocation { get; set; }
        public string StockInDate { get; set; }
    }
}
