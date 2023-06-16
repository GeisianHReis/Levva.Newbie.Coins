using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context){
            _context = context;
        }
        public void Create(User User)
        {
            _context.User.Add(User);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var User = _context.User.Find(Id);
            _context.User.Remove(User);
            _context.SaveChanges();
        }

        public User Get(int Id)
        {
            var User = _context.User.Find(Id);
            return User;
        }

        public List<User> GetAll()
        {
            var Users = _context.User.ToList();
            return Users;
        }

        public User GetByEmailAndPassword(string email, string Password)
        {
            return _context.User.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(Password));
        }

        public void Update(User User)
        {
            _context.User.Update(User);
            _context.SaveChanges();
        }
    }
}