using ApiProject.Models;
using ApiProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _config;


        public AccountController(IAccountService accountService, ITokenService tokenService, IConfiguration config)
        {
            _accountService = accountService;
            _tokenService = tokenService;
            _config = config;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login(string userName, string password)
        {
            UserLogin userLogin = _accountService.Login(userName, password);

            if (userLogin == null)
                return Unauthorized("Invalid Credentials");

            var token = _tokenService.CreateToken(userLogin);

            return Ok(token);
        }


    }
}
