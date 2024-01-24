using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Currency : BaseEntity, IEntity
    {
        public string ShortName { get; set; }
        public string Name { get; set; }
    }
}
