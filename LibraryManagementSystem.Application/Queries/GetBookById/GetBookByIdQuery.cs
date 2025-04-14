using LibraryManagementSystem.Application.Models;
using MediatR;

namespace LibraryManagementSystem.Application.Queries.GetBookById;
public class GetBookByIdQuery : IRequest<ResultViewModel<BookViewModel>>
{
    public GetBookByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
