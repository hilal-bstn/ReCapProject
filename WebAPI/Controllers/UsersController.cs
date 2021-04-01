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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getuserdetailsbyemail")]
        public IActionResult GetUserDetailsByEmail(string email)
        {
            var result = _userService.GetUserDetailsByEmail(email);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }
    }
}
