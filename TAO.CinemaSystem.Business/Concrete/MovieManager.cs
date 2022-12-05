using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Business.Abstract;
using TAO.CinemaSystem.Business.Constans;
using TAO.CinemaSystem.Business.ValidationRules.FluentValidation;
using TAO.CinemaSystem.DataAccess.Abstract;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Aspects.Autofac.Caching;
using TAO_Core.Aspects.Autofac.Validation;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.CinemaSystem.Business.Concrete
{
  public class MovieManager : IMovieService
  {
    IMovieDal _movieDal;
    public MovieManager(IMovieDal movieDal)
    {
      _movieDal = movieDal;
    }

    [ValidationAspect(typeof(MovieValidator))]
    [CacheRemoveAspect("IMovieService.Get")]

    public IResult Add(Movie movie)
    {
      _movieDal.Add(movie);
      return new SuccessResult(Messages.MovieAddedSuccessfly);
    }

    public IResult Delete(Movie movie)
    {
      _movieDal.Delete(movie);
      return new SuccessResult(Messages.MovieDeletedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetAll()
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(),Messages.MoviesListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByDirector(string director)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.Director == director), Messages.MoviesListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByDuration(DateTime duration)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.Duration == duration), Messages.MoviesListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByHall(int hallId)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.HallId == hallId), Messages.MoviesListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByMovieName(string movieName)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.Name == movieName), Messages.MoviesListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByPublisher(string publisher)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.Publisher == publisher), Messages.MoviesListedSuccessfly);

    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByReleaseDate(DateTime releaseDate)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.ReleaseDate == releaseDate), Messages.MoviesListedSuccessfly);

    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByVisionDate(DateTime visionDate)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.VisionDate == visionDate), Messages.MoviesListedSuccessfly);

    }
    [CacheAspect]
    public IDataResult<List<Movie>> GetByVisionEndDate(DateTime visionEndDate)
    {
      return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m=>m.VisionEndDate == visionEndDate), Messages.MoviesListedSuccessfly);

    }

    [ValidationAspect(typeof(MovieValidator))]
    public IResult Update(Movie movie)
    {
      _movieDal.Update(movie);
      return new SuccessResult(Messages.MovieUpdated);
    }
  }
}
