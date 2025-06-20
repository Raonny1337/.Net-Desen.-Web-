﻿using CleanArch.Application.UseCases.UpdateUser;
using MediatR;

public sealed record UpdateUserRequest(Guid Id, string Email, string Name) : IRequest<UpdateUserResponse>;