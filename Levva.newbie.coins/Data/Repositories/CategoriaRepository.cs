using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Context _context;

        public CategoriaRepository(Context context){
            _context = context;
        }
        public void Create(Categoria Categoria)
        {
            _context.Categoria.Add(Categoria);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var categoria = _context.Categoria.Find(Id);
            _context.Categoria.Remove(categoria);
            _context.SaveChanges();
        }

        public Categoria Get(int Id)
        {
            var categoria = _context.Categoria.Find(Id);
            return categoria;
        }

        public List<Categoria> GetAll()
        {
            var categorias = _context.Categoria.ToList();
            return categorias;
        }

        public void Update(Categoria Categoria)
        {
            _context.Categoria.Update(Categoria);
            _context.SaveChanges();
        }
    }
}