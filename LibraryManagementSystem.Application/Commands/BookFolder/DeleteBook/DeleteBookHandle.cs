using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.DeleteBook;
public class DeleteBookHandle : IRequestHandler<DeleteBookCommand, Unit>
{
    private readonly IBookRepository _repository;

    public DeleteBookHandle(IBookRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var deleted = await _repository.Delete(request.Id);

        if (!deleted)
            throw new KeyNotFoundException("Livro não encontrado para exclusão.");

        return Unit.Value;
    }
}
