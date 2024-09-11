using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Entity
{
    public class Generate
    {
        public int id { get; set; }
        public int InitialQuantity { get; set; }
        public int RemainsQuantity { get; set; }
        public long LotNo { get; set; }
        public int MasterPartId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
