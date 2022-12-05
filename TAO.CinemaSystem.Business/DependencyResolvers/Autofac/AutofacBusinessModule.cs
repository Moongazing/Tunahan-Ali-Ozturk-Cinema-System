using System;
using System.Collections.Generic;
using Autofac;
using System.Text;
using TAO.CinemaSystem.Business.Abstract;
using TAO.CinemaSystem.Business.Concrete;
using TAO.CinemaSystem.DataAccess.Concrete.EntityFramework;
using TAO.CinemaSystem.DataAccess.Abstract;

namespace TAO.CinemaSystem.Business.DependencyResolvers.Autofac
{
  public class AutofacBusinessModule:Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<MovieManager>().As<IMovieService>().SingleInstance();
      builder.RegisterType<EfMovieDal>().As<IMovieDal>().SingleInstance();


    }
  }
}
