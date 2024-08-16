using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Trips;
using BusTicketsReservation.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsReservation.Domain.Common;

public interface IBusReservationContext
{
    public DbSet<User> Users { get; }
    public DbSet<Bus> Buses { get; }
    public DbSet<Trip> Trips { get; }
    public DbSet<Seat> Seats { get; }
    public DbSet<Reservation> Reservations { get; }

    public int GetNextSequenceValue(string sequenceName);
    public Task<int> GetNextSequenceValueAsync(string sequenceName);

    public Task<int> SaveChangesAsync();
    public int SaveChanges();
}
