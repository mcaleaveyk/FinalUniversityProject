using FluentValidation;
using COS.Core.DTOs;

namespace COS.Wasm.Validators
{
    public class AddItemValidator : AbstractValidator<ItemDto>
    {
        public AddItemValidator()
        {
            RuleFor(p => p.CategoryId).NotNull().NotEqual(0).WithMessage("Select a category");
            RuleFor(p => p.Name).NotEmpty().MaximumLength(25);
            RuleFor(p => p.Price).LessThan(100);
            RuleFor(p => p.Name).MaximumLength(100);
            RuleFor(p => p.Size).NotNull();

        }
    }
}