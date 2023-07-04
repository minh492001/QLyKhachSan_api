using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "bookings");

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 53, 15, 363, DateTimeKind.Utc).AddTicks(6742));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "bookings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "bookings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "bookings",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 4, 7, 30, 879, DateTimeKind.Utc).AddTicks(4868));
        }
    }
}
