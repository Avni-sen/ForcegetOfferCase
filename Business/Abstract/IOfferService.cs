using Core.Utilities.Result;
using Entities.Concrete;
using ForcegetOfferCase.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface IOfferService
    {
        IDataResult<Offer> GetById(int id);
        IDataResult<List<Offer>> GetAll();
        IDataResult<List<OfferDto>> GetAllDto();
        IResult Add(Offer offer);
        IResult Update(Offer offer);
        IResult Delete(Offer offer);
    }
}
