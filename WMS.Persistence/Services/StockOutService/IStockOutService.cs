using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;

namespace WMS.Persistence.Services.StockOutService
{
    public interface IStockOutService
    {
        Task<StockOut> StockOut(StockOut Data);
    }
}
