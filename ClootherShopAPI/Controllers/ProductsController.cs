using ClootherShopAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class ProductsController : Controller
{


    /// <summary>
    /// All products from category
    /// </summary>
    /// <returns></returns>
    [HttpGet("/products")]
    public IActionResult ProductsByCategory([FromBody] int categoryId)
    {
        return Ok();
    }

    /// <summary>
    /// One product by id
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [HttpGet("/products/{id}")]
    public IActionResult ProductById([FromRoute] int productId)
    {
        return Ok();
    }

    /// <summary>
    /// Adminstrator only
    /// </summary>
    /// <returns></returns>
    [HttpPost("/products")]
    public IActionResult ProductAdd()
    {
        return Ok();
    }

    /// <summary>
    /// Adminstrator only
    /// </summary>
    /// <returns></returns>
    [HttpPut("products/{id}")]
    public IActionResult ProductEdit([FromRoute] int productId, [FromBody] ProductModel product)
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [HttpDelete("products/{id}")]
    public IActionResult ProductDelete([FromRoute] int productId)
    {
        return NoContent();
    }
}
