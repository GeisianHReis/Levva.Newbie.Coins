using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;

namespace Levva.newbie.coins.Logic.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(UsuarioDto usuario)
        {
            var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Create(_usuario);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public UsuarioDto Get(int Id)
        {
            var usuario = _mapper.Map<UsuarioDto>(_repository.Get(Id));
            return usuario;
        }

        public List<UsuarioDto> GetAll()
        {
            var usuarios = _mapper.Map<List<UsuarioDto>>(_repository.GetAll());
            return null;
        }

        public void Update(UsuarioDto usuario)
        {
            var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Update(_usuario);
        }
    }
}