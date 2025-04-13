using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

}
