using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using ForcegetOfferCase.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class CityService : ICityService
    {
        ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public IResult Add(City city)
        {
            _cityRepository.Add(city);
            return new SuccessResult("Eklendi");
        }

        public IDataResult<City> GetById(int id)
        {
            var result = _cityRepository.Get(x => x.Id == id);
            return new SuccessDataResult<City>(result);
        }

        public IDataResult<List<CityDto>> GetAllDto()
        {
            var result = _cityRepository.GetAllDto();
            return new SuccessDataResult<List<CityDto>>(result);
        }
    }
}
