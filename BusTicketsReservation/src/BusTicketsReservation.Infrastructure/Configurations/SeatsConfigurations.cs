using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Trips;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsReservation.Infrastructure.Configurations;

public class SeatsConfigurations:IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        var seats = new List<Seat>();
        for (int i = 1; i <= 20; i++)
        {
            seats.Add(new Seat(i,1,$"A{i}"));

            seats.Add(new Seat(i+20,2,$"A{i}"));
        }

        builder.HasData(seats);
    }
}