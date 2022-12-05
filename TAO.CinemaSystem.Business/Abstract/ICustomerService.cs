using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results;

namespace TAO.CinemaSystem.Business.Abstract
{
  public interface ICustomerService
  {
    IResult Add(Customer customer);
    IResult Delete(Customer customer);
    IResult Update(Customer customer);
    IDataResult<List<Customer>> GetAll();
    IDataResult<List<Customer>> GetByTCNK(string tcnk);
    IDataResult<List<Customer>> GetByFirstName(string firstName);
    IDataResult<List<Customer>> GetByLastName(string lastName);
    IDataResult<List<Customer>> GetByName(string firstName, string lastName);
    IDataResult<List<Customer>> GetByPhoneNumber(string phoneNumber);
    IDataResult<List<Customer>> GetByGender(string gender);
    IDataResult<List<Customer>> GetByBirthDate(DateTime birthDate);
    IDataResult<List<Customer>> GetById(int id);
  }
}
