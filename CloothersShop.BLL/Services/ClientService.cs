
using AutoMapper;
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;
using CloothersShopAPI.BLL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CloothersShopAPI.BLL.Services;

public class ClientService : IClientService
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
        var listForMap = Database.Clients.GetAll();

        if (listForMap == null)
            throw new NullReferenceException();
        
        var res = mapper.Map<IEnumerable<ClientEntity>, List<ClientDTO>>(listForMap);
        
        if (res is null)
            throw new NullReferenceException();
        
        return res;
    }

    public IEnumerable<ClientDTO> GetClients(Func<ClientEntity, Boolean> predicate)
    {
        var mapper = new MapperConfiguration(conf => conf.CreateMap<ClientEntity, ClientDTO>()).CreateMapper();
        var listForMap = Database.Clients.GetAll(predicate);

        if (listForMap == null)
            throw new NullReferenceException();

        var res = mapper.Map<IEnumerable<ClientEntity>, List<ClientDTO>>(listForMap);

        if (res == null)
            throw new NullReferenceException();

        return res;
    }

    public void Dispose()
    {
        Database.Dispose();
    }

}
