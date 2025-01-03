using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Domain;

namespace TaskManagerSystem.Application.Interface.Repository
{
    public interface IGeneriRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAysnc();
        Task<T> GetByIdAsync(Guid Id);
        Task<T> AddAsync(T entity);
    }
}
