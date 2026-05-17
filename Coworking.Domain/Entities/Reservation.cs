namespace Coworking.Domain.Entities;

public class Reservation
{
    public Guid Id { get; private set; }
    public Guid RoomId { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }

    // Navigation properties
    public Room Room { get; set; }
    public User User { get; set; }

    // Private parameterless constructor for EF Core
    private Reservation() { }

    public Reservation(Guid roomId, Guid userId, DateTime start, DateTime end)
    {
        if (end <= start)
            throw new ArgumentException("La hora de fin debe ser mayor a la de inicio.");
        Id = Guid.NewGuid();
        RoomId = roomId;
        UserId = userId;
        StartTime = start;
        EndTime = end;
    }
}
