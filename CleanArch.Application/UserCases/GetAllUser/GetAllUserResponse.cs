using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UserCases.GetAllUser
{
    public sealed record GetAllUserResponse
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? User { get; set; }
    }
}
