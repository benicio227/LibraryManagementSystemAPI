using LibraryManagementSystem.Core.Entities;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;
public class BookRepository : IBookRepository
{
    private readonly LibraryManagementSystemDbContext _context;

    public BookRepository(LibraryManagementSystemDbContext context)
    {
        _context = context;
    }
    public async Task<Book?> Add(Book book)
    {
        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();

        return book;
    }

    public async Task<bool> Delete(int id)
    {
        var book = await _context.Books.SingleOrDefaultAsync(b => b.Id == id);

        if (book == null)
            return false;

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Book>> GetAll()
    {
        var books = await _context.Books.ToListAsync();

        return books;
    }

    public async Task<Book?> GetById(int id)
    {
        var book = await _context.Books.SingleOrDefaultAsync(b => b.Id == id);

        return book;
    }
}
