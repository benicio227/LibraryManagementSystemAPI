using LibraryManagementSystem.Core.Entities;

namespace LibraryManagementSystem.Application.Models;
public class LoanViewModel
{
    public LoanViewModel(int id, int idUser, int idBook, DateTime dateDue)
    {
        Id = id;
        IdUser = idUser;
        IdBook = idBook;
        DateDue = dateDue;
    }
    public int Id { get; private set; }
    public int IdUser { get; private set; }
    public int IdBook { get; private set; }
    public DateTime DateDue { get; private set; }

    public static LoanViewModel FromEntity(Loan loan)
    {
        return new LoanViewModel(loan.Id, loan.IdUser, loan.IdBook, loan.DateDue);
    }
}
