using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;

namespace TAO.CinemaSystem.Business.ValidationRules.FluentValidation
{
  public class CustomerValidator:AbstractValidator<Customer>
  {
    public CustomerValidator()
    {
      RuleFor(c => c.TCNK).NotEmpty();
      RuleFor(c => c.FirstName).NotEmpty();
      RuleFor(c => c.LastName).NotEmpty();
      RuleFor(c => c.PhoneNumber).NotEmpty();
      RuleFor(c => c.Email).NotEmpty();
      RuleFor(c => c.Gender).NotEmpty();
      RuleFor(c => c.BirthDate).NotEmpty();
      RuleFor(c => c.Email).EmailAddress();
      RuleFor(c => c.TCNK).Length(11);
    }
  }
}
