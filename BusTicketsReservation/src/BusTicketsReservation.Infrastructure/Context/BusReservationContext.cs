using System.Data;
using System.Reflection;
using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Trips;
using BusTicketsReservation.Domain.Entities.Users;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;
using BusTicketsReservation.Domain.Common;

namespace BusTicketsReservation.Infrastructure.Context;

public class BusReservationContext : DbContext, IBusReservationContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    public BusReservationContext(DbContextOptions<BusReservationContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BusReservationContext).Assembly);
    }

    public int GetNextSequenceValue(string sequenceName)
    {
        SqlParameter result = new("@result", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        _ = this.Database.ExecuteSqlRaw($"SELECT @result = (NEXT VALUE FOR [dbo].[{sequenceName}Sequence])", result);
        return (int)result.Value;
    }

    public async Task<int> GetNextSequenceValueAsync(string sequenceName)
    {
        SqlParameter result = new("@result", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        await this.Database.ExecuteSqlRawAsync($"SELECT @result = (NEXT VALUE FOR [dbo].[{sequenceName}Sequence])", result);
        return (int)result.Value;
    }

    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}