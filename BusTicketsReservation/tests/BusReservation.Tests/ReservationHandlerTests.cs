using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Trips;
using BusTicketsReservation.Domain.Entities.Users;
using BusTicketsReservation.Domain.Shared.Enums;
using BusTicketsReservation.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using BusTicketsReservation.Application.Commands.Reservations;
using BusTicketsReservation.Domain.DomainServices.Reservations;

namespace BusReservation.Tests
{
    public class ReservationHandlerTests
    {
        private BusReservationContext _context;
        private TicketsRequestHandler _ticketsHandler;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BusReservationContext>()
                .UseSqlServer("Server=localhost;Database=BusTicketsReservationTestDb; Integrated Security=True;TrustServerCertificate=True")
                .Options;

            _context = new BusReservationContext(options);

            _context.Database.EnsureDeleted();

            _context.Database.Migrate();

            // Seed the database
            SeedDatabase();

            _ticketsHandler = new TicketsRequestHandler(_context,new ReservationService());

        }

        private void SeedDatabase()
        {
            var busId = 50;//_context.GetNextSequenceValue(nameof(Bus));
            var tripId = 50; // _context.GetNextSequenceValue(nameof(Trip));
            var bus = new Bus(busId, BusType.ShortTrips, 20);
            var trip = new Trip(tripId, "Cairo-Alexandria", 90, busId);

            _context.Buses.Add(bus);
            _context.Trips.Add(trip);

            for (int i = 1; i <= 20; i++)
            {
                var seatId = _context.GetNextSequenceValue(nameof(Seat));

                bus.AddSeat(new Seat(seatId, busId, $"A{i}"));

            }

            _context.SaveChanges();
        }

        [Test]
        public async Task BookTickets_ShouldSuccessNullMessage_WhenSeatsIsAvailable()
        {
            // Arrange
            var request = new TicketsRequest
            {
                UserEmail = "sayed@gamil.com",
                TripRoute = "Cairo-Alexandria",
                Seats = new List<string> {"A10","A11","A12"}
            };

            // Act
            var result = await _ticketsHandler.Handle(request, CancellationToken.None);

            // Assert
            Assert.IsNull(result?.Message);
        }
        [Test]
        public async Task BookTickets_ShouldFailNotNullMessage_WhenSeatsAreAlreadyReserved()
        {
            // Arrange
            var userId = 50; // _context.GetNextSequenceValue(nameof(User));
            var existingUser = new User(userId, "ahmed.hassanien@gamil.com");
            _context.Users.Add(existingUser);
            await _context.SaveChangesAsync();

            var existingSeat = _context.Seats.First();

            var reservationId = 50; // _context.GetNextSequenceValue(nameof(Reservation));
            var reservation = new Reservation(reservationId, userId, tripId: 1, existingSeat.Id, price: 10, DateTime.UtcNow);

            _context.Reservations.Add(reservation);

            await _context.SaveChangesAsync();



            var request = new TicketsRequest
            {
                UserEmail = "sayed@gamil.com",
                TripRoute = "Cairo-Alexandria",
                Seats = new List<string> { existingSeat.SeatNumber }
            };

            // Act
            var result = await _ticketsHandler.Handle(request, CancellationToken.None) ;

            // Assert
            Assert.IsNotNull(result?.Message);
        }
        [Test]
        public async Task BookTickets_ShouldApplyDiscount_WhenMoreThan5SeatsBooked()
        {
            // Arrange
            var request = new TicketsRequest
            {
                UserEmail = "Hassanien@mydomain.com",
                TripRoute = "Cairo-Alexandria",
                Seats = new List<string> { "A1", "A2", "A3", "A4", "A5", "A6" }
            };

            // Act
            var response = await _ticketsHandler.Handle(request, CancellationToken.None);

            // Assert
            Assert.AreEqual(54, response?.Price); // 6 seats * 10 * 0.9 (10% discount)
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }

}