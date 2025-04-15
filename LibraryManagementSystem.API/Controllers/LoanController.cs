using LibraryManagementSystem.Application.Commands.LoanFolder.InsertLoan;
using LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LibraryManagementSystem.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LoanController : ControllerBase
{
    private readonly IMediator _mediator;
    public LoanController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Post(InsertLoanCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result.Message);
        }

        return Created(string.Empty, result);
    }

    [HttpPatch]
    public async Task<IActionResult> Patch(int id)
    {
        var result = await _mediator.Send(new ReturnBookCommand(id));

        if (!result.IsSuccess)
        {
            return BadRequest(result.Message);
        }

        return Ok(new { message = result.Data });
    }
}
