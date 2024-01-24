using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovementTypeRepository : EfEntityRepositoryBase<MovementType, ForcegetOfferCaseContext>, IMovementTypeRepository
    {
    }
}
