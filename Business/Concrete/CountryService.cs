using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class CountryService : ICountryService
    {
        ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IResult Add(Country country)
        {
            _countryRepository.Add(country);
            return new SuccessResult("Başarılı");
        }

        public IResult Delete(Country country)
        {
            _countryRepository.Delete(country);
            return new SuccessResult("Silme İşlemi Başarılı");
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryRepository.GetAll());
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryRepository.Get(x => x.Id == id));
        }

        public IResult Update(Country country)
        {
            _countryRepository.Update(country);
            return new SuccessResult("Güncelleme İşlemi Başarılı");
        }
    }
}
