using ClootherShopAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers
{
    public class AuthController : Controller
    {
        private DataContext db;

        public AuthController(DataContext context)
        {
            db = context;
        }

        [HttpGet("auth/login")]
        public IActionResult Login([FromBody] string login)
        {
            return Ok();
        }

        [HttpPost("auth/signin")]
        public IActionResult signin()
        {
            return Ok();
        }
    }
}
