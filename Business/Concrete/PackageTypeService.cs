using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using ForcegetOfferCase.Application.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcegetOfferCase.Application.Services.Concrete
{
    public class PackageTypeService : IPackageTypeService
    {
        IPackageTypeRepository _packageTypeRepository;

        public PackageTypeService(IPackageTypeRepository packageTypeRepository)
        {
            _packageTypeRepository = packageTypeRepository;
        }

        public IResult Add(PackageType packageType)
        {
            _packageTypeRepository.Add(packageType);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(PackageType packageType)
        {
            _packageTypeRepository.Add(packageType);
            return new SuccessResult("Silme Başarılı");
        }

        public IDataResult<List<PackageType>> GetAll()
        {
            return new SuccessDataResult<List<PackageType>>(_packageTypeRepository.GetAll());
        }

        public IDataResult<PackageType> GetById(int id)
        {
            return new SuccessDataResult<PackageType>(_packageTypeRepository.Get(x => x.Id == id));
        }

        public IResult Update(PackageType packageType)
        {
            _packageTypeRepository.Add(packageType);
            return new SuccessResult("Güncelleme Başarılı");
        }
    }
}
