using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerFindeksScoreManager : ICustomerFindeksScoreService
    {
        ICustomerFindeksScoreDal _customerFindeksScoreDal;
        ICarService _carService;

        public CustomerFindeksScoreManager(ICustomerFindeksScoreDal customerFindeksScoreDal, ICarService carService)
        {
            _customerFindeksScoreDal = customerFindeksScoreDal;
            _carService = carService;
        }

        public IResult Add(CustomerFindeksScore customerFindeksScore)
        {
            _customerFindeksScoreDal.Add(customerFindeksScore);
            return new SuccessResult(Messages.CustomerFindeksScoreAdded);
        }

        public IResult Update(CustomerFindeksScore customerFindeksScore)
        {
            _customerFindeksScoreDal.Update(customerFindeksScore);
            return new SuccessResult(Messages.CustomerFindeksScoreUpdated);
        }
        public IDataResult<CustomerFindeksScore> GetByCustomerId(int id)
        {
            var result = _customerFindeksScoreDal.Get(u => u.CustomerId == id);
            if (result != null)
            {
                return new SuccessDataResult<CustomerFindeksScore>(result);
            }
            else
            {
                return new ErrorDataResult<CustomerFindeksScore>();
            }
        }
        private int checkTotalScore(int id)//customerid ye ait puan sorgulaması
        {
            var result = GetByCustomerId(id);
            int total = 0;
            if (result.Success)
            {
                total = result.Data.FindeksScore;
            }
            else { total = 0; }
            return total;
        }
        public IResult CheckFindeksScore(int carId, int customerId)//müşterinin araç için findeks puanının sorgulanması
        {
            var car = _carService.GetById(carId);
            var customerfindeksscore = checkTotalScore(customerId);
            if (customerfindeksscore >= car.Data.MinFindeksScore)
            {
                return new SuccessResult("Findeks puanı onaylandı");
            }
            else { return new ErrorResult("Findeks puanı yetersiz."); }
        }
        public IResult FindeksScoreAddOrUpdate(int customerId) //findeks puanı varsa güncelleme yapılarak gerekli puan eklenir.
        {//müşterinin findeks puanı yoksa yani daha önce araç kiralamadıysa findeks puanı eklenir.
            var customerTotalPoint = checkTotalScore(customerId);
            if (customerTotalPoint == 0)//daha önce araç kiralanmadıysa totalpuan=0 olur. yeni kayıt açılır
            {
                Add(new CustomerFindeksScore { CustomerId = customerId, FindeksScore = point(customerId) });
                return new SuccessResult();
            }
            else//kayıt varsa güncelleme yapılır puan eklenir.
            {
                var result = GetByCustomerId(customerId);
                var data = result.Data;
                Update(new CustomerFindeksScore { Id = data.Id, CustomerId = data.CustomerId, FindeksScore = data.FindeksScore + point(customerId) });
                return new SuccessResult();
            }

        }
        private int point(int customerId)
        {//her araç kiralandığında 100 puan eklenir. eğer 1900 ulaştıysa puan eklemesi olmaz
            var point = 100;
            var totalpoint = checkTotalScore(customerId);
            if (totalpoint + point > 1900)//toplam puanın 1900 den büyük olmaması için
            {
                point = 0;
            }
            return point;

        }



    }
}
