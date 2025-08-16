using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.DataAccessLayer;

namespace DataAccessLayer.Repositorys;

public class MovieRepository : EfCoreRepository<Movie>, IMovieRepository
{
    public MovieRepository(AppDbContext dbContext) : base(dbContext) 
    {

    }

}

