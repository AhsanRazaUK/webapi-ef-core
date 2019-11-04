using Library.Core.SharedKernal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Core.Interfaces
{
    public interface IGenericWriteRepository
    {
        Task<T> InsertAsync<T>(T entity) where T : BaseEntity;
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
        Task<int> SaveAsyn<T>() where T : BaseEntity;
        Task<int> InsertAsync<T>(IEnumerable<T> entities) where T : BaseEntity;
        Task UpdateAsync<T>(T entity) where T : BaseEntity;
        Task DeleteAsync<T>(T entity) where T : BaseEntity;
    }
}
