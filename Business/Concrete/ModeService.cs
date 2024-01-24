using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class ModeService : IModeService
    {
        IModeRepository _modeRepository;

        public ModeService(IModeRepository modeRepository)
        {
            _modeRepository = modeRepository;
        }

        public IResult Add(Mode mode)
        {
            _modeRepository.Add(mode);
            return new SuccessResult("Başarılı");
        }

        public IResult Delete(Mode mode)
        {
            _modeRepository.Delete(mode);
            return new SuccessResult(Message.BrandDeleted);
        }

        public IResult Update(Mode mode)
        {
            _modeRepository.Update(mode);
            return new SuccessResult(Message.BrandUpdated);
        }

        public IDataResult<List<Mode>> GetAll()
        {
            return new SuccessDataResult<List<Mode>>(_modeRepository.GetAll());
        }

        public IDataResult<Mode> GetById(int id)
        {
            return new SuccessDataResult<Mode>(_modeRepository.Get(x => x.Id == id));
        }
    }
}
