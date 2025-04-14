using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.InsertLoan;
public class InsertLoanHandler : IRequestHandler<InsertLoanCommand, LoanViewModel>
{
    private readonly ILoanRepository _repository;

    public InsertLoanHandler(ILoanRepository repository)
    {
        _repository = repository;
    }
    async Task<LoanViewModel> IRequestHandler<InsertLoanCommand, LoanViewModel>.Handle(InsertLoanCommand request, CancellationToken cancellationToken)
    {
        var loan = request.ToEntity();

        await _repository.Add(loan);

        return LoanViewModel.FromEntity(loan);
    }
}
