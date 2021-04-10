using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails(Expression<Func<RentalDetailsDto, bool>> filter = null)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join customer in context.Customers
                             on r.CustomerId equals customer.CustomerId
                             join u in context.Users
                             on customer.UserId equals u.Id
                             select new RentalDetailsDto { Id = r.Id, CustomerId=r.CustomerId, FirstName = u.FirstName, LastName = u.LastName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, RentDate = r.RentDate.Date, ReturnDate = r.ReturnDate, ModelYear=c.ModelYear };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
