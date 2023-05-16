using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;
        public UsuarioRepository(Context context){
            _context = context;
        }
        public void Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var usuario = _context.Usuario.Find(Id);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario Get(int Id)
        {
            var usuario = _context.Usuario.Find(Id);
            return usuario;
        }

        public List<Usuario> GetAll()
        {
            var usuarios = _context.Usuario.ToList();
            return usuarios;
        }

        public void Update(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
        }
    }
}