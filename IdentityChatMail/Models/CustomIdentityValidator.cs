using Microsoft.AspNetCore.Identity;

namespace IdentityChatMail.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber

    {
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf girişi yapınız!"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane küçük harf girişi yapınız!"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 tane rakam girişi yapınız!"
            };
        }
        public override IdentityError PasswordTooShort(int lenght)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Lütfen en az " + lenght + " karakter veri girişi yapınız!"
            };
        }
    }
}
