using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;

namespace DataAccessLayer.Repositorys.Contracts
{
   public interface IRepositoryasync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}
