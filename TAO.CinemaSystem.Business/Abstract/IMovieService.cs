using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;

namespace TAO.CinemaSystem.Business.Abstract
{
  public interface IMovieService
  {
    IResult Add(Movie movie);
    IResult Delete(Movie movie);
    IResult Update(Movie movie);
    IDataResult<List<Movie>> GetAll();
    IDataResult<List<Movie>> GetByDirector(string director);
    IDataResult<List<Movie>> GetByPublisher(string publisher);
    IDataResult<List<Movie>> GetByHall(int hallId);
    IDataResult<List<Movie>> GetByDuration(DateTime duration);
    IDataResult<List<Movie>> GetByReleaseDate(DateTime releaseDate);
    IDataResult<List<Movie>> GetByVisionDate(DateTime visionDate);
    IDataResult<List<Movie>> GetByVisionEndDate(DateTime visionEndDate);
    IDataResult<List<Movie>> GetByMovieName(string movieName);

  }
}
