using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Rental rental)
        {
            int control = RentalDateControl(rental.CarId);
            if (control == 0)
            { return new ErrorResult(Messages.RentalError); }
            
            _rentalDal.Add(rental);
            return new SuccessResult("Araç kiralandı");
            
        }

        private int RentalDateControl(int id)
        {
            int sayac = 0;
            var result = GetAll();
            foreach (var rent in result.Data)
            {
                if (rent.CarId == id)
                {
                    if (rent.ReturnDate != null)
                    { sayac++; }
                }
            }
            return sayac;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
    
}
