using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class AuthController : Controller
{
    private DataContext db;

    public AuthController(DataContext context)
    {
        db = context;
    }


    /// <summary>
    /// Login endpoint for an old client/administrator
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPost("autth/login")]
    public IActionResult Login([FromBody] UserModel user)
    {

        return Ok();
    }

    /// <summary>
    /// Sign endpoint for a new client
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPost("auth/signin")]
    public IActionResult Signin([FromBody] UserModel user)
    {

        return Ok();
    }
}
