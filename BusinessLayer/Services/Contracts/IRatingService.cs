using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.BusinessLogicLayer.Dtos;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface IRatingService : ICrudService<RatingDto, RatingCreateDto, RatingUpdateDto, Rating>
    {
        Task<List<RatingDto>> GetAllAsync();
        Task<RatingDto> GetByIdAsync(int id);
        Task<RatingDto> AddAsync(RatingCreateDto tCreateDto);
        Task<RatingDto> UpdateAsync(RatingUpdateDto tUpdateDto);
        Task<RatingDto> DeleteAsync(int id);

    }
}
