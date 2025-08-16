using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Academy.BusinessLogicLayer.Services;
using AutoMapper;
using DataAccessLayer.Repositorys.Contracts;
using MovieFinalProjectBusinessLogicLayer.Dto_s;
using MovieFinalProjectBusinessLogicLayer.Services.Contracts;

namespace MovieFinalProjectBusinessLogicLayer.Services
{
    public class MovieManager : CrudManager<MovieDto, MovieCreateDto, MovieUpdateDto, Movie>, IMovieService
    {
        public MovieManager(IRepositoryasync<Movie> repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
