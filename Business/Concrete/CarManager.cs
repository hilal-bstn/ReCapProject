using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ( car.DailyPrice <= 0)
            {
                throw new NotImplementedException("Daily price must be positive");
            }
            else { _carDal.Add(car); }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.Id==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarsByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear.Year == year);
        }

        public List<Car> GetCarsModelYears(int min, int max)
        {
            return _carDal.GetAll(c => c.ModelYear.Year >= min && c.ModelYear.Year <= max);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

