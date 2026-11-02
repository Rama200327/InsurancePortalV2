using Microsoft.AspNetCore.Mvc;
namespace InsuraV2.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Individual()
        {
            return View();
        }
        public IActionResult Family()
        {
            return View();
        }
       
    }
}