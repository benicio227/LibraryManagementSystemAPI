namespace LibraryManagementSystem.Core.Entities;
public class Loan
{
    private Loan() { }
    public Loan(int idUser, int idBook, DateTime dateDue)
    {
        IdUser = idUser;
        IdBook = idBook;
        DateLoan = DateTime.Now;
        DateDue = dateDue;
    }
    public int Id { get; private set; }
    public int IdUser {  get; private set; }
    public int IdBook {  get; private set; }
    public DateTime DateLoan { get; private set; }
    public DateTime DateDue { get; private set; }
    public DateTime? DateReturned { get; protected set; }

    public User User { get; private set; }
    public Book Book { get; private set; }

    public int MarkAsReturned()
    {
        DateReturned = DateTime.Now;

        var atraso = (DateReturned.Value - DateDue).Days;

        return atraso > 0 ? atraso : 0;
    }
}
