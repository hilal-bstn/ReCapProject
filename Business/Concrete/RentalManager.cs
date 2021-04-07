using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICustomerFindeksScoreService _customerFindeksScoreService;
        
        public RentalManager(IRentalDal rentalDal, ICustomerFindeksScoreService customerFindeksScoreService)
        {
            _rentalDal = rentalDal;
            _customerFindeksScoreService = customerFindeksScoreService;
           
        }

        //[SecuredOperation("rental.add,user")]
        [ValidationAspect(typeof(RentalValidator))]
        [TransactionScopeAspect]//kiralama ve findekspuanı ekleme işleminin sırayla yapılması için.
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckRentDate(rental));
            if (result != null)
            { 
                return new ErrorResult("Araç girdiğiniz tarihlerde uygun değil."); }

            else {
                _rentalDal.Add(rental);
                _customerFindeksScoreService.FindeksScoreAddOrUpdate(rental.CustomerId);
                return new SuccessResult("Araç kiralandı"); }
            
            
        }
        [SecuredOperation("admin")]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails(), Messages.RentalDetailsListed);

        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
        //return tarihler null olduğunda(eski)
        private IResult CheckReturnDate(int id)
        {
            var result = _rentalDal.GetAll(r => r.CarId == id && r.ReturnDate == null);
            if (result.Count ==0)
            { return new SuccessResult(); }
            else
            { return new ErrorResult(); }
        }
        //return tarihler girilmeye başlandığında(yeni)
        //tablo:5.3.2021-8.3.2021
        //olasılıklar--tek bir kayıt için
        //gönderilen1:4.3.2021-9.3.2021
        //gönderilen2:6.3.2021-9.3.2021
        //gönderilen3:4.3.2021-7.3.2021
        //gönderilen4:6.3.2021-7.3.2021 
        //bu olasıklara göre Yeni Kural:
        private IResult CheckRentDate(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && 
            (r.RentDate<=rental.RentDate&&rental.RentDate<=r.ReturnDate)
            || (rental.RentDate <= r.RentDate&& r.RentDate <= rental.ReturnDate));
            if (result.Count == 0)
            { return new SuccessResult(); }
            else
            { return new ErrorResult(); }
        }
        //(araçdurum)rentalId,aracıteslimedenkişi(firmadan),tarih,aracıteslimalankişi(firmadan),tarih
        
        

        

    }
    
}
