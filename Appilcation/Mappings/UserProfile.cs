using Appilcation.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Appilcation.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
