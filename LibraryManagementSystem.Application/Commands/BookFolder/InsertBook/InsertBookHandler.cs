using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.InsertBook;
public class InsertBookHandler : IRequestHandler<InsertBookCommand, ResultViewModel<BookViewModel>>
{
    private readonly IBookRepository _repository;

    public InsertBookHandler(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel<BookViewModel>> Handle(InsertBookCommand request, CancellationToken cancellationToken)
    {
        var book = request.ToEntity();

        var bookExist = await _repository.Add(book);

        if (bookExist is null)
        {
            return ResultViewModel<BookViewModel>.Error("Livro não encontrado");
        }

        var model = BookViewModel.FromEntity(book); 

        return ResultViewModel<BookViewModel>.Success(model);
    }
}
