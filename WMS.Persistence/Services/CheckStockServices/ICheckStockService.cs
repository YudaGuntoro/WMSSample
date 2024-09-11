using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.DTOs;
using WMS.Domain.Entity;

namespace WMS.Persistence.Services.CheckStockServices
{
    public interface ICheckStockService
    {
        Task<ItemInfo> GetItemInfo(int LotNo);
        Task<IEnumerable<Balance>> GetBalanceByPartNo(int PartNo);
    }
}