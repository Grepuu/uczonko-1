using System;
using Codetown.Biuromat.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codetown.Biuromat.Web.Controllers
{
    public class AuthorisationController : Controller
    {
        private readonly IAuthService _authService;
        
        public AuthorisationController(IAuthService authService)
        {
            _authService = authService;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Registration()
        {
            return View();
        }
        
        public IActionResult PasswordReset()
        {
            return View();
        }
    }
}