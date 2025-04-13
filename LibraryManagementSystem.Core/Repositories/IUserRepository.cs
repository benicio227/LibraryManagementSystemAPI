using LibraryManagementSystem.Core.Entities;

namespace LibraryManagementSystem.Core.Repositories;
public interface IUserRepository
{
    public Task<User?> Add(User user);
}
