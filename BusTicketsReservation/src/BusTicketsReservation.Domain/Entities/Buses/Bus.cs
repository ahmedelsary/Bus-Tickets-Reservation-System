using System.ComponentModel;
using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.Shared.Enums;

namespace BusTicketsReservation.Domain.Entities.Buses;

public class Bus:BaseEntity
{
    protected Bus()
    {
        _seats = new List<Seat>();
    }
    public Bus(int id, BusType type, int capacity):this()
    {
        Id = id;
        Type = type;
        Capacity = capacity;
    }

    public BusType Type { get; private set; }
    public int Capacity { get; private set; }
    private readonly List<Seat> _seats;

    public virtual IReadOnlyList<Seat> Seats => _seats.AsReadOnly();

    public void AddSeat(Seat seat)
    {
        if (Seats.Count >= Capacity)
            throw new InvalidOperationException("Bus is full.");

        _seats.Add(seat);
    }
}
