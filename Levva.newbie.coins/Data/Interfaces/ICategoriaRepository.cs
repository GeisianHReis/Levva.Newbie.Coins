using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        void Create(Categoria Categoria);
        void Update(Categoria Categoria);
        void Delete(int Id);
        Categoria Get(int Id);
        List<Categoria> GetAll();
    }
}