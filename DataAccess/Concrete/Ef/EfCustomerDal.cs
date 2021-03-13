using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarsContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto { CustomerId=c.CustomerId, FirstName=u.FirstName, LastName=u.LastName, CompanyName=c.CompanyName };

                return result.ToList();
            }
        }
    }
}
