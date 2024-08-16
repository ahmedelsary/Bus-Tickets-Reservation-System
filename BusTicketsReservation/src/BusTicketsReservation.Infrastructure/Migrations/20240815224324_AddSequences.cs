using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTicketsReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSequences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE SEQUENCE dbo.BusSequence
                AS int
                START WITH 100
                INCREMENT BY 1 ;

                CREATE SEQUENCE dbo.TripSequence
                AS int
                START WITH 100
                INCREMENT BY 1 ;


                CREATE SEQUENCE dbo.SeatSequence
                AS int
                START WITH 100
                INCREMENT BY 1 ;

                CREATE SEQUENCE dbo.UserSequence
                AS int
                START WITH 100
                INCREMENT BY 1 ;


                CREATE SEQUENCE dbo.ReservationSequence
                AS int
                START WITH 100
                INCREMENT BY 1 ;

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP SEQUENCE dbo.BusSequence;
            DROP SEQUENCE dbo.TripSequence;
            DROP SEQUENCE dbo.SeatSequence;
            DROP SEQUENCE dbo.UserSequence;
            ");
        }
    }
}
