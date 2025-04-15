using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.InsertLoan;
public class InsertLoanHandler : IRequestHandler<InsertLoanCommand, ResultViewModel<LoanViewModel>>
{
    private readonly ILoanRepository _repository;

    public InsertLoanHandler(ILoanRepository repository)
    {
        _repository = repository;
    }
    async Task<ResultViewModel<LoanViewModel>> IRequestHandler<InsertLoanCommand, ResultViewModel<LoanViewModel>>.Handle(InsertLoanCommand request, CancellationToken cancellationToken)
    {
        var loan = request.ToEntity();

        var loanExist = await _repository.Add(loan);

        if (loanExist is null)
        {
            return ResultViewModel<LoanViewModel>.Error("Empréstimo não encontrado");
        }

        var model =  LoanViewModel.FromEntity(loan);

        return ResultViewModel<LoanViewModel>.Success(model);
    }
}
