using Library.Core.SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Core.Interfaces
{
    public interface IGenericReadRepository
    {
        Task<T> GetByIdAsync<T>(Guid id) where T : BaseEntity;
        Task<T> GetAsync<T>(ISpecification<T> spec = null) where T : BaseEntity;
        IQueryable<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseEntity;        
        Task<int> CountAsync<T>(ISpecification<T> spec = null) where T : BaseEntity;
        Task<bool> IfExistsAsync<T>(ISpecification<T> spec = null) where T : BaseEntity;
        Task<IReadOnlyList<T>> ListAsync<T>(ISpecification<T> spec = null) where T : BaseEntity;
    }
}
