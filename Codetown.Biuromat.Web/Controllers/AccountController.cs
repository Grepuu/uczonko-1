using Codetown.Biuromat.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codetown.Biuromat.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult PasswordChange()
        {
            _accountService.ChangePassword("12345", "56789", "12346");
            return View();
        }
        
        public IActionResult Profile()
        {
            // dołączane pliki jako lista
            return View();
        }
        
        public IActionResult AddFile()
        {
            return View();
        }
        
        public IActionResult Access()
        {
            //dostępy wg budynków i pokoi
            return View();
        }
        
        public IActionResult Room()
        {
            return View();
        }
    }
}