using HealthTrack.Core.Entities;

namespace HealthTrack.Core.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
