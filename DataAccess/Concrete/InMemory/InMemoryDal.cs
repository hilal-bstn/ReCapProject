using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=new DateTime(2017,01,01),DailyPrice=250,Description="Audi" },
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=new DateTime(2014,01,01),DailyPrice=280,Description="Volkswagen " },
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=new DateTime(2016,01,01),DailyPrice=200,Description="Ford" },
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=new DateTime(2014,01,01),DailyPrice=350,Description="Bmw" },
                new Car{Id=5,BrandId=5,ColorId=4,ModelYear=new DateTime(2015,01,01),DailyPrice=200,Description="Renault" },

            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}

