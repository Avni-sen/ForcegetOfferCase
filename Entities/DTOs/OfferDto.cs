using Core.Entities;
using Entities.Concrete;
using ForcegetOfferCase.Entities.Concrete;

namespace ForcegetOfferCase.Entities.Dtos
{
    public class OfferDto : Offer, IDto
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string ModeName { get; set; }
        public string CurrencyName { get; set; }
        public string IncotermName { get; set; }
        public string MovementTypeName { get; set; }
        public string PackageTypeName { get; set; }
        public string LengthUnit { get; set; }
        public string WeightUnit { get; set; }
    }
}
