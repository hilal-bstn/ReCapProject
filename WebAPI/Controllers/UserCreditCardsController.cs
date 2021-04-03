using Business.Abstract;
using Entities.Concrete;
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
    public class UserCreditCardsController : ControllerBase
    {
        IUserCreditCardService _userCreditCardService;

        public UserCreditCardsController(IUserCreditCardService userCreditCardService)
        {
            _userCreditCardService = userCreditCardService;
        }
        [HttpPost("add")]
        public IActionResult Add(UserCreditCard creditCard)
        {

            var result = _userCreditCardService.Add(creditCard);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int id)
        {
            var result = _userCreditCardService.GetByUserId(id);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
    }
}
