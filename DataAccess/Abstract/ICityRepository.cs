using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICityRepository : IEntityRepository<City>
    {
        List<CityDto> GetAllDto();
    }
}
