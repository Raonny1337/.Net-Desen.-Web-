using CleanArch.Application.UserCases.GetAllUser;
using MediatR;

namespace CleanArch.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
