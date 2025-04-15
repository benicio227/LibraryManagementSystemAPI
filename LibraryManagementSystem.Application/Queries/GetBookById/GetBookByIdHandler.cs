using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Queries.GetBookById;
public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, ResultViewModel<BookViewModel>>
{
    private readonly IBookRepository _repository;

    public GetBookByIdHandler(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel<BookViewModel>> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        var book = await _repository.GetById(request.Id);

        if (book is null)
        {
            return ResultViewModel<BookViewModel>.Error("Livro não encontrado.");
        }

        var model = BookViewModel.FromEntity(book);

        return ResultViewModel<BookViewModel>.Success(model);
    }
}
