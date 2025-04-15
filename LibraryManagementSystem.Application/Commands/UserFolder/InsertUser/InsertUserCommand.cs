using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Entities;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.UserFolder.InsertUser;
public class InsertUserCommand : IRequest<ResultViewModel<UserViewModel>>
{
    public string Name { get; set; }
    public string Email { get; set; }

    public User ToEntity()
    {
        return new User(Name, Email);
    }
}
