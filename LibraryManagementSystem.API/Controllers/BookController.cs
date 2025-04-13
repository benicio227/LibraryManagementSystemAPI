using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetById()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }
}
