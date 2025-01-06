using Microsoft.AspNetCore.Mvc;

namespace OnlineShopping.Controllers;

[ApiController]
[Route("api/shop")]
public class ShopController : ControllerBase
{
    [HttpGet("sayHello")]
    public ActionResult<string> SayHello()
    {
        return Ok("Hello world");
    }
    
    // Endpoints
    // 1) get products
    // 2) get users
    // 3) get user's orders
    // 4) create order
    // 5) add, delete, update
}