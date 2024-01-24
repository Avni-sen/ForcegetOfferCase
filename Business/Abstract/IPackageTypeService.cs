using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Abstract
{
    public interface IPackageTypeService
    {
        IDataResult<PackageType> GetById(int id);
        IDataResult<List<PackageType>> GetAll();
        IResult Add(PackageType packageType);
        IResult Update(PackageType packageType);
        IResult Delete(PackageType packageType);
    }
}
