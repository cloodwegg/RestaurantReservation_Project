using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReservation_Project.Server.Data.Migrations
{
    public partial class AddedDefaultAppUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "13a7555a-350b-41d9-9182-890945b57970");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "b249afdc-bb28-4bbe-a97f-c44064b14668");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a2f8ea8-81a0-491f-8ab5-53a70a544ce5", "AQAAAAEAACcQAAAAEEhCptAp+aR3xUTT0MIm/wHvhIYqjJ+AkxfmyfDvPyNWpwG27UR/6XH4eaJ5o02Xvg==", "b4fe3d00-bb81-4be5-85ef-95af8f20747a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3e97f7bb-0423-490f-9d46-a33927fd12d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "371c0eb0-fd92-411e-93d0-f449e1b4bbd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ee12434-9963-4ec5-b5c7-a2b5b2792029", "AQAAAAEAACcQAAAAEGh4bWlQz0u/O2thrycp0AtgZviRkYwkSIbnGNk8L0okldjRgAA8lrK5sRXlEtL9CA==", "ee17d7e1-1940-4f19-9b57-878562ce12ee" });
        }
    }
}
