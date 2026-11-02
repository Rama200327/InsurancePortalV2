
using InsuraV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuraV2.Controllers
{
    public class AuthController : Controller
    {
        private static Dictionary<string, string> OtpStore =
            new Dictionary<string, string>();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var otp = new Random().Next(100000, 999999).ToString();

            OtpStore[model.Email] = otp;

            // Send Email Here
            Console.WriteLine($"OTP: {otp}");

            return RedirectToAction("VerifyOtp",
                new { email = model.Email });
        }

        public IActionResult VerifyOtp(string email)
        {
            return View(new OTP
            {
                Email = email
            });
        }

        [HttpPost]
        public IActionResult VerifyOtp(OTP model) 
        {
            if (OtpStore.ContainsKey(model.Email) &&
                OtpStore[model.Email] == model.OtpCode)
            {
                HttpContext.Session.SetString(
                    "UserEmail",
                    model.Email);

                return RedirectToAction(
                    "Index",
                    "Home");
            }

            ViewBag.Error = "Invalid OTP";

            return View(model);
        }
    }
}