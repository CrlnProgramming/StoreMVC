using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BussinesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bussines()
        {
            return View();
        }
    }
}
