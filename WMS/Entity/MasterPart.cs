using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Entity
{
    public class MasterPart
    {
        public int id { get; set; }
        public int PartNo { get; set; }
        public string PartName { get; set; }
        public string RackLocation { get; set; }
    }
}
