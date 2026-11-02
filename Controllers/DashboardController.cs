using Microsoft.AspNetCore.Mvc;

namespace InsuraV2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}