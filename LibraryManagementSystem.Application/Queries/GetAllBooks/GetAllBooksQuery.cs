using LibraryManagementSystem.Application.Models;
using MediatR;

namespace LibraryManagementSystem.Application.Queries.GetAllBooks;
public class GetAllBooksQuery : IRequest<ResultViewModel<List<BookViewModel>>>
{
}
