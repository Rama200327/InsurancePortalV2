using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace InsuraV2.Controllers
{
    public class MedicalController : Controller
    {
        public IActionResult MedicalIssuance()
        {
            return View();
        }
        public IActionResult MedicalRenewal()
        {
            return View();
        }
        
        public IActionResult MedicalQuotation()
        {
            return View();
        }
    }
}