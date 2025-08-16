﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
    public interface ICrudService<TDto, TCreateDto, TUpdateDto, TEntity>
    {
        Task<List<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task<TDto> AddAsync(TCreateDto tCreateDto);
        Task<TDto> UpdateAsync(TUpdateDto tUpdateDto);
        Task<TDto> DeleteAsync(int id);

    }
}
