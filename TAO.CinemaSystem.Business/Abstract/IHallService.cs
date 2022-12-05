using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results;

namespace TAO.CinemaSystem.Business.Abstract
{
  public interface IHallService
  {
    IResult Add(Hall hall);
    IResult Delete(Hall hall);
    IResult Update(Hall hall);
    IDataResult<List<Hall>> GetAll();
    IDataResult<List<Hall>> GetByCapacity(int capacity);
    IDataResult<List<Hall>> GetByName(string hallName);
    IDataResult<List<Hall>> GetById(int id);
  }
}
