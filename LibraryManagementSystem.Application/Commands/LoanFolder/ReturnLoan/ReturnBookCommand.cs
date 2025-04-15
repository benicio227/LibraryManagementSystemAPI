using LibraryManagementSystem.Application.Models;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
public class ReturnBookCommand : IRequest<ResultViewModel<string>>
{
    public ReturnBookCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
