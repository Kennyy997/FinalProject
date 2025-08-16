using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;

namespace MovieFinalProjectBusinessLogicLayer.Services.Contracts
{
   public interface IActorService : ICrudService<ActorDto, ActorCreateDto, ActorUpdateDto, Actor>
    {
    Task<List<ActorDto>> GetAllAsync();
    Task<ActorDto> GetByIdAsync(int id);
    Task<ActorDto> AddAsync(ActorCreateDto tCreateDto);
    Task<ActorDto> UpdateAsync(ActorUpdateDto tUpdateDto);
    Task<ActorDto> DeleteAsync(int id);
    
    }
}
