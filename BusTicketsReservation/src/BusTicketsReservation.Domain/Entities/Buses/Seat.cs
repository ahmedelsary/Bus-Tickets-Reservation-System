using BusTicketsReservation.Domain.Common;

namespace BusTicketsReservation.Domain.Entities.Buses;

public class Seat : BaseEntity
{
    protected Seat()
    {

    }
    public Seat(int id , int busId, string seatNumber):this()
    {
        Id = id;
        BusId = busId;
        SeatNumber = seatNumber;
    }
    public int BusId { get; private set; }
    public string SeatNumber { get; private set; }
    public virtual Bus Bus { get; private set; }
}