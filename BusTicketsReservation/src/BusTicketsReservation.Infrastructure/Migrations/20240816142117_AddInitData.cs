using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusTicketsReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Capacity", "CreatedDate", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(2542), 2, null },
                    { 2, 20, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(2560), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "BusId", "CreatedDate", "SeatNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4566), "A1", null },
                    { 2, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4577), "A2", null },
                    { 3, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4579), "A3", null },
                    { 4, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4585), "A4", null },
                    { 5, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4588), "A5", null },
                    { 6, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4591), "A6", null },
                    { 7, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4594), "A7", null },
                    { 8, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4597), "A8", null },
                    { 9, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4599), "A9", null },
                    { 10, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4605), "A10", null },
                    { 11, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4608), "A11", null },
                    { 12, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4611), "A12", null },
                    { 13, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4613), "A13", null },
                    { 14, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4616), "A14", null },
                    { 15, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4618), "A15", null },
                    { 16, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4621), "A16", null },
                    { 17, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4623), "A17", null },
                    { 18, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4627), "A18", null },
                    { 19, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4630), "A19", null },
                    { 20, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4633), "A20", null },
                    { 21, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4574), "A1", null },
                    { 22, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4578), "A2", null },
                    { 23, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4583), "A3", null },
                    { 24, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4587), "A4", null },
                    { 25, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4590), "A5", null },
                    { 26, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4593), "A6", null },
                    { 27, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4595), "A7", null },
                    { 28, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4598), "A8", null },
                    { 29, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4601), "A9", null },
                    { 30, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4607), "A10", null },
                    { 31, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4609), "A11", null },
                    { 32, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4612), "A12", null },
                    { 33, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4614), "A13", null },
                    { 34, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4617), "A14", null },
                    { 35, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4620), "A15", null },
                    { 36, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4622), "A16", null },
                    { 37, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4626), "A17", null },
                    { 38, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4629), "A18", null },
                    { 39, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4631), "A19", null },
                    { 40, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4634), "A20", null }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "BusId", "CreatedDate", "Distance", "Route", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(6123), 90.0, "Cairo-Alexandria", null },
                    { 2, 2, new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(6130), 150.0, "Cairo-Aswan", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
