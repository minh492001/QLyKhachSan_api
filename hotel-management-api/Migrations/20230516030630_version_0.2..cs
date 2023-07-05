using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1862), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1865), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1867), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1869), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1869), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1870), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1871), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1872), (byte)0 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1873), (byte)0 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1821));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7691), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7693), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7695), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7729), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7731), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7732), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7733), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7734), (byte)2 });

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "RoomStatus" },
                values: new object[] { new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7735), (byte)2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7647));
        }
    }
}
