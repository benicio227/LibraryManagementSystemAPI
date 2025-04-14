using FluentValidation;
using LibraryManagementSystem.Application.Commands.UserFolder.InsertUser;
using Microsoft.Extensions.Hosting;

namespace LibraryManagementSystem.Application.Validators;
public class CreateUserValidator : AbstractValidator<InsertUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty()
                .WithMessage("Nome não pode ser vazio");

        RuleFor(u => u.Email)
            .EmailAddress()
                .WithMessage("E-mail inválido");

    }
}
