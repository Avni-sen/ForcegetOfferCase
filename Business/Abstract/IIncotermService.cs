using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface IIncotermService
    {
        IDataResult<Incoterm> GetById(int id);
        IDataResult<List<Incoterm>> GetAll();
        IResult Add(Incoterm incoterm);
        IResult Update(Incoterm incoterm);
        IResult Delete(Incoterm incoterm);
    }
}
