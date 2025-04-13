using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LoanController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPatch]
    public IActionResult Patch()
    {
        return Ok();
    }
}
