using Appilcation.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(RegistrationModelRequest user);
        Task<LoginModelResponse> Login(LoginModelRequest user);
        Task<User> GetUserByUserId(long userId);
    }
}
