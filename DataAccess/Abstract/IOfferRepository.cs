using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using ForcegetOfferCase.Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IOfferRepository : IEntityRepository<Offer>
    {
        List<OfferDto> GetAllDto();

    }
}
