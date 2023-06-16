using Levva.newbie.coins.Domain.Models;

namespace Levva.newbie.coins.Data.Interfaces
{
    public interface IUserRepository
    {
        void Create(User User);
        void Update(User User);
        void Delete(int Id);
        User Get(int Id);
        List<User> GetAll();
        User GetByEmailAndPassword(string email, string Password);
    }
}