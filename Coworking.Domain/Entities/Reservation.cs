namespace Coworking.Domain.Entities;

public class Reservation
{
    public Guid Id { get; private set; }
    public Guid RoomID { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }

    public Reservation(Guid roomId, Guid userId, DateTime start, DateTime end)
    {
        if (end <= start)
            throw new ArgumentException("La hora de fin debe ser mayor a la de inicio.");
        Id = Guid.NewGuid();
        RoomID = roomId;
        UserId = userId;
        StartTime = start;
        EndTime = end;
    }
}