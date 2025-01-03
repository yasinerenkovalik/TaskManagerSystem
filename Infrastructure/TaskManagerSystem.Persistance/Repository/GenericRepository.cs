using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Domain;
using TaskManagerSystem.Domain.Entities;
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
            entity.IsDeleted = false; 
            entity.CreateDate = DateTime.UtcNow;
            return entity;
        }

        public async Task<T> DeleteAsync(Guid id)
        {
          
            var entity = await _appContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

      
            if (entity == null)
            {
                throw new Exception("Kayıt bulunamadı.");
            }

            entity.IsDeleted = true;

 
            _appContext.Set<T>().Update(entity);
            await _appContext.SaveChangesAsync();

            return entity;
        }

  

        public async Task<List<T>> GetAllAysnc()
        {

            return await _appContext.Set<T>().Where(x => x.IsDeleted==false).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _appContext.Set<T>().FirstOrDefaultAsync(x => x.Id == Id && x.IsDeleted == false);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _appContext.Set<T>().Update(entity);
            await _appContext.SaveChangesAsync();

            return entity;
        }
    }
}
