using BusTicketsReservation.Domain.Entities.Buses;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Trips;
using BusTicketsReservation.Domain.Entities.Users;
using BusTicketsReservation.Domain.Shared.Enums;
using BusTicketsReservation.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using BusTicketsReservation.Application.Commands.Reservations;
using BusTicketsReservation.Application.Queries.GetFrequentTripQuery;
using BusTicketsReservation.Domain.DomainServices.Reservations;

namespace BusReservation.Tests
{
    public class GetFrequentTripsQueryHandlerTests
    {
        private BusReservationContext _context;
        private GetFrequentTripsQueryHandler _frequentTripsQueryHandler;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BusReservationContext>()
                .UseSqlServer("Server=localhost;Database=BusTicketsReservationTestDb; Integrated Security=True;TrustServerCertificate=True")
                .Options;

            _context = new BusReservationContext(options);
            _context.Database.EnsureDeleted();
            _context.Database.Migrate(); // its contain two bus with related dat

            _frequentTripsQueryHandler = new GetFrequentTripsQueryHandler(_context);

        }
        [Test]
        public async Task FrequentTrips_ShouldReturnCairoAlexandriaTrip_WhenAddThreeTicketForCairoAlexandriaAndOneForCairoAswan()
        {
            // Arrange
            var userId = 60;
            var user = new User(userId, "hassanien@gamil.com");
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // tripId: 1 is Cairo -Alexandria trip.

            var cairoAlexandriaReservation = new List<Reservation>
            {
                new Reservation(20, userId, tripId: 1, seatId:1, price: 10, DateTime.UtcNow),
                new Reservation(21, userId, tripId: 1,seatId:2, price: 10, DateTime.UtcNow),
                new Reservation(23, userId, tripId: 1,seatId:3, price: 10, DateTime.UtcNow),
            };
            _context.Reservations.AddRange(cairoAlexandriaReservation);

            // tripId: 2 is Cairo -Aswan trip.
            var cairoAswanReservation = new List<Reservation>
            {
                new Reservation(25, userId, tripId:2, seatId:1, price: 10, DateTime.UtcNow)
            };

            _context.Reservations.AddRange(cairoAswanReservation);

            await _context.SaveChangesAsync();


             var request = new GetFrequentTripsQuery();

            // Act
            var result = await _frequentTripsQueryHandler.Handle(request, CancellationToken.None) ;

            // Assert
            Assert.IsTrue(result.First().FrequentBook == "Cairo-Alexandria");
        }
        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }

}