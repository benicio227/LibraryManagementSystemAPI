using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Repositories;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.UserFolder.InsertUser;
public class InsertUserHandler : IRequestHandler<InsertUserCommand, ResultViewModel<UserViewModel>>
{
    private readonly IUserRepository _repository;

    public InsertUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResultViewModel<UserViewModel>> Handle(InsertUserCommand request, CancellationToken cancellationToken)
    {
        var user = request.ToEntity();

        var userExist = await _repository.Add(user);

        if (userExist is null)
        {
            return ResultViewModel<UserViewModel>.Error("Usuário não encontrado");
        }

        var model = UserViewModel.FromEntity(user);

        return ResultViewModel<UserViewModel>.Success(model);
    }
}
