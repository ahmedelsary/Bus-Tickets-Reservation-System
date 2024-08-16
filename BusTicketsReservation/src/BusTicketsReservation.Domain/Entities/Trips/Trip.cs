using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.Entities.Buses;

namespace BusTicketsReservation.Domain.Entities.Trips;

public class Trip:BaseEntity
{
    protected Trip()
    {
    }
    public Trip(int id,string route, double distance, int busId)
    {
        // need to check bus type with distance. 
        Id = id;
        Route = route;
        Distance = distance;
        BusId = busId;
    }

    public string Route { get; private set; } // need  to make it value type.
    public double Distance { get; private set; }
    public int BusId { get; private set; }
    public virtual Bus Bus { get; private set; }

    public bool HasCapacityFor(int seatCount) => Bus.Capacity >= seatCount;

}