using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;
using WMS.Repository.CheckStockRepository;
using WMS.Repository.StockInRepository;
using WMS.Repository.StockOutRepository;

namespace WMS.Persistence.Services.StockInServices
{
   public  class StockInService : IStockInService
    {
        protected readonly IStockInRepository _Context;
        public StockInService(IStockInRepository _Data)
        {
            _Context = _Data;
        }
        public Task<StockIn> StockIn(StockIn Data)
        {
            return _Context.StockInAsync(Data);
        }
    }
}
