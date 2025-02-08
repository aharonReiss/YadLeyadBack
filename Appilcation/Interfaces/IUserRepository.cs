using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(long Id);
    }
}
