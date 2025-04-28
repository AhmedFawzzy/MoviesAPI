using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
    }
}
