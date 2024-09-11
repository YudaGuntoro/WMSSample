using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Domain.DTOs
{
    public class ItemInfo
    {
        public int Id { get; set; }
        public int InitialQuantity { get; set; }
        public int RemainsQuantity {get;set;}
        public int LotNo { get; set; }
        public string Type { get; set; }
        public int PartNo { get; set; }
        public string PartName { get; set; }
        public string RackLocation { get; set; }
        public string Description { get; set; }
    }
}
