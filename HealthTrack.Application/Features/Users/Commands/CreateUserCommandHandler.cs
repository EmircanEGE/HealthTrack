using HealthTrack.Core.Entities;
using HealthTrack.Core.Interfaces;
using MediatR;

namespace HealthTrack.Application.Features.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IRepository<User> _userRepository;

        public CreateUserCommandHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                PasswordHash = request.Password
            };
            await _userRepository.AddAsync(user);
            return user.Id;
        }
    }
}
