using InsuraV2.Repositories;
using InsuraV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuraV2.Controllers
{
    public class MarineController : Controller
    {   //An action to display BasicInfo of MarinePolicy
        public IActionResult Renewal()
        {
            return View();
        }

        public IActionResult Quotation()
        {
            return View();
        }
    }
}
