using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.DomainServices.Reservations;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsReservation.Application.Commands.Reservations;

#region Request
public class TicketsRequest : IRequest<TicketsResponse>
{
    public string UserEmail { get; set; }
    public string TripRoute { get; set; }
    public List<string> Seats { get; set; }
}
#endregion

#region Response

public class TicketsResponse
{
    public string? UserEmail { get; set; }
    public List<TicketDto>? Tickets { get; set; }
    public string? BusId { get; set; }
    public decimal? Price { get; set; }
    public string? Message { get; set; }
}

public class TicketDto
{
    public int Id { get; set; }
    public string Seat { get; set; }
}


#endregion

#region Handler
public class TicketsRequestHandler : IRequestHandler<TicketsRequest, TicketsResponse>
{
    private readonly IBusReservationContext _context;
    private readonly ReservationService _reservationService;


    public TicketsRequestHandler(IBusReservationContext context, ReservationService reservationService)
    {
        _context = context;
        _reservationService = reservationService;
    }

    public async Task<TicketsResponse> Handle(TicketsRequest request, CancellationToken cancellationToken)
    {
        var trip = await _context.Trips.Include(t => t.Bus).FirstOrDefaultAsync(t => t.Route == request.TripRoute);
        if (trip == null)
        {
            return new TicketsResponse { Message = "Trip not found." };
        }

        var reservedSeats = await _context.Reservations
            .Where(r => r.TripId == trip.Id && request.Seats.Contains(r.Seat.SeatNumber))
            .Select(r => r.Seat.SeatNumber)
            .ToListAsync();

        if (reservedSeats.Any())
        {
            return new TicketsResponse { Message =  $"seat {string.Join(",", reservedSeats)} is already reserved" };
        }

        if (!trip.HasCapacityFor(request.Seats.Count()))
        {
            return new TicketsResponse { Message = "no capacity in the bus" };
        }
        var totalPrice = _reservationService.CalculateTotalPrice(request.Seats.Count(),10M);

        var reservations = new List<Reservation>();

        foreach (var seatNumber in request.Seats)
        {
            var seat = await _context.Seats.FirstOrDefaultAsync(s => s.BusId == trip.BusId && s.SeatNumber == seatNumber);
            if (seat == null)
            {
                return new TicketsResponse { Message  = $"seat {seatNumber} not found on the bus" };
            }

            var userId = await GetOrCreateUserId(request.UserEmail);
            var tripId = trip.Id;
            var seatId = seat.Id;
            var price = totalPrice / request.Seats.Count();
            var reservationTime = DateTime.UtcNow;

            var reservationId = _context.GetNextSequenceValue(nameof(Reservation));

            var reservation = new Reservation(reservationId, userId, tripId, seatId, price, reservationTime);

            _context.Reservations.Add(reservation);
            reservations.Add(reservation);
        }

        await _context.SaveChangesAsync();

        return new TicketsResponse
        {
            UserEmail = request.UserEmail,
            Tickets = reservations.Select(r => new TicketDto() { Id = r.Id, Seat = r.Seat.SeatNumber }).ToList(),
            BusId = $"Bus-{trip.BusId}",
            Price = totalPrice
        };
    }
    private async Task<int> GetOrCreateUserId(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            var userId = await _context.GetNextSequenceValueAsync(nameof(User));

            user = new User(userId, email);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        return user.Id;
    }
}


#endregion
