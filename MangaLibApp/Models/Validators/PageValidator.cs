using FluentValidation;

namespace MangaLibApp.Models.Validators;

public class PageValidator : AbstractValidator<UploadPageDto>
{
    public PageValidator()
    {
        RuleFor(p => p.PageData)
            .NotEmpty();
        RuleFor(m => m.MangaName)
            .NotEmpty();
    }
}