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
    [Route("api/login")]

    public class LoginController : Controller
    {
        private readonly UserService _userService;
        public LoginController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginInfo user)
        {
           
            var existingUser = _userService.Login(user.Email, user.Password);
            if (existingUser != null)
          {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,existingUser.Name),
                    new Claim(ClaimTypes.Email,existingUser.Email),
                    new Claim(ClaimTypes.Role,existingUser.Role)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));
                
                return Ok(new { message = "Login" });
            }
            
            return Unauthorized(new { message = "Invalid" });
        }
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return Redirect("/");
        }
    }
}