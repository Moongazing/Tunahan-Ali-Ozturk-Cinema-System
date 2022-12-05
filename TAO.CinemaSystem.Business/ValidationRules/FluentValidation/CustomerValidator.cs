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

    }
  }
}
