using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Application.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeController : Controller
    {
        IModeService _modeService;

        public ModeController(IModeService modeService)
        {
            _modeService = modeService;
        }

        //tüm http isteklerini yaz 
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _modeService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _modeService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Mode mode)
        {
            var result = _modeService.Add(mode);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
