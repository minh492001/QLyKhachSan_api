using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    HotelRoomId = table.Column<int>(type: "int", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Accumulation = table.Column<int>(type: "int", nullable: false),
                    NumberBooking = table.Column<int>(type: "int", nullable: false),
                    CustomerType = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoRoom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    NumberBed = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    RoomStatus = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Option = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotel_rooms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CitizenIdentification = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPhone = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "hotel_rooms",
                columns: new[] { "Id", "Area", "CreatedDate", "Description", "Floor", "Image", "NoRoom", "NumberBed", "Option", "Price", "RoomStatus", "RoomType", "Size", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 28, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7691), "", 2, "", "201", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 40, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7693), "", 2, "", "202", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 35, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7695), "", 2, "", "203", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 28, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7729), "", 3, "", "301", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 40, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7731), "", 3, "", "302", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 35, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7732), "", 3, "", "303", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 28, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7733), "", 4, "", "401", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 40, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7734), "", 4, "", "402", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 35, new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7735), "", 4, "", "403", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "CitizenIdentification", "CreatedDate", "DateOfBirth", "Email", "Name", "NumberPhone", "Password", "Role", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { 1, "Hà Nội", "001201030041", new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7455), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvana@gmail.com", "Nguyễn Văn A", "0123456789", "68F5F844896EE7A4626DA5678045EC26", "Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvana@gmail.com" },
                    { 2, "Hà Nội", "001201030041", new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7633), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com", "Nguyễn Thị B", "0123456788", "FF9AA1E68A37C1F87F9BE3B91860726A", "Accountant", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com" },
                    { 3, "Hà Nội", "001201030041", new DateTime(2023, 4, 15, 3, 45, 27, 507, DateTimeKind.Utc).AddTicks(7647), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com", "Nguyễn Thị B", "0123456788", "FF9AA1E68A37C1F87F9BE3B91860726A", "Receptionist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "hotel_rooms");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
