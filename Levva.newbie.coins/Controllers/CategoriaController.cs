
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(CategoriaDto categoriaDto){
            _service.Create(categoriaDto);
            return Created("",categoriaDto);
        }
        [HttpGet]
        public ActionResult<CategoriaDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<CategoriaDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(CategoriaDto categoriaDto){
            _service.Update(categoriaDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}