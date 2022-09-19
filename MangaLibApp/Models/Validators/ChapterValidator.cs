using FluentValidation;

namespace MangaLibApp.Models.Validators;

public class ChapterValidator : AbstractValidator<UploadChapterDto>
{
    public ChapterValidator()
    {
        RuleFor(n => n.Name)
            .NotEmpty();
        RuleFor(m => m.MangaName)
            .NotEmpty();
        RuleFor(c => c.ChapterName)
            .NotEmpty();
        RuleFor(p => p.Pages)
            .NotEmpty();
    }
}