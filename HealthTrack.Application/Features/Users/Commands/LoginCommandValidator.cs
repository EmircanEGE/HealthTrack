using FluentValidation;

namespace HealthTrack.Application.Features.Users.Commands
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress()
                .WithMessage("Email is required and must be a valid email address.");
            RuleFor(x => x.Password).NotEmpty()
                .WithMessage("Password is required.");
        }
    }
}
