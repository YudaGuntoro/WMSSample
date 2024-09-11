using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Domain.Entity;
using System.Threading.Tasks;

namespace WMS.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();

    }
}
