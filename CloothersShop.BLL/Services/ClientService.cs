
using AutoMapper;
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;
using CloothersShop.BLL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CloothersShop.BLL.Services;

public class ClientService : ICientService
{
    public IUnitOfWork Database { get; set; }

    public ClientService(IUnitOfWork database)
    {
        Database = database;
    }

    public void AddClient(ClientDTO clientDTO)
    {
        var user = new ClientEntity()
        {
            Name = clientDTO.Name,
            PhoneNumber = clientDTO.PhoneNumber,
            DeliveryAddresss = clientDTO.DeliveryAddresss,
            Reference = clientDTO.Reference,
            OrderHistory = clientDTO.OrderHistory,
            FavoriteProducts = clientDTO.FavoriteProducts,
        };
        
        Database.Clients.Create(user);
        Database.Save();
    }

    public ClientDTO GetClient(int? id)
    {
        if (id == null)
            throw new ValidationException("id does't set");
        var client = Database.Clients.Get(id.Value);
        if (client == null)
            throw new ValidationException("the client does't found");

        return new ClientDTO()
        {
            Name = client.Name,
            DeliveryAddresss = client.DeliveryAddresss,
            FavoriteProducts= client.FavoriteProducts,
            OrderHistory= client.OrderHistory,
            PhoneNumber = client.PhoneNumber,
            Reference = client.Reference    
        };
    }

    public IEnumerable<ClientDTO> GetClients()
    {
        var mapper = new MapperConfiguration(conf => conf.CreateMap<ClientEntity, ClientDTO>()).CreateMapper();
        var res = mapper.Map<IEnumerable<ClientEntity>, List<ClientDTO>>(Database.Clients.GetAll());
        if (res is null)
            throw new NullReferenceException();
        return res;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

}
