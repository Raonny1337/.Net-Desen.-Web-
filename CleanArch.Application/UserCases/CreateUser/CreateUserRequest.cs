﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UserCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;
}
