using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Application.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageTypeController : Controller
    {
        IPackageTypeService _packageTypeService;

        public PackageTypeController(IPackageTypeService packageTypeService)
        {
            _packageTypeService = packageTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _packageTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _packageTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(PackageType packageType)
        {
            var result = _packageTypeService.Add(packageType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
