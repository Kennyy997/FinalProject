using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccessLayer.Repositorys.Contracts;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProject.DataContext.Entities;

namespace DataAccessLayer.Repositorys
{
    public class EfCoreRepository<T> : IRepositoryasync<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        public EfCoreRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new Exception("Not found");
            }
            var removedEntity = _dbContext.Set<T>().Remove(entity);

            _dbContext.SaveChanges();
            return removedEntity.Entity;

        }

        public async Task<T> AddAsync(T entity)
        {
            var addedEntry = await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return addedEntry.Entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _dbContext.Set<T>().ToListAsync();
            return entities;

        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity == null)

            {
                throw new Exception("Not found");

            }

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var updatedEntry = _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return updatedEntry.Entity;
        }
    }
}
