using FluentValidation;

namespace MangaLibApp.Models.Validators;

public class UpdateAuthorValidator : AbstractValidator<UpdateAuthorDto>
{
    public UpdateAuthorValidator()
    {
        RuleFor(w => w.WrittenMangas)
            .NotEmpty();
    }
}