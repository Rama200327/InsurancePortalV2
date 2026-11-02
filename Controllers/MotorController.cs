using InsuraV2.Data;
using InsuraV2.Models;
using InsuraV2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuraV2.Controllers    
{
    public class MotorController : Controller
    {
        private readonly InsuraDbContext _context;
        private readonly OcrService _ocrService;

        public MotorController(
            InsuraDbContext context,
            OcrService ocrService)
        {
            _context = context;
            _ocrService = ocrService;
        }

        public IActionResult Comprehensive()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateComprehensive()
        {
            return View(new Motor());
        }

        [HttpPost]
        public IActionResult CreateComprehensive(Motor motor)
        {
            if (!ModelState.IsValid)
            {
                return View(motor);
            }

            _context.Motors.Add(motor);

            _context.SaveChanges();

            return RedirectToAction("Comprehensive");
        }

        [HttpPost]
        public IActionResult ReadNationalId(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded");

            var uploadsFolder =
                Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/uploads");

            Directory.CreateDirectory(uploadsFolder);

            var filePath =
                Path.Combine(uploadsFolder, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            var extractedText =
                _ocrService.ReadText(filePath);

            return Json(new
            {
                text = extractedText
            });
        }

        public IActionResult VehicleInformation()
        {
            return View(new Motor());
        }

        public IActionResult CustomerInformation()
        {
            return View(new Motor());
        }

        public IActionResult BenefitsCoverage()
        {
            return View(new Motor());
        }

        public IActionResult PaymentCycle()
        {
            return View(new Motor());
        }

        public IActionResult FinalQuotation()
        {
            return View(new Motor());
        }

        public IActionResult Renewal()
        {
            return View();
        }
        public IActionResult FleetQuotation()
        {
            return View();
        }
    

    }

}
