
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;

namespace CloothersShopAPI.BLL.Interfaces;

public interface IClientService
{
    void AddClient(ClientDTO user);
    ClientDTO GetClient(int? id);
    IEnumerable<ClientDTO> GetClients();
    IEnumerable<ClientDTO> GetClients(Func<ClientEntity, Boolean> predicate);
    void Dispose();
}
