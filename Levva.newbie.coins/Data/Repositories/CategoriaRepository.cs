using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context){
            _context = context;
        }
        public void Create(Category Category)
        {
            _context.Category.Add(Category);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var Category = _context.Category.Find(Id);
            _context.Category.Remove(Category);
            _context.SaveChanges();
        }

        public Category Get(int Id)
        {
            var Category = _context.Category.Find(Id);
            return Category;
        }

        public List<Category> GetAll()
        {
            var Categorys = _context.Category.ToList();
            return Categorys;
        }

        public void Update(Category Category)
        {
            _context.Category.Update(Category);
            _context.SaveChanges();
        }
    }
}