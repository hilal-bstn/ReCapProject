﻿using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Ef
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto {
                                 CarId = c.Id,
                                 ColorId=c.ColorId,
                                 BrandId = b.BrandId,
                                 ModelYear=c.ModelYear,
                                 BrandName=b.BrandName,
                                 ColorName=r.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 Description=c.Description};
                             

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
