using LibraryManagementSystem.Application.Commands.LoanFolder.InsertLoan;
using LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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

        return Created(string.Empty, result);
    }

    [HttpPatch]
    public async Task<IActionResult> Patch(int id)
    {
        var result = await _mediator.Send(new ReturnBookCommand(id));

        return Ok();
    }
}
