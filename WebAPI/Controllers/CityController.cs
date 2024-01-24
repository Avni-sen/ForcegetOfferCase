using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using ForcegetOfferCase.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("getalldto")]
        public IActionResult GetAllDto()
        {
            var result = _cityService.GetAllDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Success);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _cityService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(City city)
        {
            var result = _cityService.Add(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
