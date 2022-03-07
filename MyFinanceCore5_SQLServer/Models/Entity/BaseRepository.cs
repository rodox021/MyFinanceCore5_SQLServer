using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.Entity
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }



        //----------------------------Add Async-------------------------------
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        //----------------------------Delete Async-------------------------------
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        //----------------------------GetAll Async-------------------------------
        public virtual async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        //----------------------------GetById Async-------------------------------
        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        

        //----------------------------Update Async-------------------------------
        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

            
        }
    }
}
