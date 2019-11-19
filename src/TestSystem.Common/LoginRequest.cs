using System.ComponentModel.DataAnnotations;

namespace TestSystem.Common
{
    public class LoginRequest
    {
        [Required]
        public string Login { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
