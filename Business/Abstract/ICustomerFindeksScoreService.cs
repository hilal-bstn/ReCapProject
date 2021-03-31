using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerFindeksScoreService
    {
        IResult Add(CustomerFindeksScore customerFindeksScore);
        IResult Update(CustomerFindeksScore customerFindeksScore);
        IDataResult<CustomerFindeksScore> GetByCustomerId(int id);
        IResult FindeksScoreAddOrUpdate(int customerId);
        IResult CheckFindeksScore(int carId, int customerId);
    }
}
