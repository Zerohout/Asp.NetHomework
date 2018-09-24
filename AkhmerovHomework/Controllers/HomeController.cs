using Microsoft.AspNetCore.Mvc;

namespace AkhmerovHomework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}