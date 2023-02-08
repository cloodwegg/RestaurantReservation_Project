using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReservation_Project.Server.Migrations
{
    public partial class AddedDefaultRatingAndReservationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "58a16a7a-5ad2-41c9-b939-0e75c5502660");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "764df738-2968-4545-bfc1-0b7149191ccd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4cd835b-9628-44da-ad33-d5eab1e829b0", "AQAAAAEAACcQAAAAEEWs+y92N8g3yQwrYdw/5KA+MF0SZmwPMpTzB6pXtnqXEJp+l8OLsLEMiHwJbcboIQ==", "3b7ebf8a-658f-4e85-80d8-f9012f8dcbb9" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AppUserId", "DateTime", "GroupSize", "RestaurantId", "StaffId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 8, 15, 5, 0, 0, DateTimeKind.Unspecified), 5, 1, 1 },
                    { 2, 2, new DateTime(2023, 2, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Description", "RatingScore", "ReservationId" },
                values: new object[] { 1, "amazing meal, would eat again", 5, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Description", "RatingScore", "ReservationId" },
                values: new object[] { 2, "food had flies in it, boycotting this establishment.", 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "60f7ec4c-6dad-449e-bc00-59394cda392e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ec3bd400-68e3-4754-a188-8d32f298668a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "372052f8-5526-41b8-8d11-246bc509edea", "AQAAAAEAACcQAAAAECIFGLaPaLCEvyHSFrXrfXiTz/HPe5ojjRAtz0fjPMMrG3rn5BFgjLzKBF/fA7rD/Q==", "0d054c58-1687-408f-9508-758586a56a26" });
        }
    }
}
