using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Entities.Dtos;
using System.Diagnostics.Metrics;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class OfferService : IOfferService
    {
        IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public IResult Add(Offer offer)
        {
            _offerRepository.Add(offer);
            return new SuccessResult("Başarılı");
        }

        public IResult Delete(Offer offer)
        {
            _offerRepository.Delete(offer);
            return new SuccessResult("Başarılı");
        }

        public IDataResult<List<Offer>> GetAll()
        {
            return new SuccessDataResult<List<Offer>>(_offerRepository.GetAll());

        }

        public IDataResult<List<OfferDto>> GetAllDto()
        {
            return new SuccessDataResult<List<OfferDto>>(_offerRepository.GetAllDto());
        }

        public IDataResult<Offer> GetById(int id)
        {
            return new SuccessDataResult<Offer>(_offerRepository.Get(x => x.Id == id));
        }

        public IResult Update(Offer offer)
        {
            _offerRepository.Update(offer);
            return new SuccessResult("Başarılı");
        }
    }
}
