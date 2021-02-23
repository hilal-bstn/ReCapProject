using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var check = CheckReturnDate(rental.CarId);
            if (!check.Success)
            { return new ErrorResult(Messages.RentalError); }
            
            else {_rentalDal.Add(rental);
            return new SuccessResult("Araç kiralandı"); }
            
            
        }
       
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {if (rental.ReturnDate < rental.RentDate)
            { return new ErrorResult("Güncellenemedi"); }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult CheckReturnDate(int id)
        {
            var result = _rentalDal.GetAll(r => r.CarId == id && r.ReturnDate == null);
            if (result.Count ==0)
            { return new SuccessResult(); }
            else
            { return new ErrorResult(); }
        }
    }
    
}
