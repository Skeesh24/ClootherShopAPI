using ClootherShopAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class ClientsController : Controller
{


    /// <summary>
    /// Gets all clients [administrator only]
    /// </summary>
    /// <returns></returns>
    [HttpGet("/clients")]
    public IActionResult Clients()
    {
        return Ok();
    }

    /// <summary>
    /// Get a client by id [administrator only]
    /// </summary>
    /// <param name="clientId"></param>
    /// <returns></returns>
    [HttpGet("/clients/{id}")]
    public IActionResult ClientById([FromRoute] int clientId)
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
    public IActionResult ClientPut([FromBody] int clientId, UserModel client)
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
