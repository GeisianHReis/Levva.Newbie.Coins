
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Domain.Models;
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Levva.newbie.coins.Logic.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }
        public void Create(UserDto UserDto)
        {
            var _User = _mapper.Map<User>(UserDto);
            _repository.Create(_User);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public UserDto Get(int Id)
        {
            var User = _mapper.Map<UserDto>(_repository.Get(Id));
            return User;
        }

        public List<UserDto> GetAll()
        {
            var Users = _mapper.Map<List<UserDto>>(_repository.GetAll());
            return Users;
        }

        public void Update(UserDto User)
        {
            var _User = _mapper.Map<User>(User);
            _repository.Update(_User);
        }
        public LoginDto Login(LoginDto loginDto){
            var User = _repository.GetByEmailAndPassword(loginDto.Email, loginDto.Password);

            if(User == null){
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("Secret").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, User.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            loginDto.Id = User.Id;
            loginDto.Token = ("Bearer "+tokenHandler.WriteToken(token));
            loginDto.Password = null;
            loginDto.Name = User.Name;
            loginDto.Email = User.Email;
            

            return loginDto;
        }
    }
}