using MediatR;

namespace HealthTrack.Application.Features.Users.Commands
{
    public record CreateUserCommand(string Name, string Email, string Password) : IRequest<int>;
    {
    }
}
