using Coworking.Domain.Entities;

namespace Coworking.Domain.Interfaces;

public interface IRoomRepository
{
    Task<Room?> GetByIdAsync(Guid id);
    Task<IEnumerable<Room>> GetAllAsync();
}