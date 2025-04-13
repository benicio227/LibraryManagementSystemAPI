using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.UserFolder.InsertUser;
public class InsertUserHandler : IRequestHandler<InsertUserCommand, UserViewModel>
{
    private readonly IUserRepository _repository;

    public InsertUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }
    public async Task<UserViewModel> Handle(InsertUserCommand request, CancellationToken cancellationToken)
    {
        var user = request.ToEntity();

        await _repository.Add(user);

        return UserViewModel.FromEntity(user);
    }
}
