
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(UserDto User){
            _service.Create(User);
            return Created("",User);
        }
        [HttpPost("auth")]
        [AllowAnonymous]
        public ActionResult<LoginDto> Login(LoginDto loginDto){
            var login = _service.Login(loginDto);
            

            if(login == null){
                return BadRequest("User ou Password invalidos");

            }

            return Ok(login);
        }
        [HttpGet]
        public ActionResult<UserDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<UserDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(UserDto User){
            _service.Update(User);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}