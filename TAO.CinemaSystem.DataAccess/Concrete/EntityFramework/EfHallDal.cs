using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.DataAccess.Abstract;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.DataAccess.EntityFramework;

namespace TAO.CinemaSystem.DataAccess.Concrete.EntityFramework
{
  public class EfHallDal:EfEntityRepositoryBase<Hall,CinemaSystemContext>,IHallDal
  {
  }
}
