using Microsoft.AspNetCore.Identity;

namespace Bmerketo_WebApp.Models.Entities
{
    public class ProfileEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set;} = null!;
        public string? ImageName { get; set; }

        public IdentityUser User { get; set; } = null!;
    }
}
