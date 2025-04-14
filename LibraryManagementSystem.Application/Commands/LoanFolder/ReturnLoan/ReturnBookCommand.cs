using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
public class ReturnBookCommand : IRequest<string>
{
    public ReturnBookCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
