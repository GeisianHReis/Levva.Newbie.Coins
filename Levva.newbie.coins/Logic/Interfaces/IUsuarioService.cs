
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface IUsuarioService
    {
        void Create(UsuarioDto usuario);
        void Update(UsuarioDto usuario);
        void Delete(int Id);
        UsuarioDto Get(int Id);
        List<UsuarioDto> GetAll();
        LoginDto Login(LoginDto loginDto);
    }
}