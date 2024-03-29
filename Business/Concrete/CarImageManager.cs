﻿using Business.Abstract;
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
using Business.Constants;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Transaction;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;
        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }
        
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(IFormFile objectFile, string filePath, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimit(carImage.CarId),checkid(carImage.CarId));
            if (result != null)
            { return result; }
            else
            {
                carImage.ImagePath = FileHelper.AddFile(objectFile, filePath);
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.CarImageAdded);
            }

        }

        [TransactionScopeAspect]
        public IResult Delete(string filepath,CarImage carImage)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            { return result; }


            FileHelper.Delete(filepath,CarImagePath(carImage.Id));
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);

        }
        
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(IFormFile objectFile, string filePath, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(objectFile, filePath,CarImagePath(carImage.Id));
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Successupdated);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            if (!checkid(carId).Success)
            { return new ErrorDataResult<List<CarImage>>(Messages.CarRegistrationNotFound); }
            else
            {
                var result = _carImageDal.GetAll(c => c.CarId == carId);
                if (result.Count == 0)
                {result = new List<CarImage> { new CarImage { Id = 0, CarId = carId, ImagePath = "default.png" } }; }
                return new SuccessDataResult<List<CarImage>>(result);
            }
        }

        private string CarImagePath(int id)
        {
            return _carImageDal.Get(c => c.Id == id).ImagePath;
        }
        private IResult CheckIfImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(r => r.CarId == carId);
            if (result.Count <= 5)
            { return new SuccessResult(); }
            else
            { return new ErrorResult(Messages.LimitError); }
        }

        private IResult checkid(int carId)
        {
            var result = _carService.GetAll();
            foreach (var i in result.Data)
            {if (i.Id == carId)
                { return new SuccessResult(); } }
            return new ErrorResult();
        }
        
    }
}
