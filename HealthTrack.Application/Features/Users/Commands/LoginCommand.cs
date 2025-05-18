using MediatR;

namespace HealthTrack.Application.Features.Users.Commands;
public record LoginCommand(string Email, string Password) : IRequest<string>;

