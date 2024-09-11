using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;

namespace WMS.Repository.StockInRepository
{
    public interface IStockInRepository
    {
        Task<StockIn> StockInAsync(StockIn Data);
    }
}
