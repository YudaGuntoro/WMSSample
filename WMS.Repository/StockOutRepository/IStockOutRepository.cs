using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;

namespace WMS.Repository.StockOutRepository
{
    public interface IStockOutRepository
    {
        Task<StockOut> StockOutAsync(StockOut Data);
    }
}
