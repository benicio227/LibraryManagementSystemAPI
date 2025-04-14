using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
public class ReturnBookHandler : IRequestHandler<ReturnBookCommand, string>
{
    private readonly ILoanRepository _repository;

    public ReturnBookHandler(ILoanRepository repository)
    {
        _repository = repository;
    }
    public async Task<string> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
    {
        var  loan = await _repository.Pacth(request.Id);

        var atraso = (loan.DateReturned!.Value - loan.DateDue).Days;

        if (atraso > 0)
        {
            return $"Livro devolvido com {atraso} dias de atraso";
        }
        else
        {
            return "Livro devolvido no prazo";
        }

    }
}
