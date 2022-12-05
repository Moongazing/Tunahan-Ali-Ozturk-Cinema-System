using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Business.Abstract;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;

namespace TAO.CinemaSystem.Business.Concrete
{
  public class CustomerManager : ICustomerService
  {
    public IResult Add(Customer customer)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Customer customer)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetAll()
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByBirthDate(DateTime birthDate)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByFirstName(string firstName)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByGender(string gender)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByLastName(string lastName)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByName(string firstName, string lastName)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByPhoneNumber(string phoneNumber)
    {
      throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetByTCNK(string tcnk)
    {
      throw new NotImplementedException();
    }

    public IResult Update(Customer customer)
    {
      throw new NotImplementedException();
    }
  }
}
