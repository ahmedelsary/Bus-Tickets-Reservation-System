using BusTicketsReservation.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsReservation.Application.Queries.GetFrequentTripQuery;

#region Request
public class GetFrequentTripsQuery : IRequest<List<GetFrequentTripResponse>>
{

}
#endregion
#region Response
public class GetFrequentTripResponse
{
    public string Email { get; set; }
    public string FrequentBook { get; set; }
}
#endregion
#region Handler
public class GetFrequentTripsQueryHandler : IRequestHandler<GetFrequentTripsQuery, List<GetFrequentTripResponse>>
{
    private readonly IBusReservationContext _context;

    public GetFrequentTripsQueryHandler(IBusReservationContext context)
    {
        _context = context;
    }

    public async Task<List<GetFrequentTripResponse>> Handle(GetFrequentTripsQuery request, CancellationToken cancellationToken)
    {

        var frequentTrips = await _context.Reservations
                .GroupBy(r => new { r.User.Email, r.Trip.Route })
                .Select(g => new { Email = g.Key.Email, Route = g.Key.Route, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .ToListAsync();

            var result = frequentTrips
                .GroupBy(t => t.Email)
                .Select(g => new GetFrequentTripResponse{
                        Email = g.Key,
                        FrequentBook = g.OrderByDescending(t => t.Count).First().Route })
                .ToList();

            return result;
    }
}

#endregion
