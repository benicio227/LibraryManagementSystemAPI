using LibraryManagementSystem.Application.Commands.BookFolder.InsertBook;
using LibraryManagementSystem.Application.Queries.GetAllBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;
    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(InsertBookCommand command)
    {
        var result = await _mediator.Send(command);

        return Created(string.Empty, result);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllBooksQuery();

        var result = await _mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("{id}")]
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
