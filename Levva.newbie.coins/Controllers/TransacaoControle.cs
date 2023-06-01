
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoService _service;

        public TransacaoController(ITransacaoService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(TransacaoDto transacaoDto){
            _service.Create(transacaoDto);
            return Created("",transacaoDto);
        }
        [HttpGet]
        public ActionResult<TransacaoDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<TransacaoDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(TransacaoDto transacaoDto){
            _service.Update(transacaoDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}