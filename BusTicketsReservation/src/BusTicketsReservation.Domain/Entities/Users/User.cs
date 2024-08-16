using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Reservations;

namespace BusTicketsReservation.Domain.Entities.Users;

public class User:BaseEntity
{
    protected User()
    {
        _reservations = new List<Reservation>();
    }

    public User(int id,string email):this()
    {
        Id = id;
        Email = email;
    }
    public string Email { get; private set; }
    private readonly List<Reservation> _reservations;

    public virtual IReadOnlyCollection<Reservation> Reservations => _reservations.AsReadOnly();
}