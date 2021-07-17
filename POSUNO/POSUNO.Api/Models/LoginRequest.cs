
using System.ComponentModel.DataAnnotations;

namespace POSUNO.Api.Models
{
    public class LoginRequest
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
