
using ClootherShopAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class CategoriesController : Controller
{

    /// <summary>
    /// Навигационная страница со всеми категориями
    /// </summary>
    /// <returns></returns>

    [HttpGet("/categories")]
    public IActionResult Categories()
    {
        return Ok();
    }

    /// <summary>
    /// Категория по номеру
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    [HttpGet("/categories/{id}")]
    public IActionResult CategoriyById([FromRoute] int category)
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <returns></returns>
    [HttpPost("/categories")]
    public IActionResult CategoryAdd()
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    [HttpPut("/categories/{id}")]
    public IActionResult CategoryPut([FromBody] int categoryId, CategoryModel category)
    {
        return Ok();
    }

    /// <summary>
    /// Administrator only
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    [HttpDelete("/categories/{if}")]
    public IActionResult CategoryDelete([FromBody] int categoryId)
    {
        return NoContent();
    }
}
