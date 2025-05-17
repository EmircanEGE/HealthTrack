using HealthTrack.Core.Entities;
using HealthTrack.Core.Exceptions;
using HealthTrack.Core.Interfaces;
using HealthTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HealthTrack.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity ?? throw new NotFoundException(typeof(T).Name, id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T Entity)
        {
            await _context.Set<T>().AddAsync(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
