using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        void Update(User user);
        User GetByMail(string email);
        User GetById(int id);
        IDataResult<UserDetailDto> GetUserDetailsByEmail(string email);

    }
}
