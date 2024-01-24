using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CityRepository : EfEntityRepositoryBase<City, ForcegetOfferCaseContext>, ICityRepository
    {

        List<CityDto> ICityRepository.GetAllDto()
        {
            using (var context = new ForcegetOfferCaseContext())
            {
                var result = (from city in context.Cities
                              join country in context.Countries
                              on city.CountryId equals country.Id
                              where city.isDeleted == false
                              select new CityDto
                              {
                                  Id = city.Id,
                                  Name = city.Name,
                                  CountryName = country.Name,
                                  CountryId = country.Id,
                                  CreatedDate = city.CreatedDate,
                                  UpdatedDate = city.UpdatedDate,
                                  isDeleted = city.isDeleted
                              }).ToList();

                return result;
            }
        }
    }
}
