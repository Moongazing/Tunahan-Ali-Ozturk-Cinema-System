using System;
using System.Collections.Generic;
using System.Text;
using TAO_Core.Entities;

namespace TAO.CinemaSystem.Entities.Concrete
{
  public class Customer:IEntity
  {
    public int Id { get; set; }
    public string TCNK { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public bool ReceiveSms { get; set; }
    public bool ReceiveMail { get; set; }
  }
}
