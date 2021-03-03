using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetByCarId(int CarId);
        IResult Add(IFormFile objectfile, string filePath,CarImage carImage);
        IResult Update(IFormFile objectfile,string filePath,CarImage carImage);
        IResult Delete(string filepath,CarImage carImage);
    }
}
