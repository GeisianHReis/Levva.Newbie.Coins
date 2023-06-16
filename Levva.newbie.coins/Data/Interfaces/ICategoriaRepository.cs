using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface ICategoryRepository
    {
        void Create(Category Category);
        void Update(Category Category);
        void Delete(int Id);
        Category Get(int Id);
        List<Category> GetAll();
    }
}