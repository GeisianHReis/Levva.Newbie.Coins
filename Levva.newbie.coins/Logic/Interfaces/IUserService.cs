
using Levva.newbie.coins.Logic.Dtos;

namespace Levva.newbie.coins.Logic.Interfaces
{
    public interface IUserService
    {
        void Create(UserDto User);
        void Update(UserDto User);
        void Delete(int Id);
        UserDto Get(int Id);
        List<UserDto> GetAll();
        LoginDto Login(LoginDto loginDto);
    }
}