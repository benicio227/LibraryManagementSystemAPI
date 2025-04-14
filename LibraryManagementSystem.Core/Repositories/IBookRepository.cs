using LibraryManagementSystem.Core.Entities;

namespace LibraryManagementSystem.Core.Repositories;
public interface IBookRepository
{
    public Task<Book?> Add(Book book);
    public Task<List<Book>> GetAll();
    public Task<Book?> GetById(int id);
    public Task<bool> Delete(int id);
}
