using FluentValidation;
using ErhasTicaret.Core.DTOs;

namespace ErhasTicaret.Core.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori adı boş olamaz.");
        }
    }
}
