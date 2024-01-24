using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface ICountryService
    {
        IDataResult<Country> GetById(int id);
        IDataResult<List<Country>> GetAll();
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
    }
}
