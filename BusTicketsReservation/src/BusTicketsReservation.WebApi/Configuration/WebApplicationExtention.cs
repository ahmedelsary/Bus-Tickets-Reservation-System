using BusTicketsReservation.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsReservation.WebApi.Configuration
{
    public static class WebApplicationExtention
    {
        public static async Task MigrateDatabase(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<BusReservationContext>();
            try
            {
                await context.Database.MigrateAsync();
            }
            catch (Exception)
            {
            }    ;
        }
    }
}
