namespace LibraryManagementSystem.Core.Entities;
public class User
{
    private User() { }
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    public ICollection<Loan> Loans { get; private set; } = new List<Loan>();
}
