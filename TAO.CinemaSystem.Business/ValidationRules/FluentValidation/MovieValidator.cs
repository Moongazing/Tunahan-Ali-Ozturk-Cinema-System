using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;

namespace TAO.CinemaSystem.Business.ValidationRules.FluentValidation
{
  public class MovieValidator : AbstractValidator<Movie>
  {
    public MovieValidator()
    {
      RuleFor(m => m.Name).NotEmpty();
      RuleFor(m => m.Hall).NotEmpty();
      RuleFor(m => m.Publisher).NotEmpty();
      RuleFor(m => m.Director).NotEmpty();
      RuleFor(m => m.Session).NotEmpty();
      RuleFor(m => m.Duration).NotEmpty();
      RuleFor(m => m.ReleaseDate).NotEmpty();
      RuleFor(m => m.VisionDate).NotEmpty();
      RuleFor(m => m.VisionEndDate).NotEmpty();

    }
  }
}
