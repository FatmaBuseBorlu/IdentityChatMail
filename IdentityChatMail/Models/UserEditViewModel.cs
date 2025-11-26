using System.ComponentModel.DataAnnotations;

namespace IdentityChatMail.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}