using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
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
        {if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            { Console.WriteLine("Yanlış bilgi girdiniz."); }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

