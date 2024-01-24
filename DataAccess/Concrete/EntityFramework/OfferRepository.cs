using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using ForcegetOfferCase.Entities.Concrete.Enums;
using ForcegetOfferCase.Entities.Dtos;

namespace ForcegetOfferCase.DataAccess.Repositories.Concrete
{
    public class OfferRepository : EfEntityRepositoryBase<Offer, ForcegetOfferCaseContext>, IOfferRepository
    {
        public List<OfferDto> GetAllDto()
        {
            using (var context = new ForcegetOfferCaseContext())
            {
                var result = (from offer in context.Offers
                              join mode in context.Modes on offer.ModeId equals mode.Id into modeJoin
                              from mode in modeJoin.DefaultIfEmpty()

                              join movement in context.MovementTypes on offer.MovementTypeId equals movement.Id into movementJoin
                              from movement in movementJoin.DefaultIfEmpty()

                              join packageType in context.PackageTypes on offer.PackageTypeId equals packageType.Id into packageTypeJoin
                              from packageType in packageTypeJoin.DefaultIfEmpty()

                              join city in context.Cities on offer.CityId equals city.Id into cityJoin
                              from city in cityJoin.DefaultIfEmpty()

                              join country in context.Countries on offer.CountryId equals country.Id into countryJoin
                              from country in countryJoin.DefaultIfEmpty()

                              join currency in context.Currencies on offer.CurrencyId equals currency.Id into currencyJoin
                              from currency in currencyJoin.DefaultIfEmpty()

                              join incoterm in context.Incoterms on offer.IncotermId equals incoterm.Id into incotermJoin
                              from incoterm in incotermJoin.DefaultIfEmpty()

                              where city != null && !city.isDeleted
                              select new OfferDto
                              {
                                  Id = offer.Id,
                                  CountryId = offer.CountryId,
                                  CountryName = country.Name,
                                  CityId = offer.CityId,
                                  CityName = city.Name,
                                  CurrencyId = offer.CurrencyId,
                                  CurrencyName = currency.Name,
                                  IncotermId = offer.IncotermId,
                                  IncotermName = incoterm.Name,
                                  CreatedDate = offer.CreatedDate,
                                  isDeleted = offer.isDeleted,
                                  LengthUnit = offer.LengthUnitId == (int)LengthUnit.CM ? LengthUnit.CM.ToString() : LengthUnit.IN.ToString(),
                                  LengthUnitId = offer.LengthUnitId,
                                  WeightUnit = offer.WeightUnitId == (int)WeightUnit.LB ? WeightUnit.LB.ToString() : WeightUnit.KG.ToString(),
                                  WeightUnitId = offer.WeightUnitId,
                                  ModeId = offer.ModeId,
                                  ModeName = mode.Name,
                                  MovementTypeId = offer.MovementTypeId,
                                  MovementTypeName = movement.Name,
                                  PackageTypeId = offer.PackageTypeId,
                                  PackageTypeName = packageType.Name,
                                  UpdatedDate = offer.UpdatedDate
                              }).ToList();

                return result;
            }
        }
    }
}
