using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Queries.GetAllBooks;
public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
{
    private readonly IBookRepository _repository;

    public GetAllBooksHandler(IBookRepository repository)
    {
        _repository = repository; 
    }
    public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _repository.GetAll();

        var model = books.Select(BookViewModel.FromEntity).ToList();

        return model;
    }
}
