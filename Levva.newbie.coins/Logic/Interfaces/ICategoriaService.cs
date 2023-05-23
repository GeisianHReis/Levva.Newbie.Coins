using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface ICategoriaService
    {
        void Create(CategoriaDto categoria);
        void Update(CategoriaDto categoria);
        List<CategoriaDto> GetAll();
        CategoriaDto Get(int Id);
        void Delete(int Id);
    }
}