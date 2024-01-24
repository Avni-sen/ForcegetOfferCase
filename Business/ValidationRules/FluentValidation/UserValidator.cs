using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty().MinimumLength(2);
            RuleFor(p => p.Password).NotEmpty().MinimumLength(6).Must(password => password.Any(char.IsDigit));
        }
    }
}
