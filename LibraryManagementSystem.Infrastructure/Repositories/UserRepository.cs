using LibraryManagementSystem.Core.Entities;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Infrastructure.Persistence;

namespace LibraryManagementSystem.Infrastructure.Repositories;
public class UserRepository : IUserRepository
{
    public readonly LibraryManagementSystemDbContext _context;

    public UserRepository(LibraryManagementSystemDbContext context)
    {
        _context = context;
    }
    public async Task<User?> Add(User user)
    {
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }
}
