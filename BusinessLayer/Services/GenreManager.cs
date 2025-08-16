using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.BusinessLogicLayer.Services;
using AutoMapper;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;
using MovieFinalProjectBusinessLogicLayer.Services.Contracts;

namespace MovieFinalProjectBusinessLogicLayer.Services
{
    public class GenreManager : CrudManager<GenreDto, GenreCreateDto, GenreUpdateDto, Genre>, IGenreService
    {
        public GenreManager(IRepositoryasync<Genre> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
