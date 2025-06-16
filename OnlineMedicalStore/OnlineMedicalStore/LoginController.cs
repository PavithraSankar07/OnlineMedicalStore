using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMedicalStore.Components.Pages;
using OnlineMedicalStore.Models;
using OnlineMedicalStore.Service;


namespace OnlineMedicalStore
{
    [ApiController]
    [Route("login")]

    public class LoginController : Controller
    {
        private readonly UserService _userService;
        public LoginController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserInfo user)
        {
            var existingUser = _userService.Login(user.Email, user.Password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Name),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim(ClaimTypes.Role,"Admin")
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
              
                await HttpContext.SignInAsync("Cookies", principal);
                return Redirect("/home");
            }
        }
    }
}