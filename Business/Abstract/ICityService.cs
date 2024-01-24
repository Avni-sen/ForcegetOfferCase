using Core.Entities.Concrete;
using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface ICityService
    {
        IResult Add(City city);
        IDataResult<City> GetById(int id);
        IDataResult<List<CityDto>> GetAllDto();
    }
}
