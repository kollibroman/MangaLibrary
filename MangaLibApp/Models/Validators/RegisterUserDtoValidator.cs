using FluentValidation;
using MangaLibCore;

namespace MangaLibApp.Models.Validators;

public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
{
    public RegisterUserDtoValidator(MangaLibDbContext db)
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
        RuleFor(x => x.Password)
            .MinimumLength(8);
        RuleFor(x => x.ConfirmPassword)
            .Equal(e => e.Password);

        RuleFor(x => x.Email)
            .Custom((value, context) =>
            {
                var emailInUse = db.Users.Any(u => u.Email == value);
                if (emailInUse)
                {
                    context.AddFailure("Email is taken!");
                }
            });
    }
}