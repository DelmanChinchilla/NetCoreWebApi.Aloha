using Microsoft.EntityFrameworkCore;
using NetCoreWebApi.Aloha.Base;
using NetCoreWebApi.Aloha.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly AlohaDataContext _alohaDataContext;
        private readonly DbSet<T> entities;

        public GenericRepository(AlohaDataContext alohaDataContext)
        {
            this._alohaDataContext = alohaDataContext;
            entities = alohaDataContext.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await entities.AddAsync(entity);
            
        }

        public async Task DeleteAsync(int id)
        {
            T entity = await GetSingleAsync(id);
            entities.Remove(entity);
            
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetFilteredAsync(int id)
        {
            return await entities.Where(x=>x.Id==id).ToListAsync();
        }

        public async Task<T> GetSingleAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public void UpdateAsync(T entity)
        {
             entities.Update(entity);
            
        }

    }
}
