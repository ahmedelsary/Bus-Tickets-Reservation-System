using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusTicketsReservation.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services , IConfiguration configuration)
    {

        services.AddDbContext<BusReservationContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IBusReservationContext, BusReservationContext>();


    }
}