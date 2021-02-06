using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {if (brand.BrandName.Length <= 2)
            { Console.WriteLine("Girdiğiniz bilgileri kontrol ediniz"); }
            else {_brandDal.Add(brand); }
           
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
           return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.BrandId == id);
        }

        public Brand GetByBrandName(string name)
        {
            return _brandDal.Get(b=>b.BrandName==name);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
