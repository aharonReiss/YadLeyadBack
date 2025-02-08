using Appilcation.Interfaces;
using Appilcation.Models;
using Appilcation.Utils;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Services
{
    public class UserService : IUserService
    {
        private IConfiguration _config;
        private IUserRepository _userRepository;
        private IValidationService _validationService;

        public UserService(IUserRepository userRepository, IConfiguration config, IValidationService validationService)
        {
            _config = config;
            _userRepository = userRepository;
            _validationService = validationService;
        }
        public async Task<bool> AddUserAsync(RegistrationModelRequest user)
        {
            try
            {
                if (!_validationService.IsValidEmail(user.EmailAdress))
                    throw new Exception(SystemMessages.WrongMail);
                if (!_validationService.IsValidPassword(user.Password))
                    throw new Exception(SystemMessages.WrongPassword);
                if (!_validationService.IsValidTelephone(user.Telephone))
                    throw new Exception(SystemMessages.WrongThelephoneNumber);
                if (!_validationService.ThereIsValue(user.FirstName))
                    throw new Exception(SystemMessages.WrongFirstName);
                if (!_validationService.ThereIsValue(user.LastName))
                    throw new Exception(SystemMessages.WrongLastName);
                User userFromDb = await _userRepository.GetUserByEmail(user.EmailAdress);
                if (userFromDb != null)
                    throw new Exception(SystemMessages.UserAlreadyExist);
                User newUser = new User() { EmailAdress = user.EmailAdress, FirstName = user.FirstName,LastName = user.LastName, Password = Cryptor.MD5Encrypt(user.Password), Telephone = user.Telephone };
                return await _userRepository.AddUser(newUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserByUserId(long userId)
        {
            User userFromDb = await _userRepository.GetUserById(userId);
            if (userFromDb != null)
            {
                return userFromDb;
            }
            throw new Exception("יוזר לא קיים");
        }

        public async Task<string> Login(LoginModelRequest user)
        {
            User userFromDb = await _userRepository.GetUserByEmail(user.EmailAdress);
            if (userFromDb != null && Cryptor.MD5Encrypt(user.Password) == userFromDb.Password)
            {
                string token = JwtMethods.GenerateToken(userFromDb.Id.ToString(), _config["Jwt:Issuer"], _config["Jwt:Key"]);
                return token;
            }
            throw new Exception(SystemMessages.AuthenticationProcessFailed);
        }
    }
}
