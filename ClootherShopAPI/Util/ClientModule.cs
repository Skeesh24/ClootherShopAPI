using CloothersShopAPI.BLL.Interfaces;
using CloothersShopAPI.BLL.Services;
using Ninject.Modules;

namespace ClootherShopAPI.WEB.Util
{
    public class ClientModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClientService>().To<ClientService>();
        }
    }
}
