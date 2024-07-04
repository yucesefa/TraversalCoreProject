using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karakter olmalıdır"
            };

        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code="PasswordRequiresUpper",
                Description="Parola en az 1 büyük harf içermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 küçük harf içermelidir"
            };
        }
    }
}
