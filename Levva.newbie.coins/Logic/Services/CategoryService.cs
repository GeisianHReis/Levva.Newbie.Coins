
using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(CategoryDto Category)
        {
            var _Category = _mapper.Map<Category>(Category);
            _repository.Create(_Category);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public CategoryDto Get(int Id)
        {
            var Category = _mapper.Map<CategoryDto>(_repository.Get(Id));
            return Category;
        }

        public List<CategoryDto> GetAll()
        {
            var Categorys = _mapper.Map<List<CategoryDto>>(_repository.GetAll());
            Categorys.Reverse();
            return Categorys;
        }

        public void Update(CategoryDto Category)
        {
            var _Category = _mapper.Map<Category>(Category);
            _repository.Update(_Category);
        }
    }
}