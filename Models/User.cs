using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "First name is required!")]
        [MinLength(4, ErrorMessage = "First name must be at least 4 characters in length.")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [MinLength(4, ErrorMessage = "Last name must be at least 4 characters in length.")]
        public string Last_name { get; set; }

        [Required(ErrorMessage = "Age is required!")]
        [Range(0, int.MaxValue, ErrorMessage = "Age positive number")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters in length.")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
