﻿using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, CarsContext>,IRentalDal
    {
    }
}
