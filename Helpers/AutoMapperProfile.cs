using AutoMapper;
using WebApi_Login.Entities;
using WebApi_Login.Models.Users;

namespace WebApi_Login.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}