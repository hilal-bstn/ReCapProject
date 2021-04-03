using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserCreditCardService
    {
        IResult Add(UserCreditCard userCreditCard);
        IDataResult<List<UserCreditCard>> GetByUserId(int id);
    }
}
