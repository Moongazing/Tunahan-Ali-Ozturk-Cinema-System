using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.DataAccess;

namespace TAO.CinemaSystem.DataAccess.Abstract
{
  public interface IHallDal: IEntityRepository<Hall>
  {
  }
}
