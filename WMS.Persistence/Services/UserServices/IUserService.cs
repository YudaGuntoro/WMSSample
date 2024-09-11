using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Entity;

namespace WMS.Persistence.Services.UserServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUser();
    }
}
