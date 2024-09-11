using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.DTOs;
using WMS.Domain.Entity;
using WMS.Infrastructure.Context;

namespace WMS.Repository.CheckStockRepository
{
    public class CheckStockRepository:ICheckStockRepository
    {
        private readonly DapperContext _Context;
        public CheckStockRepository(DapperContext context)
        {
            _Context = context;
        }
        public async Task<ItemInfo> GetItemInfoAsync(int LotNo)
        {
            string _query = @"SELECT generate.Id,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,stufftype.Type,masterPart.PartNo,MasterPart.PartName,location.RackLocation,location.Description FROM generate LEFT JOIN stufftype 
                            ON stufftype.Id = Generate.StufftypeId
                            LEFT JOIN masterpart ON masterpart.PartNo  = generate.MasterPartId
                            LEFT JOIN location ON masterpart.LocationId = location.Id Where LotNo = @LotNo;";
            using (var connection = _Context.CreateConnection())
            {
                var result = await connection.QueryFirstOrDefaultAsync<ItemInfo>(_query, new {LotNo = LotNo });
                return result;
            }
        }
        public async Task<IEnumerable<Balance>> GetBalanceByPartNoAsync(int PartNo)
        {
            string _query = @"SELECT generate.Id,generate.InitialQuantity,generate.RemainsQuantity,generate.LotNo,masterpart.PartNo,masterPart.PartName,location.RackLocation
                            FROM generate LEFT JOIN masterpart ON generate.MasterPartId = masterpart.Id
                            LEFT JOIN location ON masterpart.LocationId = location.Id
                            WHERE generate.StuffTypeId = 1 AND masterpart.PartNo = @PartNo;";
            using (var connection = _Context.CreateConnection())
            {
                var result = await connection.QueryAsync<Balance>(_query, new { PartNo = PartNo });
                return result;
            }
        }
    }
}
