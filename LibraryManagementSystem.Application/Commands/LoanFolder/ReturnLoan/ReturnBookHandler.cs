using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.ReturnLoan;
public class ReturnBookHandler : IRequestHandler<ReturnBookCommand, ResultViewModel<string>>
{
    private readonly ILoanRepository _repository;

    public ReturnBookHandler(ILoanRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel<string>> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
    {
        var  loan = await _repository.Pacth(request.Id);

        if (loan is null)
        {
            return ResultViewModel<string>.Error("Empréstimo não encontrado");
        }

        var atraso = (loan.DateReturned!.Value - loan.DateDue).Days;

        if (atraso > 0)
        {
            return ResultViewModel<string>.Success($"Livro devolvido com {atraso} dias de atraso");
        }
        else
        {
            return ResultViewModel<string>.Success("Livro devolvido no prazo");
        }  
    }
}
