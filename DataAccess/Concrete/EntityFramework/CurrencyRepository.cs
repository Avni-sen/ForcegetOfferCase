using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ForcegetOfferCase.DataAccess.Repositories.Concrete
{
    public class CurrencyRepository : EfEntityRepositoryBase<Currency, ForcegetOfferCaseContext>, ICurrencyRepository
    {
    }
}
