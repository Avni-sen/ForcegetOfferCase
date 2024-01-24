using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class PackageType : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
