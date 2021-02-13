using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, CarsContext>, ICustomerDal
    {
    }
}
