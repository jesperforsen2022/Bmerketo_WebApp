using Bmerketo_WebApp.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Security.Cryptography.Xml;

namespace Bmerketo_WebApp.Models.Identity
{
    public class AppUserClaims : UserClaimsPrincipalFactory<IdentityUser, IdentityRole>
    {
        private readonly IdentityContext _identityContext;
        public AppUserClaims(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options, IdentityContext identityContext) : base(userManager, roleManager, options)
        {
            _identityContext = identityContext;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);
            var UserProfile = await _identityContext.UserProfiles.FirstOrDefaultAsync(x => x.UserId == user.Id);

            claimsIdentity.AddClaim(new Claim("UserId", user.Id ?? ""));
            claimsIdentity.AddClaim(new Claim("DisplayName", $"{UserProfile?.FirstName} {UserProfile?.LastName}" ?? ""));

            return claimsIdentity;
        }
    }
}
