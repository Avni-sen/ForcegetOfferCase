using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Application.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncotermController : Controller
    {
        IIncotermService _incotermService;

        public IncotermController(IIncotermService incotermService)
        {
            _incotermService = incotermService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _incotermService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _incotermService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Incoterm incoterm)
        {
            var result = _incotermService.Add(incoterm);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }


    }
}
