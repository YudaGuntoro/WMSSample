using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;
using WMS.Repository.CheckStockRepository;
using WMS.Repository.StockOutRepository;
using WMS.Repository.UserRepository;

namespace WMS.Persistence.Services.StockOutService
{
    public class StockOutService : IStockOutService
    {
        protected readonly IStockOutRepository _Context;
        public StockOutService(IStockOutRepository _Data)
        {
            _Context = _Data;
        }
        public Task<StockOut> StockOut(StockOut Data)
        {
          return _Context.StockOutAsync(Data);
        }
    }
}
