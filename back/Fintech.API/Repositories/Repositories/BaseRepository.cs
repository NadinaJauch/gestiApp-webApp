using Abstractions.IRepositories;
using db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _entities;
        private readonly GestionAhorrosContext _db;

        public BaseRepository(GestionAhorrosContext db)
        {
            _db = db; 
            _entities = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
        }
    }
}
