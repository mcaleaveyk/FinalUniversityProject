using FluentValidation;
using COS.Core.DTOs;
using System;

namespace COS.Wasm.Validators
{
    public class OrderValidator : AbstractValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(x => x.DueFor).GreaterThanOrEqualTo(x => x.OrderTime).WithMessage("Enter a valid date/time");
            RuleFor(x => x.DueFor).LessThanOrEqualTo(DateTime.Today.AddDays(3)).WithMessage("Cannot order more than 3 days ahead");
            RuleFor(p => p.Comment).MaximumLength(200);
        }
    }
}