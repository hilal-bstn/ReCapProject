﻿using Business.Abstract;
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
        
        [HttpGet("checkFindeksScore")]
        public ActionResult checkFindeksScore(int carId, int customerId)
        {
            var result =_customerFindeksScoreService.CheckFindeksScore(carId, customerId);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
