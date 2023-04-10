
using ClootherShopAPI.BLL.Model;

namespace CloothersShop.BLL.Interfaces;

public interface ICientService
{
    void AddClient(ClientDTO user);
    ClientDTO GetClient(int? id);
    IEnumerable<ClientDTO> GetClients();
    void Dispose();
}
