using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;

namespace TAO.CinemaSystem.Business.ValidationRules.FluentValidation
{
  public class HallValidator:AbstractValidator<Hall>
  {
    public HallValidator()
    {
      RuleFor(h => h.Capacity).NotEmpty();
      RuleFor(h => h.Name).NotEmpty();
    }
  }
}
