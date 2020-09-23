using Microsoft.AspNetCore.Mvc;
using TradinPlatform.Basic.Models;
using TradinPlatform.Basic;

namespace WebApplication1.Controllers
{
    public class SearchPageController: Controller
    {
        private readonly IServiceItems _serviceItems;
        public IActionResult Index(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery) || string.IsNullOrEmpty(searchQuery))
            {
                return RedirectToAction("Index");
            }
            var searchItems = _serviceItems.GetFilterProduct(searchQuery);
            var model = _ma
            return View(model);
        }
    }
}
