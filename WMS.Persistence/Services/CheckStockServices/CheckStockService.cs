using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.DTOs;
using WMS.Domain.Entity;
using WMS.Repository.CheckStockRepository;

namespace WMS.Persistence.Services.CheckStockServices
{
    public class CheckStockService:ICheckStockService
    {
        protected readonly ICheckStockRepository _Context;
        public CheckStockService(ICheckStockRepository _Data)
        {
            _Context = _Data;
        }

        public Task<IEnumerable<Balance>> GetBalanceByPartNo(int PartNo)
        {
            return _Context.GetBalanceByPartNoAsync(PartNo);
        }

        public Task<ItemInfo> GetItemInfo(int LotNo)
        {
            return _Context.GetItemInfoAsync(LotNo);
        }
    }
}
