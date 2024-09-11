using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Entity;
using WMS.Repository.CheckStockRepository;
using WMS.Repository.UserRepository;

namespace WMS.Persistence.Services.UserServices
{
    public class UserService:IUserService
    {
        protected readonly IUserRepository _Context;
        public UserService(IUserRepository _Data)
        {
            _Context = _Data;
        }

        public Task<IEnumerable<User>> GetAllUser()
        {
           return _Context.GetAllUserAsync();
        }
    }
}
