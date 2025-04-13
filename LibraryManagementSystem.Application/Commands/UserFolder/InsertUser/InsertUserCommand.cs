using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Entities;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.UserFolder.InsertUser;
public class InsertUserCommand : IRequest<UserViewModel>
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public User ToEntity()
    {
        return new User(Name, Email);
    }
}
