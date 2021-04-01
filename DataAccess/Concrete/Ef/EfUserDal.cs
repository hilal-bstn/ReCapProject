using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Concrete.Ef;
using Core.DataAccess.EntitiyFramework;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarsContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarsContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
        public UserDetailDto GetUserDetails(Expression<Func<UserDetailDto, bool>> filter)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                            on u.Id equals c.UserId
                            join f in context.CustomersFindeksScores
                            on  c.CustomerId equals f.CustomerId
                             select new UserDetailDto
                             {
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CustomerId = c.CustomerId,
                                 CompanyName = c.CompanyName,
                                 FindeksScore=f.FindeksScore

                             };
                return result.SingleOrDefault(filter);
            }
        }

    }
}

