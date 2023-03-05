using System.ComponentModel.DataAnnotations;

namespace Bmerketo_WebApp.Models.Forms
{
    public class SignInForm
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Your Email Address")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        public string ReturnUrl { get; set; } = null!;
    }
}
