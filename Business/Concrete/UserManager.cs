using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
        public IDataResult<UserDetailDto> GetUserDetailsByEmail(string email)
        {
            var result = GetByMail(email);
            return new SuccessDataResult<UserDetailDto>(_userDal.GetUserDetails(u => u.UserId == result.Id));
        }
        public void Update(User user)
        {
            _userDal.Update(user);
        }
        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }
    }
}