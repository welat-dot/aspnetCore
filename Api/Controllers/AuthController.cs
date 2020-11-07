using Business.Abstract;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [Route(template:"Login")]
        public IActionResult Login (ForLoginDto forLoginDto)
        {
            var userLogin = authService.Login(forLoginDto);
            if(!userLogin.success)
            {
                return BadRequest(userLogin.message);
            }
            var result = authService.CreateAccessToken(userLogin.data,forLoginDto.DataBaseName);
            if(result.success)
            {
                return Ok(result.data);
            }
            return BadRequest(result.message);
        }
        [Route(template: "Register")]
        public IActionResult Register(ForRegisterDTO  forRegisterDTO)
        {
           
            var registerResult = authService.Register(forRegisterDTO, forRegisterDTO.Password);
            if(registerResult.success)
            {
                return Ok(registerResult.message);
            }
            return BadRequest(registerResult.message);
        }
    }
}
