using FluentValidation;

namespace MangaLibApp.Models.Validators;

public class CoverValidator : AbstractValidator<UploadCoverDto>
{
    public CoverValidator()
    {
        RuleFor(n => n.Name)
            .NotEmpty();
        RuleFor(d => d.Data)
            .NotEmpty();
        RuleFor(m => m.MangaName)
            .NotEmpty();
    }
}