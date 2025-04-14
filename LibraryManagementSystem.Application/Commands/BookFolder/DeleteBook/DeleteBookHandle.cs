using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.DeleteBook;
public class DeleteBookHandle : IRequestHandler<DeleteBookCommand, ResultViewModel>
{
    private readonly IBookRepository _repository;

    public DeleteBookHandle(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var deleted = await _repository.Delete(request.Id);

        if (!deleted)
        {
            return ResultViewModel.Error("Livro não encontrado");
        }

        return ResultViewModel.Success();
    }
}
