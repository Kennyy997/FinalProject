using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositorys;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProject.Repositorys
{
    public class ActorRepository : EfCoreRepository<Actor>, IActorRepository
    {
        public ActorRepository(AppDbContext dbContext) : base(dbContext)
        {

        }


    }
}
