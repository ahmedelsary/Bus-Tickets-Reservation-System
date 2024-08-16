namespace BusTicketsReservation.Domain.DomainServices.Reservations;

public class ReservationService
{
    public decimal CalculateTotalPrice(int seatCount, decimal pricePerSeat)
    {
        var discount = seatCount > 5 ? 0.1m : 0m;
        return seatCount * pricePerSeat * (1 - discount);
    }
}