using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}