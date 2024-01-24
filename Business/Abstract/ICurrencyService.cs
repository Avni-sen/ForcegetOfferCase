using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface ICurrencyService
    {
        IDataResult<Currency> GetById(int id);
        IDataResult<List<Currency>> GetAll();
        IResult Add(Currency currency);
        IResult Update(Currency currency);
        IResult Delete(Currency currency);
    }
}
