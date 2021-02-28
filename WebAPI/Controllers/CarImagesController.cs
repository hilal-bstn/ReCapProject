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
            var filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            
            
            var result = _carImageService.Add(objectFile,filePath,carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest();


        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {   
            var result= _carImageService.Delete(carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest();
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile objectFile,[FromForm] CarImage carImage)
        {
            string filePath = _webHostEnvironment.WebRootPath + "\\Images\\";
            var result = _carImageService.Update(objectFile,filePath,carImage);
            if (result.Success)
            { return Ok(result); }
            return BadRequest();
        
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }

    }
}
