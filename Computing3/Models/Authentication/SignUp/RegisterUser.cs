using System.ComponentModel.DataAnnotations;

namespace Computing3.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="Username is Required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }
    }
}
