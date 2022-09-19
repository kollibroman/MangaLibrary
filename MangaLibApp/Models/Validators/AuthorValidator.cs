using FluentValidation;

namespace MangaLibApp.Models.Validators;

public class AuthorValidator : AbstractValidator<CreateAuthorDto>
{
    public AuthorValidator()
    {
        RuleFor(n => n.Name)
            .MaximumLength(50)
            .NotEmpty();
        RuleFor(s => s.Surname)
            .MaximumLength(50)
            .NotEmpty();
        RuleFor(w => w.WrittenMangas)
            .NotEmpty();
    }
}