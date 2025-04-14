using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.DeleteBook;
public class DeleteBookCommand : IRequest<Unit>
{
    public DeleteBookCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
