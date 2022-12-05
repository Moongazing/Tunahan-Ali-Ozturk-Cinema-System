using System;
using System.Collections.Generic;
using System.Text;
using TAO_Core.Entities;

namespace TAO.CinemaSystem.Entities.Concrete
{
  public class Hall:IEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
  }
}
