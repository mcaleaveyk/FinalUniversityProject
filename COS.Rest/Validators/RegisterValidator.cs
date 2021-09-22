using System;
using FluentValidation;

using COS.Core.DTOs;
using COS.Data.Services;

namespace COS.Rest.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator(ICafeService _svc)
        {
            RuleFor(p => p.FirstName).NotEmpty().MaximumLength(15);

            RuleFor(p => p.LastName).NotEmpty().MaximumLength(15);

            RuleFor(p => p.Email).NotEmpty().EmailAddress();

            RuleFor(p => p.Password).NotEmpty().MinimumLength(3);
            
            RuleFor(p => p.ConfirmPassword).Equal(p => p.Password);

            RuleFor(p => p.Role).IsInEnum();
            
            RuleFor(p => p.Email).NotEmpty()
            .Custom((email, context) => {
                if ((_svc.GetUserByEmailAddress(email) != null)) {
                    context.AddFailure("EmailAddress", "Email has already been registered. Please use another.");
                }
            });            
        }    
    }
}