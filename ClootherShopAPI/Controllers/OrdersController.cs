using ClootherShopAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class OrdersController : Controller
{


    /// <summary>
    /// Administrator only
    /// </summary>
    /// <returns></returns>
    [HttpGet("/order")]
    public IActionResult Orders()
    {
        return Ok();
    }

    /// <summary>
    /// Gets an order by id
    /// </summary>
    /// <param name="orderId"></param>
    /// <returns></returns>
    [HttpGet("/order/{id}")]
    public IActionResult OrderById([FromRoute] int orderId)
    {
        return Ok();
    }

    /// <summary>
    /// does not controlled by user/admin
    /// </summary>
    /// <returns></returns>
    [HttpPost("/order")]
    public IActionResult OrderAdd()
    {
        return Ok();
    }

    /// <summary>
    /// Does not controlled by user/admin
    /// </summary>
    /// <param name="orderId"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    [HttpPut("/order/{id}")]
    public IActionResult OrderPut([FromRoute] int orderId, [FromBody] OrderModel order)
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <returns></returns>
    [HttpDelete("/order/{id}")]
    public IActionResult OrderDelete([FromRoute] int orderId)
    {
        return NoContent();
    }
}
