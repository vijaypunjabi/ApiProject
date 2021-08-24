using ApiProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public   UserController (IUserServices userServices)
        {
            _userServices = userServices;

        }
        [HttpGet]
        [Route("GetUserDetails")]

        public IActionResult GetUserDetails()
        {
            return Ok(_userServices.GetUserDetails());
        }

    }

}
