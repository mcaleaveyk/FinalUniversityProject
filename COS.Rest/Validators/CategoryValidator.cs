using FluentValidation;
using COS.Core.DTOs;

namespace COS.Rest.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Name).NotEmpty().MaximumLength(20).NotNull();
        
        }
    }
}