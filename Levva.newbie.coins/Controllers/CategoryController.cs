
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(CategoryDto CategoryDto){
            _service.Create(CategoryDto);
            return Created("",CategoryDto);
        }
        [HttpGet]
        public ActionResult<CategoryDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<CategoryDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(CategoryDto CategoryDto){
            _service.Update(CategoryDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}