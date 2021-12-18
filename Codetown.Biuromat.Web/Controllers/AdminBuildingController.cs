using Codetown.Biuromat.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codetown.Biuromat.Web.Controllers
{
    public class AdminBuildingController : Controller
    {
        private readonly IAdminService _adminService;
        
        public AdminBuildingController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        
        public IActionResult Index()
        {
            return View(_adminService.GetBuildingList());
        }
        
        public IActionResult Details(int id)
        {
            return View(_adminService.GetOneBuilding(id));
        }
        
        public IActionResult PrepareDatabase()
        {
            _adminService.SeedBuldings();
            return RedirectToAction(nameof(Index));
        }
    }
}