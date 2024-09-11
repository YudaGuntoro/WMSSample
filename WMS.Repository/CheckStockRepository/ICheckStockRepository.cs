using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.DTOs;
using WMS.Domain.Entity;

namespace WMS.Repository.CheckStockRepository
{
    public interface ICheckStockRepository
    {
        Task<ItemInfo> GetItemInfoAsync(int LotNo);
        Task<IEnumerable<Balance>> GetBalanceByPartNoAsync(int PartNo);
    }
}
