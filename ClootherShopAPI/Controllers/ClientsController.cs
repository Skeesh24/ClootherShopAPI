using AutoMapper;
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;
using CloothersShopAPI.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class ClientsController : Controller
{
    IClientService _clientService;

    public ClientsController(IClientService clientService)
    {
        this._clientService = clientService;
    }



    /// <summary>
    /// Gets all clients [administrator only]
    /// </summary>
    /// <returns></returns>
    [HttpGet("/clients")]
    public IActionResult Clients()
    {
        Response.StatusCode = 200;
        var clientsDTO = _clientService.GetClients();
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ClientDTO, ClientEntity>()).CreateMapper();
        var clients = mapper.Map<IEnumerable<ClientDTO>, List<ClientEntity>>(_clientService.GetClients());
        return Json(clients);
    }

    /// <summary>
    /// Get a client by id [administrator only]
    /// </summary>
    /// <param name="clientId"></param>
    /// <returns></returns>
    [HttpGet("/clients/{id}")]
    public IActionResult ClientById([FromBody] int clientId)
    {
        return Ok();
    }

    /// <summary>
    /// edit profile
    /// </summary>
    /// <param name="clientId"></param>
    /// <param name="client"></param>
    /// <returns></returns>
    [HttpPut("/clients/{id}")]
    public IActionResult ClientPut([FromBody] int clientId, ClientDTO client)
    {
        return Ok();
    }

    /// <summary>
    /// Delete acc 
    /// </summary>
    /// <param name="clientId"></param>
    /// <returns></returns>
    [HttpDelete("/clients/{id}")]
    public IActionResult ClientDelete([FromBody] int clientId)
    {
        return NoContent();
    }
}
