using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class CurrencyService : ICurrencyService
    {
        ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public IResult Add(Currency currency)
        {
            _currencyRepository.Add(currency);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Currency currency)
        {
            _currencyRepository.Add(currency);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Currency>> GetAll()
        {
            var result = _currencyRepository.GetAll();
            return new SuccessDataResult<List<Currency>>(result);
        }

        public IDataResult<Currency> GetById(int id)
        {
            var result = _currencyRepository.Get(x => x.Id == id);
            return new SuccessDataResult<Currency>(result);
        }

        public IResult Update(Currency currency)
        {
            _currencyRepository.Add(currency);
            return new SuccessResult("Güncellendi");
        }
    }
}
