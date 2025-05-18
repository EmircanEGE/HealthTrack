using AutoMapper;
using HealthTrack.Application.DTOs;
using HealthTrack.Application.Features.Users.Commands;
using HealthTrack.Core.Entities;

namespace HealthTrack.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<CreateUserCommand, User>();
        }
    }
}
