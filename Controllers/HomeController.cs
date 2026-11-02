
using InsuraV2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InsuraV2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //LocalHost or Index Bage
        {
            return View();
        }

        //the IActionResult will search about (Views/Privacy) then will display it 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //when happen error, the MVC or the web bage will display an designed error bage instead red bage !
        public IActionResult Error()
        {

            //RequistId -> each requist in the portal has an Id, So if an error happens the developer will be able to Track thr error, or will know wich requist cause this error.
            //Current?.Id means -->  if the web bage current have an requist, return it's Id.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
    }
}