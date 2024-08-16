using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Trips;
using BusTicketsReservation.Domain.Entities.Users;
using System.Diagnostics;

namespace BusTicketsReservation.Domain.Entities.Reservations;

public class Reservation:BaseEntity
{
    protected Reservation()
    {
    }
    public Reservation(int id, int userId, int tripId, int seatId, decimal price, DateTime reservationTime)
    {
        Id = id;
        UserId = userId;
        TripId = tripId;
        SeatId = seatId;
        Price = price;
        ReservationTime = reservationTime;
    }
    public int UserId { get; private set; }
    public int TripId { get; private set; }
    public int SeatId { get; private set; }
    public decimal Price { get; private set; }
    public DateTime ReservationTime { get; private set; }
    public virtual User User { get; private set; }
    public virtual Trip Trip { get; private set; }
    public virtual Seat Seat { get; private set; }
}