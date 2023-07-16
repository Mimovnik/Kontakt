using FluentValidation;

namespace Kontakt.Application.Authentication.Commands.Register;

public class RegisterCommanndValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommanndValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
        RuleFor(x => x.Password).NotEmpty();
    }
}