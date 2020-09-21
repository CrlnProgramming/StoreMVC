
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Registration
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}
