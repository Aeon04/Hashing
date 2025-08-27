using System.ComponentModel.DataAnnotations;

namespace Hashing.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Username")]
        public string Username { get; set; } = string.Empty;
        
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;
    }
}
