using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface IModeService
    {
        IDataResult<Mode> GetById(int id);
        IDataResult<List<Mode>> GetAll();
        IResult Add(Mode brand);
    }
}
