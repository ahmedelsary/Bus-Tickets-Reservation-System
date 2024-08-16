using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BusTicketsReservation.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}