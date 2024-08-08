using FluentValidation;
using ErhasTicaret.Core.DTOs;

namespace ErhasTicaret.Core.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre boş olamaz.");
            RuleFor(u => u.UserRole).NotEmpty().WithMessage("Kullanıcı rolü boş olamaz.");
        }
    }
}
