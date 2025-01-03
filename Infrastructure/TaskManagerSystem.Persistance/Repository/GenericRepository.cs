using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Domain;
using TaskManagerSystem.Persistance.Context;

namespace TaskManagerSystem.Persistance.Repository
{
    public class GenericRepository<T> : IGeneriRepository<T> where T : BaseEntity
    {
        private readonly TaskManagerSystemContext _appContext;
        public GenericRepository(TaskManagerSystemContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _appContext.Set<T>().AddAsync( entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAysnc()
        {
            return await _appContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _appContext.Set<T>().FindAsync(Id);
        }
    }
}
