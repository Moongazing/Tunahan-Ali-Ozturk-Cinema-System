using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Business.Abstract;
using TAO.CinemaSystem.Business.Constans;
using TAO.CinemaSystem.DataAccess.Abstract;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.CinemaSystem.Business.Concrete
{
  public class HallManager : IHallService
  {
    IHallDal _hallDal;
    public HallManager(IHallDal hallDal)
    {
      _hallDal = hallDal;
    }

    public IResult Add(Hall hall)
    {
      _hallDal.Add(hall);
      return new SuccessResult(Messages.HallAddedSuccessfly);
    }

    public IResult Delete(Hall hall)
    {
      _hallDal.Delete(hall);
      return new SuccessResult(Messages.HallDeletedSuccessfly);
    }

    public IDataResult<List<Hall>> GetAll()
    {
      return new SuccessDataResult<List<Hall>>(_hallDal.GetAll(),Messages.HallsListed);
    }

    public IDataResult<List<Hall>> GetByCapacity(int capacity)
    {
      return new SuccessDataResult<List<Hall>>(_hallDal.GetAll(h=>h.Capacity == capacity), Messages.HallsListed);
    }

    public IDataResult<List<Hall>> GetById(int id)
    {
      return new SuccessDataResult<List<Hall>>(_hallDal.GetAll(h=>h.Id == id), Messages.HallsListed);
    }

    public IDataResult<List<Hall>> GetByName(string hallName)
    {
      return new SuccessDataResult<List<Hall>>(_hallDal.GetAll(h=>h.Name == hallName), Messages.HallsListed);
    }

    public IResult Update(Hall hall)
    {
      _hallDal.Update(hall);
      return new SuccessResult(Messages.HallUpdatedSuccessfly);
    }
  }
}
