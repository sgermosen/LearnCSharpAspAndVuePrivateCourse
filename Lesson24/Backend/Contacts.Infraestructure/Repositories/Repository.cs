using Contacts.Application.Contracts;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Infraestructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly ApplicationContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }


        public async Task<T> Add(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _entities.FindAsync(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
         
    }

}
