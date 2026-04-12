using Coworking.Domain.Entities;

namespace Coworking.Domain.Interfaces;

public interface IReservationRepository
{
    Task AddAsync(Reservation reservation);
    Task<bool> IsRoomAvailableAsync(Guid roomId, DateTime start, DateTime end);
}