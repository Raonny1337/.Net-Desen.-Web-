﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UserCases.CreateUser
{
    public sealed record CreateUserResponse
    {
        public Guid Id { get; set; }

        public string? Email { get; set; }
        public string? Name { get; set; }  
    }
}
