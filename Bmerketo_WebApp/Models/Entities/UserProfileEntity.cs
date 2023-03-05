using Microsoft.AspNetCore.Identity;

namespace Bmerketo_WebApp.Models.Entities
{
    public class UserProfileEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? StreetName { get; set; }
        public string? Email { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }


        public virtual IdentityUser User { get; set; } = null!;

    }
}
