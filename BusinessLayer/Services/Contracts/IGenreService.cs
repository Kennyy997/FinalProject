using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface IGenreService : ICrudService<GenreDto, GenreCreateDto, GenreUpdateDto, Genre>
    {
        Task<List<GenreDto>> GetAllAsync();
        Task<GenreDto> GetByIdAsync(int id);
        Task<GenreDto> AddAsync(GenreCreateDto tCreateDto);
        Task<GenreDto> UpdateAsync(GenreUpdateDto tUpdateDto);
        Task<GenreDto> DeleteAsync(int id);

    }
}
