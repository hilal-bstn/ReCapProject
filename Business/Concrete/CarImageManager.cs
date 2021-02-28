using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.FileHelper;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;

        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(IFormFile objectFile, string filePath, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimit(carImage.CarId));
            if (result != null)
            { return result; }
            else
            {
                carImage.ImagePath = CheckImagePath(objectFile, filePath);
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult();
            }

        }


        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            { return result; }


            FileHelper.Delete(CarImagePath(carImage));
            _carImageDal.Delete(carImage);
            return new SuccessResult();

        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(IFormFile objectFile, string filePath, CarImage carImage)
        {
            carImage.ImagePath = CheckDefaultImage(objectFile, filePath, carImage);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarId(int CarId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == CarId));
        }


        private string CheckDefaultImage(IFormFile objectFile, string filePath, CarImage carImage)
        {
            if (CarImagePath(carImage) == filePath + "default.png")
            { return (filePath + FileHelper.AddFile(objectFile, filePath)); }
            else
            { return (FileHelper.Update(objectFile, filePath, CarImagePath(carImage))); }
        }

        private static string CheckImagePath(IFormFile objectFile, string filePath)
        {
            if (objectFile != null)
            {
                return (filePath + FileHelper.AddFile(objectFile, filePath));
            }
            else
            {
                return (filePath + "default.png");
            }
        }


        private string CarImagePath(CarImage carImage)
        {
            return _carImageDal.Get(c => c.Id == carImage.Id).ImagePath;
        }

        private IResult CheckIfImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(r => r.CarId == carId);
            if (result.Count <= 5)
            { return new SuccessResult(); }
            else
            { return new ErrorResult("Bir araç için 5 adet resim yüklenebilmektedir"); }
        }
    }
}
