using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.BusinessLogicLayer.Services;
using AutoMapper;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.BusinessLogicLayer.Dtos;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;
using MovieFinalProjectBusinessLogicLayer.Services.Contracts;

namespace MovieFinalProjectBusinessLogicLayer.Services
{
    public class RatingManager : CrudManager<RatingDto, RatingCreateDto, RatingUpdateDto, Rating>, IRatingService
    {
        public RatingManager(IRepositoryasync<Rating> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
    
}
