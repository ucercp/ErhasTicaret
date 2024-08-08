using FluentValidation;
using ErhasTicaret.Core.DTOs;

namespace ErhasTicaret.Core.Validators
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Ürün açıklaması boş olamaz.");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı sıfırdan büyük olmalıdır.");
        }
    }
}
