using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface IBaseRepository<T, P>
    {
        Task<List<T>> GetAllAsync();
        Task<T> CreateAsync(T model);
        Task<T?> GetByIdAsync(int id);
        Task<T?> DeleteAsync(int id);
        Task<T?> UpdateAsync(int id, P updateDto);
    }
}