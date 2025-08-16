using AutoMapper;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Services.Contracts;
using DataAccessLayer.Repositorys.Contracts;

namespace Academy.BusinessLogicLayer.Services
{
    public class CrudManager<TDto, TCreateDto, TUpdateDto, TEntity> : ICrudService<TDto, TCreateDto, TUpdateDto, TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IRepositoryasync<TEntity> Repository;
        protected readonly IMapper Mapper;

        public CrudManager(IRepositoryasync<TEntity> repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        public virtual async Task<TDto> AddAsync(TCreateDto createDto)
        {
            var entity = Mapper.Map<TEntity>(createDto);
            var createdEntity = await Repository.AddAsync(entity);
            var dto = Mapper.Map<TDto>(createdEntity);
            return dto;
        }

        public virtual async Task<TDto> DeleteAsync(int id)
        {
            var entity = await Repository.DeleteAsync(id);
            var dto = Mapper.Map<TDto>(entity);
            return dto;
        }

        public virtual async Task<List<TDto>> GetAllAsync()
        {
            var entities = await Repository.GetAllAsync();
            var dtos = Mapper.Map<List<TDto>>(entities);
            return dtos;
        }

        public virtual async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);
            var dto = Mapper.Map<TDto>(entity);
            return dto;
        }

        public virtual async Task<TDto> UpdateAsync(TUpdateDto updateDto)
        {
            var entity = Mapper.Map<TEntity>(updateDto);
            var updatedEntity = await Repository.UpdateAsync(entity);
            var dto = Mapper.Map<TDto>(updatedEntity);

            return dto;


        }
    }
}