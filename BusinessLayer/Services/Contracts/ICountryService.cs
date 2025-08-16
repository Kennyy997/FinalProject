using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
   public interface ICountryService : ICrudService<CountryDto, CountryCreateDto, CountryUpdateDto, Country>
    {
        Task<List<CountryDto>> GetAllAsync();
        Task<CountryDto> GetByIdAsync(int id);
        Task<CountryDto> AddAsync(CountryCreateDto tCreateDto);
        Task<CountryDto> UpdateAsync(CountryUpdateDto tUpdateDto);
        Task<CountryDto> DeleteAsync(int id);


    }
}
