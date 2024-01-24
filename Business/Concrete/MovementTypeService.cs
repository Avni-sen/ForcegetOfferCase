using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class MovementTypeService : IMovementTypeService
    {
        IMovementTypeRepository _movementTypeRepository;

        public MovementTypeService(IMovementTypeRepository movementTypeRepository)
        {
            _movementTypeRepository = movementTypeRepository;
        }

        public IResult Add(MovementType movementType)
        {
            _movementTypeRepository.Add(movementType);
            return new SuccessResult("Başarılı");
        }

        public IResult Delete(MovementType movementType)
        {
            _movementTypeRepository.Delete(movementType);
            return new SuccessResult("Başarılı");
        }

        public IDataResult<List<MovementType>> GetAll()
        {
            return new SuccessDataResult<List<MovementType>>(_movementTypeRepository.GetAll());
        }

        public IDataResult<MovementType> GetById(int id)
        {
            return new SuccessDataResult<MovementType>(_movementTypeRepository.Get(x => x.Id == id));
        }

        public IResult Update(MovementType movementType)
        {
            _movementTypeRepository.Update(movementType);
            return new SuccessResult("Güncellendi");
        }
    }
}
