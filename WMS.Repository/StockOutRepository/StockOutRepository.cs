using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Request;
using WMS.Infrastructure.Context;

namespace WMS.Repository.StockOutRepository
{
    public class StockOutRepository:IStockOutRepository
    {
        private readonly DapperContext Context;
        public StockOutRepository(DapperContext context)
        {
            Context = context;
        }
        public async Task<StockOut> StockOutAsync(StockOut Data)
        {
            //Ini Check Material Status
            var _query = "INSERT INTO stocksystem.stockout(StockOutDate, StockOutShift, StockOutUserId,StockTaking, GenerateId)values(@StockOutDate, @StockOutShift, @StockOutUserId,@StockTaking, @GenerateId)";

            var parameters = new DynamicParameters();

            parameters.Add("StockOutDate", Data.StockOutDate, DbType.DateTime);
            parameters.Add("StockOutShift", Data.StockOutShift, DbType.Int32);
            parameters.Add("StockOutUserId", Data.StockOutUserId, DbType.Int32);
            parameters.Add("StockTaking", Data.StockTaking, DbType.Int32);
            parameters.Add("GenerateId", Data.GenerateId, DbType.Int32);

            using (var connection = Context.CreateConnection())
            {
                var result = await connection.ExecuteAsync(_query, parameters);
                var _result = new StockOut
                {
                    StockOutDate = Data.StockOutDate,
                    StockOutShift = Data.StockOutShift,
                    StockOutUserId = Data.StockOutUserId,
                    StockTaking = Data.StockTaking,
                    GenerateId = Data.GenerateId,
                };
                return _result;
            }
        }
    }
}
