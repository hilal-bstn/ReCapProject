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
    public class UserCreditCardManager : IUserCreditCardService
    {
        IUserCreditCardDal _userCreditCardDal;

        public UserCreditCardManager(IUserCreditCardDal userCreditCardDal)
        {
            _userCreditCardDal = userCreditCardDal;
        }

        public IResult Add(UserCreditCard userCreditCard)
        {
           _userCreditCardDal.Add(userCreditCard);
            return new SuccessResult(Messages.CredidCardAdd);
        }
        public IDataResult<List<UserCreditCard>> GetByUserId(int id)
        {
            var result = _userCreditCardDal.GetAll(u => u.UserId == id);
            if (result != null)
            { 
            return new SuccessDataResult<List<UserCreditCard>>(result);
            }
            return new ErrorDataResult<List<UserCreditCard>>();
        }
    }
}
