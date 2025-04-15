using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Entities;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.LoanFolder.InsertLoan;
public class InsertLoanCommand : IRequest<ResultViewModel<LoanViewModel>>
{
    public int IdUser { get; set; }
    public int IdBook { get; set; }
    public DateTime DateDue { get; set; }

    public Loan ToEntity()
    {
        return new Loan(IdUser, IdBook, DateDue);
    }
}
