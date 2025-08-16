using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface IReviewService : ICrudService<ReviewDto, ReviewCreateDto, ReviewUpdateDto, Review>
    {
        Task<List<ReviewDto>> GetAllAsync();
        Task<ReviewDto> GetByIdAsync(int id);
        Task<ReviewDto> AddAsync(ReviewCreateDto tCreateDto);
        Task<ReviewDto> UpdateAsync(ReviewUpdateDto tUpdateDto);
        Task<ReviewDto> DeleteAsync(int id);

    }
}
