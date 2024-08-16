using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsReservation.Infrastructure.Configurations;

public class BusesConfigurations : IEntityTypeConfiguration<Bus>
{
    public void Configure(EntityTypeBuilder<Bus> builder)
    {
        builder.HasData(new List<Bus>
        {
            new Bus(1, BusType.ShortTrips, 20),
            new Bus(2, BusType.LongTrips, 20)
        });
    }

}