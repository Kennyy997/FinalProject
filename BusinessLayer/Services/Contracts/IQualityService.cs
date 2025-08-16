using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface IQualityService : ICrudService<QualityDto, QualityCreateDto, QualityUpdateDto, Quality>
    {
        Task<List<QualityDto>> GetAllAsync();
        Task<QualityDto> GetByIdAsync(int id);
        Task<QualityDto> AddAsync(QualityCreateDto tCreateDto);
        Task<QualityDto> UpdateAsync(QualityUpdateDto tUpdateDto);
        Task<QualityDto> DeleteAsync(int id);


    }
}
