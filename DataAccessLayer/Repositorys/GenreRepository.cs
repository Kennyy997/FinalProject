using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProject.DataContext.Entities;

namespace DataAccessLayer.Repositorys
{
    public class GenreRepository : EfCoreRepository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

    }
}
