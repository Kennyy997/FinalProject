using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface IMovieService: ICrudService<MovieDto, MovieCreateDto, MovieUpdateDto, Movie>
    {
        Task<List<MovieDto>> GetAllAsync();
        Task<MovieDto> GetByIdAsync(int id);
        Task<MovieDto> AddAsync(MovieCreateDto tCreateDto);
        Task<MovieDto> UpdateAsync(MovieUpdateDto tUpdateDto);
        Task<MovieDto> DeleteAsync(int id);

    }
}
