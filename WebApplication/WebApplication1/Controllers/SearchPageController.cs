using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SearchPageController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
