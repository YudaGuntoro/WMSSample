using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WMS.Domain.Request;
using System.Threading.Tasks;
using WMS.Infrastructure.Context;

namespace WMS.Repository.StockInRepository
{
    public class StockInRepository:IStockInRepository
    {
        private readonly DapperContext Context;
        public StockInRepository(DapperContext context)
        {
            Context = context;
        }
        public async Task<StockIn> StockInAsync(StockIn Data)
        {
            //Ini Check Material Status
            var _query = "INSERT INTO stocksystem.stockin(StockInDate, StockInShift, StockInUserId, GenerateId)values(@StockInDate, @StockInShift, @StockInUserId, @GenerateId)";

            var parameters = new DynamicParameters();

            parameters.Add("StockInDate", Data.StockInDate, DbType.DateTime);
            parameters.Add("StockInShift", Data.StockInShift, DbType.Int32);
            parameters.Add("StockInUserId", Data.StockInUserId, DbType.Int32);
            parameters.Add("GenerateId", Data.GenerateId, DbType.Int32);
       
            using (var connection = Context.CreateConnection())
            {
                var result = await connection.ExecuteAsync(_query, parameters);
                var _result = new StockIn
                {
                    StockInDate = Data.StockInDate,
                    StockInShift = Data.StockInShift,
                    StockInUserId = Data.StockInUserId,
                    GenerateId = Data.GenerateId,
                };
            return _result;
            }
        }
    }
}
