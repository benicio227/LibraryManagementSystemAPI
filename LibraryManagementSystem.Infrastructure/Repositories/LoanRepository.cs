using LibraryManagementSystem.Core.Entities;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;
public class LoanRepository : ILoanRepository
{
    private readonly LibraryManagementSystemDbContext _context;

    public LoanRepository(LibraryManagementSystemDbContext context)
    {
        _context = context;
    }
    public async Task<Loan?> Add(Loan loan)
    {
        await _context.Loans.AddAsync(loan);
        await _context.SaveChangesAsync();

        return loan;
    }

    public async Task<Loan?> Pacth(int id)
    {
        var loan = await _context.Loans.FirstOrDefaultAsync(l => l.Id == id);

        if (loan is null)
        {
            return null;
        }

        loan.MarkAsReturned();

        await _context.SaveChangesAsync();

        return loan;
    }
}
