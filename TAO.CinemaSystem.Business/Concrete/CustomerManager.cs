using System;
using System.Collections.Generic;
using System.Text;
using TAO.CinemaSystem.Business.Abstract;
using TAO.CinemaSystem.Business.Constans;
using TAO.CinemaSystem.Business.ValidationRules.FluentValidation;
using TAO.CinemaSystem.DataAccess.Abstract;
using TAO.CinemaSystem.Entities.Concrete;
using TAO_Core.Aspects.Autofac.Caching;
using TAO_Core.Aspects.Autofac.Validation;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Abstract;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.CinemaSystem.Business.Concrete
{
  public class CustomerManager : ICustomerService
  {
    ICustomerDal _customerDal;
    public CustomerManager(ICustomerDal customerDal)
    {
      _customerDal = customerDal;
    }
    [ValidationAspect(typeof(CustomerValidator))]
    [CacheRemoveAspect("ICustomer.Get")]
    public IResult Add(Customer customer)
    {
      _customerDal.Add(customer);
      return new SuccessResult(Messages.CustomerAddedSuccessfly);
    }

    public IResult Delete(Customer customer)
    {
      _customerDal.Delete(customer);
      return new SuccessResult(Messages.CustomerDeletedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetAll()
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByBirthDate(DateTime birthDate)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.BirthDate == birthDate), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByFirstName(string firstName)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.FirstName == firstName), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByGender(string gender)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Gender == gender), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetById(int id)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Id == id), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByLastName(string lastName)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.LastName == lastName), Messages.CustomersListedSuccessfly);
    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByName(string firstName, string lastName)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.FirstName == firstName && c.LastName == lastName), Messages.CustomersListedSuccessfly);

    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByPhoneNumber(string phoneNumber)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.PhoneNumber == phoneNumber), Messages.CustomersListedSuccessfly);

    }
    [CacheAspect]
    public IDataResult<List<Customer>> GetByTCNK(string tcnk)
    {
      return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.TCNK == tcnk), Messages.CustomersListedSuccessfly);

    }
    [ValidationAspect(typeof(CustomerValidator))]
    public IResult Update(Customer customer)
    {
      _customerDal.Update(customer);
      return new SuccessResult(Messages.CustomerUpdated);
    }
  }
}
