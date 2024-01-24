using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Application.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementTypeController : Controller
    {
        IMovementTypeService _movementTypeService;

        public MovementTypeController(IMovementTypeService movementTypeService)
        {
            _movementTypeService = movementTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _movementTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Success);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _movementTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(MovementType movementType)
        {
            var result = _movementTypeService.Add(movementType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
