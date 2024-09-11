using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Entity;
using WMS.Infrastructure.Context;

namespace WMS.Repository.UserRepository
{
    public class UserRepository:IUserRepository
    {
        private readonly DapperContext _Context;
        public UserRepository(DapperContext context)
        {
            _Context = context;
        }


        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            string _query = @"SELECT Id,UserId,UserName from User;";
            using (var connection = _Context.CreateConnection())
            {
                var result = await connection.QueryAsync<User>(_query);
                return result;
            }
        }
    }
}
