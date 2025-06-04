using AutoMapper;
using CleanArch.Application.UseCases.DeleteUser;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UseCases.DeleteUser;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}