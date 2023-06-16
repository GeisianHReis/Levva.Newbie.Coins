
using AutoMapper;
using Levva.newbie.coins.Domain.Models;
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.MapperProfiles
{
    public class DefaulMapper : Profile
    {
        public DefaulMapper()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
        }

    }
}