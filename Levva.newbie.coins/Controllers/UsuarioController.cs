
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(UsuarioDto usuario){
            _service.Create(usuario);
            return Created("",usuario);
        }
        [HttpGet]
        public ActionResult<UsuarioDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<UsuarioDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(UsuarioDto usuario){
            _service.Update(usuario);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}