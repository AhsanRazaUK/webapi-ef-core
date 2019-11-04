using Library.Core.Interfaces;
using Library.Core.SharedKernal;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
    public class GenericRepository : IGenericReadRepository
    {
        private readonly LibraryDbContext dbContext;

        public GenericRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> IfExistsAsync<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            return await ApplySpecification(spec).AnyAsync();
        }
        public async Task<int> CountAsync<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            return await ApplySpecification(spec).CountAsync<T>();
        }

        private IQueryable<T> ApplySpecification<T>(ISpecification<T> spec) where T : BaseEntity
        {
            return SpecificationEvaluator<T>.GetQuery(dbContext.Set<T>().AsQueryable(), spec);
        }

        public IQueryable<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            return ApplySpecification(spec).AsNoTracking();
        }

        public async Task<T> GetByIdAsync<T>(Guid id) where T : BaseEntity
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync<T>() where T : BaseEntity
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            return await GetAll(spec).ToListAsync();
        }

        public async Task<T> GetAsync<T>(ISpecification<T> spec = null) where T : BaseEntity
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }
    }
}
