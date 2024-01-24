using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Incoterm : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
