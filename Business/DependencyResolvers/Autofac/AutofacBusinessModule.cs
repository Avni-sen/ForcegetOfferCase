using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using ForcegetOfferCase.Application.Services.Abstract;
using ForcegetOfferCase.Application.Services.Concrete;
using ForcegetOfferCase.DataAccess.Repositories.Concrete;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityService>().As<ICityService>().SingleInstance();
            builder.RegisterType<CityRepository>().As<ICityRepository>().SingleInstance();

            builder.RegisterType<CountryService>().As<ICountryService>().SingleInstance();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().SingleInstance();

            builder.RegisterType<CurrencyService>().As<ICurrencyService>().SingleInstance();
            builder.RegisterType<CurrencyRepository>().As<ICurrencyRepository>().SingleInstance();

            builder.RegisterType<IncotermService>().As<IIncotermService>().SingleInstance();
            builder.RegisterType<IncotermRepository>().As<IIncotermRepository>().SingleInstance();

            builder.RegisterType<ModeService>().As<IModeService>().SingleInstance();
            builder.RegisterType<ModeRepository>().As<IModeRepository>().SingleInstance();

            builder.RegisterType<MovementTypeService>().As<IMovementTypeService>().SingleInstance();
            builder.RegisterType<MovementTypeRepository>().As<IMovementTypeRepository>().SingleInstance();

            builder.RegisterType<OfferService>().As<IOfferService>().SingleInstance();
            builder.RegisterType<OfferRepository>().As<IOfferRepository>().SingleInstance();

            builder.RegisterType<PackageTypeService>().As<IPackageTypeService>().SingleInstance();
            builder.RegisterType<PackageTypeRepository>().As<IPackageTypeRepository>().SingleInstance();

         
            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<AuthService>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
