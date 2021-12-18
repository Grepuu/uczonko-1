using Codetown.Biuromat.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codetown.Biuromat.Web.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IAdminService _adminService;
        
        public AdministrationController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult BuildingList()
        {
            return View();
        }
        
        public IActionResult BuildingDetails()
        {
            return View();
        }
        
        public IActionResult RoomList()
        {
            return View();
        }
        
        public IActionResult RoomDetails()
        {
            return View();
        }
        
        public IActionResult RoleList()
        {
            return View();
        }
        
        public IActionResult RoleDetails()
        {
            return View();
        }
        
        public IActionResult UserList()
        {
            return View();
        }
        
        public IActionResult UserDetails()
        {
            return View();
        }
    }
}