using LibraryManagementSystem.Core.Entities;

namespace LibraryManagementSystem.Core.Repositories;
public interface ILoanRepository
{
    public Task<Loan?> Add(Loan loan);
    public Task<Loan?> Pacth(int id);
}
