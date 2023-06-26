using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_management_api.Request
{
    public class UserStoreRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CitizenIdentification { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
