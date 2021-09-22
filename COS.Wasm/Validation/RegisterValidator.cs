using System;
using FluentValidation;
using COS.Core.DTOs;
using COS.Wasm.Services;

namespace COS.Wasm.Validation
{
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {

        public RegisterValidator(AuthService _svc)
        {            
            RuleFor(p => p.FirstName).NotEmpty()
                .MaximumLength(15);  
            
            RuleFor(p => p.LastName).NotEmpty()
                .MaximumLength(15); 

            RuleFor(p => p.Password).NotEmpty()
                .MinimumLength(3);
                        
            RuleFor(p => p.ConfirmPassword).Equal(p => p.Password); 

            RuleFor(p => p.Email)
                .NotEmpty()
                .EmailAddress()
                .MustAsync(async (email, cancellation) => {    
                    return await _svc.VerifyEmailAvailableAsync(email);
                }).WithMessage("EmailAddress is already registered");                 
        }
           
    }    
}


