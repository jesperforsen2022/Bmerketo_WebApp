using Bmerketo_WebApp.Contexts;
using Bmerketo_WebApp.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Xsl;

namespace Bmerketo_WebApp.Services
{
    public class ProfileHandler
    {
        private readonly IWebHostEnvironment _env;
        private readonly IdentityContext _context;

        public ProfileHandler(IWebHostEnvironment env, IdentityContext context)
        {
            _env = env;
            _context = context;
        }

        public async Task<string> UploadProfileImageAsync(IFormFile profileImage)
        {
            var profilePath = $"{_env.WebRootPath}/images/profiles";
            var imageName = $"profile_{Guid.NewGuid()}{Path.GetExtension(profileImage.FileName)}";
            string filePath = $"{profilePath}/{imageName}";

            using var fs = new FileStream(filePath, FileMode.Create);
            await profileImage.CopyToAsync(fs);

            return imageName;
        }

        public async Task<AccountProfile> GetProfileAsync(string username)
        {
            var identityUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
            if (identityUser != null)
            {
                var profileEntity = await _context.Profiles.FirstOrDefaultAsync(x => x.UserId == identityUser.Id);
                
                if(profileEntity != null) 
                {                   
                    var profile = new AccountProfile
                    {
                        UserId = identityUser.Id,
                        FirstName = profileEntity.FirstName,
                        LastName = profileEntity.LastName,
                        Email = identityUser.Email!,
                        PhoneNumber = identityUser.PhoneNumber,
                        ImageName = profileEntity.ImageName,
                    };
                    return profile;
                }

            }
            return null!;
        }
    }
}
