using Microsoft.AspNetCore.Mvc;

namespace Buoi3_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult moitao()
        {
            ViewBag.Message = "tui moi tao a";
            ViewBag.Date = DateTime.Now;
            return View();
        }

    }
}
