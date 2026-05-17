using Coworking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Infrastructure;

public class AppDbContext
{
    public DbSet<User> Users { get; set; };
    public DbSet<Room> Rooms { get; set; };
    public DbSet<Reservation> Reservations { get; set; };
}