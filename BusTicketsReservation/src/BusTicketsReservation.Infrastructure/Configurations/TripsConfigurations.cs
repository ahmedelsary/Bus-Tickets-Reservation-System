using BusTicketsReservation.Domain.Entities.Trips;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsReservation.Infrastructure.Configurations;

public class TripsConfigurations:IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder.HasData(new List<Trip>
        {
            new Trip(1,"Cairo-Alexandria",90,1),
            new Trip(2,"Cairo-Aswan",150,2),

        });
    }
}