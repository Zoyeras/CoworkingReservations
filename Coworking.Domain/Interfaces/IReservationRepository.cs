namespace Coworking.Domain.Interfaces;

public interface IReservationRepository
{
    public GetReservationById()
    {
        return Task<bool> IsRoomAvailableAsync(Guid roomId, DateTime start, DateTime end);
    }
}