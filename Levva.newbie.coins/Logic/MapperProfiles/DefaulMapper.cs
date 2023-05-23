
using AutoMapper;
using Levva.newbie.coins.Domain.Models;
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.MapperProfiles
{
    public class DefaulMapper : Profile
    {
        public DefaulMapper()
        {
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
            CreateMap<CategoriaDto, Categoria>().ReverseMap();
            CreateMap<TransacaoDto, Transacao>().ReverseMap();
        }

    }
}