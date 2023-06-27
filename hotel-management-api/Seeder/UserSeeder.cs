using Microsoft.EntityFrameworkCore;
using hotel_management_api.Models;
using hotel_management_api.Common;

namespace hotel_management_api.Seeder
{
    class UserSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public UserSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Nguyễn Văn A",
                    CitizenIdentification = "001201030041",
                    DateOfBirth = new DateTime(2001, 01, 01),
                    NumberPhone = "0123456789",
                    Address = "Hà Nội",
                    Email = "nguyenvana@gmail.com",
                    Username = "nguyenvana@gmail.com",
                    Password = Untill.CreateMD5("nguyenvana@gmail.com"),
                    Role = "Manager"
                },
                new User
                {
                    Id = 2,
                    Name = "Nguyễn Thị B",
                    CitizenIdentification = "001201030041",
                    DateOfBirth = new DateTime(2001, 01, 01),
                    NumberPhone = "0123456788",
                    Address = "Hà Nội",
                    Email = "nguyenthib@gmail.com",
                    Username = "nguyenthib@gmail.com",
                    Password = Untill.CreateMD5("nguyenthib@gmail.com"),
                    Role = "Accountant"
                },
                new User
                {
                    Id = 3,
                    Name = "Nguyễn Thị B",
                    CitizenIdentification = "001201030041",
                    DateOfBirth = new DateTime(2001, 01, 01),
                    NumberPhone = "0123456788",
                    Address = "Hà Nội",
                    Email = "nguyenthib@gmail.com",
                    Username = "nguyenthib@gmail.com",
                    Password = Untill.CreateMD5("nguyenthib@gmail.com"),
                    Role = "Receptionist"
                });
        }
    }
}
