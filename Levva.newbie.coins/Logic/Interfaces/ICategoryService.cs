using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface ICategoryService
    {
        void Create(CategoryDto Category);
        void Update(CategoryDto Category);
        List<CategoryDto> GetAll();
        CategoryDto Get(int Id);
        void Delete(int Id);
    }
}