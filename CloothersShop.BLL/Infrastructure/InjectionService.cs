
using ClootherShopAPI.DAL.Interfaces;
using ClootherShopAPI.DAL.Repositories;
using Ninject.Modules;

namespace CloothersShopAPI.BLL.Infrastructure;

public class InjectionService : NinjectModule
{
    private string connectioString;

    public InjectionService(string connectioString)
    {
        this.connectioString = connectioString;
    }

    public override void Load()
    {
        Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectioString);
    }
}
