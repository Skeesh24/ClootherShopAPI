using ClootherShopAPI.BLL.Model;
using CloothersShop.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class ProductsController : Controller
{
    private ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }


    /// <summary>
    /// All products from category
    /// </summary>
    /// <returns></returns>
    [HttpGet("products")]
    public IActionResult ProductsByCategory([FromBody] int categoryId)
    {
        return Ok();
    }

    /// <summary>
    /// One product by id
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [HttpGet("products/{id}")]
    public IActionResult ProductById([FromRoute] int productId)
    {
        Response.StatusCode = 200;
        var product = _productService.GetProduct(productId);
        if (product == null)
            throw new NullReferenceException();
        return Json(product);
    }

    /// <summary>
    /// Adminstrator only
    /// </summary>
    /// <returns></returns>
    [HttpPost("/products")]
    public IActionResult ProductAdd([FromBody] ProductDTO productDTO)
    {
        if (productDTO == null)
            throw new NullReferenceException();

        _productService.AddProduct(productDTO);

        return Created("/products", productDTO);
    }

    /// <summary>
    /// Adminstrator only
    /// </summary>
    /// <returns></returns>
    [HttpPut("products/{id}")]
    public IActionResult ProductEdit([FromBody] int productId, [FromBody] ProductDTO product)
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [HttpDelete("products/{id}")]
    public IActionResult ProductDelete(int productId)
    {
        return NoContent();
    }
}
