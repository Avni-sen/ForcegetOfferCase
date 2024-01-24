using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Offer : BaseEntity, IEntity
    {
        public int ModeId { get; set; }
        public int MovementTypeId { get; set; }
        public int IncotermId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int PackageTypeId { get; set; }
        public int CurrencyId { get; set; }
        public int LengthUnitId { get; set; }
        public int WeightUnitId { get; set; }

    }
}
