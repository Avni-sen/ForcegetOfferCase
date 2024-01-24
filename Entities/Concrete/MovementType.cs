using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class MovementType : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
