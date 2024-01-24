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
    public class IncotermService : IIncotermService
    {
        IIncotermRepository _incotermRepository;

        public IncotermService(IIncotermRepository incotermRepository)
        {
            _incotermRepository = incotermRepository;
        }

        public IResult Add(Incoterm incoterm)
        {
           _incotermRepository.Add(incoterm);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(Incoterm incoterm)
        {
            _incotermRepository.Add(incoterm);
            return new SuccessResult("Silme Başarılı");
        }

        public IDataResult<List<Incoterm>> GetAll()
        {
            return new SuccessDataResult<List<Incoterm>>(_incotermRepository.GetAll());
        }

        public IDataResult<Incoterm> GetById(int id)
        {
            return new SuccessDataResult<Incoterm>(_incotermRepository.Get(x=>x.Id == id));
        }

        public IResult Update(Incoterm incoterm)
        {
            _incotermRepository.Add(incoterm);
            return new SuccessResult("Güncelleme Başarılı");
        }
    }
}
