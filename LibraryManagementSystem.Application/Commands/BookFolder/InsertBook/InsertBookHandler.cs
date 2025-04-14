using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Entities;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.InsertBook;
public class InsertBookHandler : IRequestHandler<InsertBookCommand, ResultViewModel<Book?>>
{
    private readonly IBookRepository _repository;

    public InsertBookHandler(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel<Book?>> Handle(InsertBookCommand request, CancellationToken cancellationToken)
    {
        var book = request.ToEntity();

        await _repository.Add(book);

        return ResultViewModel<Book?>.Success(book);
    }
}
