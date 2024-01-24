

using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class City : BaseEntity,IEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
