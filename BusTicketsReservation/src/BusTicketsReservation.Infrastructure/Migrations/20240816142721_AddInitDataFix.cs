using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTicketsReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInitDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(6216), 1 });

            migrationBuilder.UpdateData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(6227), 2 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 27, 20, 618, DateTimeKind.Utc).AddTicks(9195));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(2542), 2 });

            migrationBuilder.UpdateData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(2560), 1 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 14, 21, 17, 116, DateTimeKind.Utc).AddTicks(6130));
        }
    }
}
