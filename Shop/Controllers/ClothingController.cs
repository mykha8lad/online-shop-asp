using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class ClothingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}