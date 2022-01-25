using System.ComponentModel.DataAnnotations;

namespace SpaDayDesktop.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Must be 5-15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Must be 6-20 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Verification is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Must be 6-20 characters")]
        public string VerifyPassword { get; set; }

        [EmailAddress(ErrorMessage ="Please enter a valid e-mail address.")]
        public string Email { get; set; }
    }
}
