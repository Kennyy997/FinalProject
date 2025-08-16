using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProject.DataAccessLayer;

namespace DataAccessLayer.Repositorys
{
    public class QualityRepository : EfCoreRepository<Quality>, IQualityRepository
    {
        public QualityRepository(AppDbContext dbContext) : base(dbContext)
        {

        }


    }
}
