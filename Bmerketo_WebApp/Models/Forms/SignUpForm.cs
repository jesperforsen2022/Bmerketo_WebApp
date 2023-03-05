using System.ComponentModel.DataAnnotations;

namespace Bmerketo_WebApp.Models.Forms
{
    public class SignUpForm
    {
        [Required]
        [Display(Name = "Your First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Your Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email Address")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password))]
        public string ConfirmPassword{ get; set; } = null!;
        public string? StreetName { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Mobile { get; set; }
        public string? Company { get; set; }
        public IFormFile? ProfileImage { get; set; }
        public string ReturnUrl { get; set; } = null!;
    }
}
