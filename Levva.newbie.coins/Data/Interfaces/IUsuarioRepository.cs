using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int Id);
        Usuario Get(int Id);
        List<Usuario> GetAll();
        Usuario GetByEmailAndSenha(string email, string senha);
    }
}