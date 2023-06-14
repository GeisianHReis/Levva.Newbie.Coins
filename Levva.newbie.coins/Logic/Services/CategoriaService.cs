
using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Logic.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(CategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);
            _repository.Create(_categoria);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public CategoriaDto Get(int Id)
        {
            var categoria = _mapper.Map<CategoriaDto>(_repository.Get(Id));
            return categoria;
        }

        public List<CategoriaDto> GetAll()
        {
            var categorias = _mapper.Map<List<CategoriaDto>>(_repository.GetAll());
            categorias.Reverse();
            return categorias;
        }

        public void Update(CategoriaDto categoria)
        {
            var _categoria = _mapper.Map<Categoria>(categoria);
            _repository.Update(_categoria);
        }
    }
}