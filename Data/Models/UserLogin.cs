using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class UserLogin
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username must be more than 3 characters long.")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
