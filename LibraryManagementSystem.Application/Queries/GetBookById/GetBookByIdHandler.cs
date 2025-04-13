using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Queries.GetBookById;
public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, BookViewModel>
{
    private readonly IBookRepository _repository;

    public GetBookByIdHandler(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<BookViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        var book = await _repository.GetById(request.Id);

        if (book is null)
        {
            throw new KeyNotFoundException("Livro não encontrado.");
        }

        var model = BookViewModel.FromEntity(book);

        return model;
    }
}
