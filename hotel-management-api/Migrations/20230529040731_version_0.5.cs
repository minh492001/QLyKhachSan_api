using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CitizenIdentification",
                table: "customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "CitizenIdentification",
                keyValue: null,
                column: "CitizenIdentification",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CitizenIdentification",
                table: "customers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 2, 8, 18, 316, DateTimeKind.Utc).AddTicks(2139));
        }
    }
}
