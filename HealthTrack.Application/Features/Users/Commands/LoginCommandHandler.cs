using HealthTrack.Core.Entities;
using HealthTrack.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace HealthTrack.Application.Features.Users.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IRepository<User> _userRepository;
        private readonly IJwtService _jwtService;

        public LoginCommandHandler(IJwtService jwtService, IRepository<User> userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetQueryable()
                .FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                throw new UnauthorizedAccessException("Email or password is incorrect");

            return _jwtService.GenerateToken(user);
        }
    }
}
