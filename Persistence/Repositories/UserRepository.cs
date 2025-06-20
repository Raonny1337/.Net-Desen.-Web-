﻿using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }
    }
}
