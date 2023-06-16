
using Levva.newbie.coins.Logic.Dtos;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.newbie.coins.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _service;

        public TransactionController(ITransactionService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Create(TransactionDto TransactionDto){
            _service.Create(TransactionDto);
            return Created("",TransactionDto);
        }
        [HttpGet]
        public ActionResult<TransactionDto> Get(int Id){
            return _service.Get(Id);
        }
        [HttpGet("all")]
        public ActionResult<List<TransactionDto>> GetAll(){
            return _service.GetAll();
        }
        [HttpPut]
        public IActionResult Update(TransactionDto TransactionDto){
            _service.Update(TransactionDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id){
            _service.Delete(Id);
            return Ok();
        }

    }

}