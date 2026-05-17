namespace Coworking.Domain.Entities;

public class Room
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Capacity { get; private set; }
    public decimal PricePerHour { get; private set; }

    private Room() { }

    public Room(Guid id, string name, int capacity, decimal pricePerHour)
    {
        Id = id;
        Name = name;
        Capacity = capacity;
        PricePerHour = pricePerHour;
    }
}
