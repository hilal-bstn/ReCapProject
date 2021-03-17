using Business.Abstract;
using Core.Utilities.FileHelper;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;
        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _carImageService = carImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile objectFile, [FromForm] CarImage carImage)
        {
            string filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            var result = _carImageService.Add(objectFile, filePath, carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);


        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            string filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            var result = _carImageService.Delete(filePath, carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile objectFile, [FromForm] CarImage carImage)
        {
            string filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            var result = _carImageService.Update(objectFile, filePath, carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        } 
        [HttpGet("getall")]
        public IActionResult Getall(int id)
        {
            var result = _carImageService.GetByCarId(id);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("getcarid")]
        public IActionResult GetCarDetails(int id)
        {
            List<IActionResult> file = new List<IActionResult>();
            string filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            var result = _carImageService.GetByCarId(id);
            if (result.Success)
            {
                if (result.Data.Count == 0)
                {
                  file.Add(File(FileHelper.Get(filePath, "default.png"), "image/png"));
                }
                else
                {
                    foreach (var i in result.Data)
                    { file.Add(File(FileHelper.Get(filePath, i.ImagePath), "image/jpeg")); }
                }
                return file[0];
            }

            return BadRequest(result.Message);
            
        }
        }

    }
  
