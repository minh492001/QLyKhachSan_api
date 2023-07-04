using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accumulation",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "customers",
                newName: "CitizenIdentification");

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "bookings",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "UserCreateId",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 3, 58, 41, 379, DateTimeKind.Utc).AddTicks(9762));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "UserCreateId",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "CitizenIdentification",
                table: "customers",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "Accumulation",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "customers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "customers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 3, 6, 29, 821, DateTimeKind.Utc).AddTicks(1873));

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
    }
}
