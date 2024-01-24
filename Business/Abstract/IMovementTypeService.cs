using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface IMovementTypeService
    {
        IDataResult<MovementType> GetById(int id);
        IDataResult<List<MovementType>> GetAll();
        IResult Add(MovementType movementType);
        IResult Update(MovementType movementType);
        IResult Delete(MovementType movementType);
    }
}
