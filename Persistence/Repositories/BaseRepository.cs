using CleanArch.Domain.Entities;
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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context) { Context = context; }
        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(entity);
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.UtcNow;
            Context.Set<T>().Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}