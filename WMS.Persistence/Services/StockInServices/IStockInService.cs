using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;

namespace WMS.Persistence.Services.StockInServices
{
   public interface IStockInService
    {
        Task<StockIn> StockIn(StockIn Data);
    }
}
