using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersFindeksScoresController : ControllerBase
    {
        ICustomerFindeksScoreService _customerFindeksScoreService;

        public CustomersFindeksScoresController(ICustomerFindeksScoreService customerFindeksScoreService)
        {
            _customerFindeksScoreService = customerFindeksScoreService;
        }
        //puan ekleme kiralama yapılırken
        [HttpGet("checkFindeksScore")]
        public IActionResult CheckFindeksScore(int carId, int customerId)
        {
            var result = _customerFindeksScoreService.CheckFindeksScore(carId, customerId);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
    }
}
