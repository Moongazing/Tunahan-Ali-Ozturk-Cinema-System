using System;
using System.Collections.Generic;
using System.Text;
using TAO_Core.Entities;

namespace TAO.CinemaSystem.Entities.Concrete
{
  public class Movie:IEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Hall { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime VisionDate{ get; set; }
    public DateTime VisionEndDate { get; set; }
    public DateTime Duration { get; set; }
    public DateTime Session { get; set; }
    public string Director { get; set; }
    public string Publisher { get; set; }

  }
}
